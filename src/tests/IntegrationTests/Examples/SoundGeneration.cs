/*
order: 50
title: Sound Generation
slug: sound-generation

Generate a short sound effect from a text prompt and save the returned audio bytes.
*/
namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SoundGeneration()
    {
        using var client = GetAuthenticatedClient();

        //// Generate a sound effect from a text description.
        byte[] soundBytes = await client.SoundGeneration.CreateSoundGenerationAsync(
            text: "A gentle ocean wave crashing on a sandy beach",
            durationSeconds: 3.0);

        //// Persist the result to a local file.
        await File.WriteAllBytesAsync("ocean-wave.mp3", soundBytes);
        Console.WriteLine($"Saved {soundBytes.Length} bytes to ocean-wave.mp3");

        soundBytes.Should().NotBeNull();
        soundBytes.Length.Should().BeGreaterThan(0);
    }
}
