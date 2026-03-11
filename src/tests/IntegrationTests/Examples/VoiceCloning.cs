/*
order: 70
title: Voice Cloning
slug: voice-cloning

Create an instant voice clone from an audio sample, print the new voice ID, and delete the test voice afterwards.
*/
namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_VoiceCloning()
    {
        using var client = GetAuthenticatedClient();

        //// Load a voice sample from disk.
        byte[] voiceSample = await File.ReadAllBytesAsync(
            Path.Combine(AppContext.BaseDirectory, "Resources", "hello-in-russian-24k-pcm16.wav"));

        //// Create the cloned voice.
        AddVoiceIVCResponseModel response = await client.Voices.CreateVoicesAddAsync(
            name: $"Test Cloned Voice {Guid.NewGuid():N}",
            files: [voiceSample],
            description: "A cloned voice from my audio sample",
            removeBackgroundNoise: true);

        Console.WriteLine($"Cloned voice ID: {response.VoiceId}");

        //// Clean up the test voice once the example has succeeded.
        await client.Voices.DeleteVoicesByVoiceIdAsync(response.VoiceId);

        response.Should().NotBeNull();
        response.VoiceId.Should().NotBeNullOrWhiteSpace();
    }
}
