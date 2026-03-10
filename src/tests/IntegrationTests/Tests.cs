namespace ElevenLabs.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ElevenLabsClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ELEVENLABS_API_KEY") ??
            throw new AssertInconclusiveException("ELEVENLABS_API_KEY environment variable is not found.");

        var client = new ElevenLabsClient(authorizations: [new EndPointAuthorization
        {
            Type = "ApiKey",
            Name = "xi-api-key",
            Location = "Header",
            Value = apiKey,
        }]);

        return client;
    }
}
