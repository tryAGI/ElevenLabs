/*
order: 85
title: Realtime STT (Generated Client)
slug: realtime-speech-to-text-generated

Use the auto-generated ElevenLabsRealtimeClient to stream audio and receive typed ServerEvent events via the discriminated union pattern.
*/

using System.Text;
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
        var (pcmSamples, sampleRate, _) = ReadWavPcm16Generated(wavBytes);

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
        string? transcript = null;

        await foreach (var serverEvent in client.ReceiveUpdatesAsync(cts.Token))
        {
            if (serverEvent.IsSessionStarted)
            {
                receivedSessionStarted = true;
                Console.WriteLine($"Session started: {serverEvent.SessionStarted?.SessionId}");
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
        transcript.Should().NotBeNullOrWhiteSpace();

        static (short[] samples, int sampleRate, int channels) ReadWavPcm16Generated(ReadOnlySpan<byte> data)
        {
            using var ms = new MemoryStream(data.ToArray(), writable: false);
            using var br = new BinaryReader(ms, Encoding.UTF8, leaveOpen: true);

            var riff = new string(br.ReadChars(4));
            if (riff != "RIFF") throw new InvalidDataException("Not RIFF");
            br.ReadInt32();
            var wave = new string(br.ReadChars(4));
            if (wave != "WAVE") throw new InvalidDataException("Not WAVE");

            ushort audioFormat = 1, localChannels = 1, bitsPerSample = 16;
            int localSampleRate = 16000;

            while (ms.Position < ms.Length)
            {
                if (ms.Length - ms.Position < 8) break;
                var id = new string(br.ReadChars(4));
                int size = br.ReadInt32();

                if (id == "fmt ")
                {
                    if (size < 16) throw new InvalidDataException("Bad fmt chunk");
                    audioFormat = br.ReadUInt16();
                    localChannels = br.ReadUInt16();
                    localSampleRate = br.ReadInt32();
                    br.ReadInt32();
                    br.ReadUInt16();
                    bitsPerSample = br.ReadUInt16();
                    var remaining = size - 16;
                    if (remaining > 0) br.ReadBytes(remaining);
                }
                else if (id == "data")
                {
                    if (audioFormat != 1 || bitsPerSample != 16) throw new InvalidDataException("Expected PCM16");
                    var dataSize = size == 0 ? (int)(ms.Length - ms.Position) : size;
                    var dataBytes = br.ReadBytes(dataSize);
                    var samples = new short[dataBytes.Length / 2];
                    Buffer.BlockCopy(dataBytes, 0, samples, 0, dataBytes.Length);
                    return (samples, localSampleRate, localChannels);
                }
                else if (size > 0) br.ReadBytes(size);
            }
            throw new InvalidDataException("WAV data chunk not found");
        }
    }
}
