namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Voices()
    {
        using var client = GetAuthenticatedClient();

        GetVoicesResponseModel response = await client.Voices.GetVoicesAsync();
        
        Console.WriteLine("Voices:");
        foreach (var voice in response.Voices)
        {
            Console.WriteLine(voice.Name);
        }
        
        response.Should().NotBeNull();
        response.Voices.Should().NotBeEmpty();
    }
}
