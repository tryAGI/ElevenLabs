/*
order: 55
title: Eleven Music
slug: eleven-music

Create a short composition plan with Eleven Music, generate a minimum-length instrumental track from it, and save the returned audio bytes.
*/
namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ElevenMusic()
    {
        using var client = GetAuthenticatedClient();

        const string prompt =
            "Create a short upbeat instrumental synthwave loop with bright arpeggios and a steady drum groove.";

        //// Create a structured composition plan from a natural-language prompt.
        MusicPrompt compositionPlan = (await client.MusicGeneration.CreateAsync(
            prompt: prompt,
            musicLengthMs: 3000)).PickValue1();

        Console.WriteLine($"Generated {compositionPlan.Sections.Count} music section(s).");

        //// Generate music from the composition plan.
        byte[] musicBytes = await client.Music.ComposeAsync(
            outputFormat: GenerateOutputFormat.Mp32205032,
            compositionPlan: compositionPlan);

        //// Persist the result to a local file.
        await File.WriteAllBytesAsync("eleven-music.mp3", musicBytes);
        Console.WriteLine($"Saved {musicBytes.Length} bytes to eleven-music.mp3");

        compositionPlan.Sections.Should().NotBeEmpty();
        musicBytes.Should().NotBeNull();
        musicBytes.Length.Should().BeGreaterThan(0);
    }
}
