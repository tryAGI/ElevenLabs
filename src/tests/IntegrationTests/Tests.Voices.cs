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
    
    [TestMethod]
    public async Task TextToSpeech()
    {
        using var client = GetAuthenticatedClient();
        
        GetVoicesResponseModel voices = await client.Voices.GetVoicesAsync();

        var randomIndex = new Random().Next(0, voices.Voices.Count);
        var bytes = await client.TextToSpeech.CreateTextToSpeechByVoiceIdAsync(
            voiceId: voices.Voices[randomIndex].VoiceId,
            text: "Hello, world!");
        
        bytes.Should().NotBeNull();

        FileInfo fileInfo = new($"{Guid.NewGuid()}.mp3");
        
        await File.WriteAllBytesAsync(fileInfo.FullName, bytes);
        
        Console.WriteLine($"Audio available at:\n{new Uri(fileInfo.FullName).AbsoluteUri}");
    }
}
