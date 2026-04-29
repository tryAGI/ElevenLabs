namespace ElevenLabs.IntegrationTests;

[TestClass]
public partial class Tests
{
    private const string TestApiKey = "test-api-key";

    private static ElevenLabsClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ELEVENLABS_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("ELEVENLABS_API_KEY environment variable is not found.");

        var client = new ElevenLabsClient(apiKey);

        return client;
    }

    private static List<EndPointAuthorization> CreateApiKeyAuthorizations(string apiKey = TestApiKey) =>
    [
        new EndPointAuthorization
        {
            Type = "ApiKey",
            SchemeId = "ApikeyXiApiKey",
            Location = "Header",
            Name = "xi-api-key",
            Value = apiKey,
        },
    ];

    private static AutoSDKRequestOptions CreateApiKeyHeaderOptions(string apiKey)
    {
        var options = new AutoSDKRequestOptions();
        options.Headers["xi-api-key"] = apiKey;
        return options;
    }
}
