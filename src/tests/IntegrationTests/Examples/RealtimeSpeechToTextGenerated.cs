/*
order: 85
title: Realtime STT (Generated Client)
slug: realtime-speech-to-text-generated

Use the auto-generated ElevenLabsRealtimeClient to stream audio and receive typed ServerEvent events via the discriminated union pattern.
*/

using ElevenLabs.Realtime;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    //// Connect to the ElevenLabs realtime speech-to-text API using the auto-generated WebSocket client.

    [TestMethod]
    [TestCategory("Explicit")]
    public async Task Example_RealtimeSpeechToTextGenerated()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ELEVENLABS_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("ELEVENLABS_API_KEY environment variable is not found.");

        //// Create the generated realtime client and connect with the API key in the URL.
        using var client = new ElevenLabsRealtimeClient();
        await client.ConnectAsync(
            new Uri($"wss://api.elevenlabs.io/v1/speech-to-text/realtime?xi_api_key={apiKey}"));

        client.IsConnected.Should().BeTrue();

        //// Load a WAV file and extract raw PCM16 audio bytes.
        byte[] wavBytes = await File.ReadAllBytesAsync(
            Path.Combine(AppContext.BaseDirectory, "Resources", "hello-in-russian-24k-pcm16.wav"));
        var (pcmSamples, sampleRate, _) = ReadWavPcm16(wavBytes);

        //// Send audio chunks using the typed SendInputAudioChunkAsync method.
        const int samplesPerChunk = 12000;
        for (var offset = 0; offset < pcmSamples.Length; offset += samplesPerChunk)
        {
            var count = Math.Min(samplesPerChunk, pcmSamples.Length - offset);
            var bytes = new byte[count * 2];
            Buffer.BlockCopy(pcmSamples, offset * 2, bytes, 0, bytes.Length);

            var isLastChunk = offset + count >= pcmSamples.Length;
            await client.SendInputAudioChunkAsync(new InputAudioChunkPayload
            {
                AudioBase64 = Convert.ToBase64String(bytes),
                SampleRate = sampleRate,
                Commit = isLastChunk,
            });
        }

        //// Receive typed server events via the discriminated ServerEvent union.
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        var receivedSessionStarted = false;
        string? sessionId = null;
        string? transcript = null;

        await foreach (var serverEvent in client.ReceiveUpdatesAsync(cts.Token))
        {
            if (serverEvent.IsSessionStarted)
            {
                receivedSessionStarted = true;
                sessionId = serverEvent.SessionStarted?.SessionId;
                Console.WriteLine($"Session started: {sessionId}");
            }
            else if (serverEvent.IsPartialTranscript)
            {
                Console.WriteLine($"Partial: {serverEvent.PartialTranscript?.Text}");
            }
            else if (serverEvent.IsCommittedTranscript)
            {
                transcript = serverEvent.CommittedTranscript?.Text;
                Console.WriteLine($"Final: {transcript}");
                break;
            }
            else if (serverEvent.IsCommittedTranscriptWithTimestamps)
            {
                transcript = serverEvent.CommittedTranscriptWithTimestamps?.Text;
                Console.WriteLine($"Final (with timestamps): {transcript}");
                break;
            }
            else if (serverEvent.IsError)
            {
                Assert.Fail($"Error: {serverEvent.Error?.ErrorType} - {serverEvent.Error?.Error}");
            }
        }

        receivedSessionStarted.Should().BeTrue();
        sessionId.Should().NotBeNullOrWhiteSpace();
        transcript.Should().NotBeNullOrWhiteSpace();
    }
}
