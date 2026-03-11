namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Voices()
    {
        using var client = GetAuthenticatedClient();

        //// List all available voices and print their names.
        GetVoicesResponseModel response = await client.Voices.GetVoicesAsync();

        foreach (var voice in response.Voices)
        {
            Console.WriteLine(voice.Name);
        }

        response.Should().NotBeNull();
        response.Voices.Should().NotBeEmpty();
    }

    [TestMethod]
    public async Task TextToSpeech()
    {
        using var client = GetAuthenticatedClient();

        //// Convert text to speech using a specific voice and save the audio to a file.
        var voices = await client.Voices.GetVoicesAsync();
        var voiceId = voices.Voices[0].VoiceId;

        byte[] audioBytes = await client.TextToSpeech.CreateTextToSpeechByVoiceIdAsync(
            voiceId: voiceId,
            text: "Hello, world! This is a test of the ElevenLabs text-to-speech API.");

        audioBytes.Should().NotBeNull();
        audioBytes.Length.Should().BeGreaterThan(0);

        Console.WriteLine($"Generated {audioBytes.Length} bytes of audio.");
    }

    [TestMethod]
    public async Task SoundGeneration()
    {
        using var client = GetAuthenticatedClient();

        //// Generate a sound effect from a text description.
        byte[] soundBytes = await client.SoundGeneration.CreateSoundGenerationAsync(
            text: "A gentle ocean wave crashing on a sandy beach",
            durationSeconds: 3.0);

        soundBytes.Should().NotBeNull();
        soundBytes.Length.Should().BeGreaterThan(0);

        Console.WriteLine($"Generated {soundBytes.Length} bytes of sound.");
    }
}
