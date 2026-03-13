/*
order: 30
title: Streaming Text to Speech
slug: streaming-text-to-speech

Request a streaming text-to-speech response for low-latency playback and save the returned audio stream.
*/
namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_StreamingTextToSpeech()
    {
        using var client = GetAuthenticatedClient();

        //// Choose a voice to synthesize with.
        var voices = await client.Voices.GetVoicesAsync();
        var voiceId = voices.Voices[0].VoiceId;

        //// Request streaming speech audio.
        using var streamedAudio = await client.TextToSpeech.CreateTextToSpeechByVoiceIdStreamAsync(
            voiceId: voiceId,
            text: "This audio is streamed for low-latency playback.",
            modelId: "eleven_multilingual_v2",
            outputFormat: TextToSpeechStreamOutputFormat.Mp32205032);

        //// Persist the result to a local file.
        await using var output = File.Create("streamed-output.mp3");
        await streamedAudio.CopyToAsync(output);
        Console.WriteLine($"Saved {output.Length} bytes to streamed-output.mp3");

        output.Length.Should().BeGreaterThan(0);
    }
}
