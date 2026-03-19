namespace ElevenLabs.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ElevenLabsClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ELEVENLABS_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("ELEVENLABS_API_KEY environment variable is not found.");

        var client = new ElevenLabsClient(apiKey);

        return client;
    }
}
