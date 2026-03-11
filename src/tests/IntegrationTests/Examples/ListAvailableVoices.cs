/*
order: 10
title: List Available Voices
slug: list-available-voices

Fetch all voices available to the authenticated account and print each voice name.
*/
namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListAvailableVoices()
    {
        using var client = GetAuthenticatedClient();

        //// Fetch all voices for the authenticated workspace.
        GetVoicesResponseModel response = await client.Voices.GetVoicesAsync();

        //// Print the voice names.
        foreach (var voice in response.Voices)
        {
            Console.WriteLine(voice.Name);
        }

        response.Should().NotBeNull();
        response.Voices.Should().NotBeEmpty();
    }
}
