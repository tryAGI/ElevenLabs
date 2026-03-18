using System.Net;
using System.Text;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SpeechToText_SerializesMultipartPayload_WithFileUpload()
    {
        Uri? capturedUri = null;
        string? capturedPayload = null;

        using var httpClient = new HttpClient(new StubHttpMessageHandler(
            request =>
            {
                capturedUri = request.RequestUri;
                capturedPayload = request.Content!.ReadAsStringAsync().GetAwaiter().GetResult();
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(
                        """{"language_code":"eng","language_probability":0.99,"text":"ok","words":[]}""",
                        Encoding.UTF8,
                        "application/json"),
                };
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new SpeechToTextClient(httpClient, disposeHttpClient: false);

        var audioBytes = Encoding.UTF8.GetBytes("fake-audio");
        // Ignore deserialization result — we're testing request serialization
        try
        {
            await client.CreateSpeechToTextAsync(
                modelId: BodySpeechToTextV1SpeechToTextPostModelId.ScribeV2,
                file: audioBytes,
                filename: "sample.wav",
                languageCode: "eng",
                tagAudioEvents: true,
                numSpeakers: 2,
                timestampsGranularity: BodySpeechToTextV1SpeechToTextPostTimestampsGranularity.Character,
                diarize: true,
                enableLogging: false);
        }
        catch (InvalidOperationException)
        {
            // AnyOf deserialization may fail for stubbed responses — expected
        }

        capturedUri.Should().NotBeNull();
        capturedUri!.AbsolutePath.Should().Be("/v1/speech-to-text");
        capturedPayload.Should().NotBeNull();

        var payload = capturedPayload!;
        payload.Should().Contain("scribe_v2");
        payload.Should().Contain("eng");
        payload.Should().Contain("sample.wav");
        payload.Should().Contain("fake-audio");
    }

    [TestMethod]
    public async Task SpeechToText_SendsApiKeyHeader()
    {
        string? capturedApiKey = null;

        using var httpClient = new HttpClient(new StubHttpMessageHandler(
            request =>
            {
                request.Headers.TryGetValues("xi-api-key", out var apiKeyValues);
                capturedApiKey = apiKeyValues?.SingleOrDefault();
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(
                        """{"language_code":"eng","language_probability":0.99,"text":"ok","words":[]}""",
                        Encoding.UTF8,
                        "application/json"),
                };
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new SpeechToTextClient(httpClient, disposeHttpClient: false);

        try
        {
            await client.CreateSpeechToTextAsync(
                modelId: BodySpeechToTextV1SpeechToTextPostModelId.ScribeV1,
                cloudStorageUrl: "https://example.com/audio.wav",
                xiApiKey: "test-api-key");
        }
        catch (InvalidOperationException)
        {
            // AnyOf deserialization may fail for stubbed responses
        }

        capturedApiKey.Should().Be("test-api-key");
    }
}
