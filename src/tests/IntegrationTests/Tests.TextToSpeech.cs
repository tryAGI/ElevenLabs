using System.Net;
using System.Text;
using System.Text.Json;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TextToSpeech_SerializesAllSupportedParameters()
    {
        var responseBytes = Encoding.UTF8.GetBytes("fake-audio");
        Uri? capturedUri = null;
        string? capturedPayload = null;
        string? capturedApiKey = null;

        using var httpClient = new HttpClient(new StubHttpMessageHandler(
            request =>
            {
                capturedUri = request.RequestUri;
                request.Headers.TryGetValues("xi-api-key", out var apiKeyValues);
                capturedApiKey = apiKeyValues?.SingleOrDefault();
                capturedPayload = request.Content!.ReadAsStringAsync().GetAwaiter().GetResult();
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent(responseBytes),
                };
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new TextToSpeechClient(
            httpClient: httpClient,
            authorizations: CreateApiKeyAuthorizations("client-key"),
            options: null,
            disposeHttpClient: false);

        var result = await client.ConvertAsync(
            voiceId: "voice_123",
            request: new BodyTextToSpeechFull
            {
                Text = "The first move is what sets everything in motion.",
                ModelId = "eleven_multilingual_v2",
                LanguageCode = "en",
                VoiceSettings = new VoiceSettingsResponseModel
                {
                    Stability = 0.4,
                    SimilarityBoost = 0.8,
                    Style = 0.5,
                    UseSpeakerBoost = true,
                    Speed = 1.1,
                },
                PronunciationDictionaryLocators =
                [
                    new PronunciationDictionaryVersionLocatorRequestModel
                    {
                        PronunciationDictionaryId = "dict_1",
                        VersionId = "ver_1",
                    },
                    new PronunciationDictionaryVersionLocatorRequestModel
                    {
                        PronunciationDictionaryId = "dict_2",
                        VersionId = "",
                    },
                ],
                Seed = 42,
                PreviousText = "Previous sentence.",
                NextText = "Next sentence.",
                PreviousRequestIds = ["req_prev_1", "req_prev_2"],
                NextRequestIds = ["req_next_1"],
                ApplyTextNormalization = BodyTextToSpeechFullApplyTextNormalization.On,
                ApplyLanguageTextNormalization = true,
            },
            enableLogging: false,
            optimizeStreamingLatency: 4,
            outputFormat: TextToSpeechFullOutputFormat.Pcm24000,
            requestOptions: CreateApiKeyHeaderOptions("override-key"));

        result.Should().BeEquivalentTo(responseBytes, options => options.WithStrictOrdering());

        capturedUri.Should().NotBeNull();
        capturedUri!.AbsolutePath.Should().Be("/v1/text-to-speech/voice_123");
        capturedApiKey.Should().Be("override-key");
        capturedPayload.Should().NotBeNull();

        using var payloadJson = JsonDocument.Parse(capturedPayload!);
        var root = payloadJson.RootElement;
        root.GetProperty("text").GetString().Should().Be("The first move is what sets everything in motion.");
        root.GetProperty("model_id").GetString().Should().Be("eleven_multilingual_v2");
        root.GetProperty("language_code").GetString().Should().Be("en");
        root.GetProperty("seed").GetInt32().Should().Be(42);
        root.GetProperty("previous_text").GetString().Should().Be("Previous sentence.");
        root.GetProperty("next_text").GetString().Should().Be("Next sentence.");
        root.GetProperty("apply_text_normalization").GetString().Should().Be("on");
        root.GetProperty("apply_language_text_normalization").GetBoolean().Should().BeTrue();

        var voiceSettings = root.GetProperty("voice_settings");
        voiceSettings.GetProperty("stability").GetDouble().Should().BeApproximately(0.4, 1e-9);
        voiceSettings.GetProperty("similarity_boost").GetDouble().Should().BeApproximately(0.8, 1e-9);
        voiceSettings.GetProperty("style").GetDouble().Should().BeApproximately(0.5, 1e-9);
        voiceSettings.GetProperty("use_speaker_boost").GetBoolean().Should().BeTrue();
        voiceSettings.GetProperty("speed").GetDouble().Should().BeApproximately(1.1, 1e-9);

        var locators = root.GetProperty("pronunciation_dictionary_locators");
        locators.GetArrayLength().Should().Be(2);
        locators[0].GetProperty("pronunciation_dictionary_id").GetString().Should().Be("dict_1");
        locators[0].GetProperty("version_id").GetString().Should().Be("ver_1");

        var previousRequestIds = root.GetProperty("previous_request_ids");
        previousRequestIds.GetArrayLength().Should().Be(2);
        previousRequestIds[0].GetString().Should().Be("req_prev_1");

        var nextRequestIds = root.GetProperty("next_request_ids");
        nextRequestIds.GetArrayLength().Should().Be(1);
        nextRequestIds[0].GetString().Should().Be("req_next_1");
    }

    [TestMethod]
    public async Task TextToSpeech_WithPerRequestApiKeyOverride_UsesOverrideKey()
    {
        string? capturedApiKey = null;

        using var httpClient = new HttpClient(new StubHttpMessageHandler(
            request =>
            {
                request.Headers.TryGetValues("xi-api-key", out var apiKeyValues);
                capturedApiKey = apiKeyValues?.SingleOrDefault();
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent([1, 2, 3]),
                };
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new TextToSpeechClient(
            httpClient: httpClient,
            authorizations: CreateApiKeyAuthorizations("client-key"),
            options: null,
            disposeHttpClient: false);

        await client.ConvertAsync(
            voiceId: "voice_123",
            text: "hello",
            requestOptions: CreateApiKeyHeaderOptions("override-key"));

        capturedApiKey.Should().Be("override-key");
    }

    [TestMethod]
    public async Task TextToSpeech_WithErrorResponse_ThrowsApiException()
    {
        using var httpClient = new HttpClient(new StubHttpMessageHandler(
            _ => new HttpResponseMessage(HttpStatusCode.UnprocessableEntity)
            {
                Content = new StringContent(
                    """{"detail":{"status":"unprocessable_entity","message":"bad request"}}""",
                    Encoding.UTF8,
                    "application/json"),
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new TextToSpeechClient(
            httpClient: httpClient,
            authorizations: CreateApiKeyAuthorizations(),
            options: null,
            disposeHttpClient: false);

        var act = () => client.ConvertAsync(
            voiceId: "voice_123",
            text: "hello");

        await act.Should().ThrowAsync<ApiException>();
    }
}
