/*
order: 20
title: Text to Speech
slug: text-to-speech

Convert text to speech with the first available voice and save the generated audio to disk.
*/
namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextToSpeech()
    {
        using var client = GetAuthenticatedClient();

        //// Choose a voice to synthesize with.
        var voices = await client.Voices.GetVoicesAsync();
        var voiceId = voices.Voices[0].VoiceId;

        //// Generate speech audio.
        byte[] audioBytes = await client.TextToSpeech.CreateTextToSpeechByVoiceIdAsync(
            voiceId: voiceId,
            text: "Hello, world! This is a test of the ElevenLabs text-to-speech API.");

        //// Persist the result to a local file.
        await File.WriteAllBytesAsync("output.mp3", audioBytes);
        Console.WriteLine($"Saved {audioBytes.Length} bytes to output.mp3");

        audioBytes.Should().NotBeNull();
        audioBytes.Length.Should().BeGreaterThan(0);
    }
}
