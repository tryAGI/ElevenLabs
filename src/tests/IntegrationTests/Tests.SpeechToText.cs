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

        var client = new SpeechToText2Client(httpClient, disposeHttpClient: false);

        var audioBytes = Encoding.UTF8.GetBytes("fake-audio");
        // Ignore deserialization result — we're testing request serialization
        try
        {
            await client.ConvertAsync(
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
    public void SpeechToText_AnyOfDiscriminatesCorrectly_WithSourceGeneratedContext()
    {
        var json = """{"language_code":"eng","language_probability":0.98,"text":"Hello","words":[]}""";

        var result = System.Text.Json.JsonSerializer.Deserialize<
            AnyOf<SpeechToTextChunkResponseModel, MultichannelSpeechToTextResponseModel, SpeechToTextWebhookResponseModel>>(
            json, SourceGenerationContext.Default.Options);

        result.IsValue1.Should().BeTrue(
            $"IsValue1={result.IsValue1}, IsValue2={result.IsValue2}, IsValue3={result.IsValue3}");
        result.Value1!.Text.Should().Be("Hello");
    }

    [TestMethod]
    public void SpeechToText_WithSingleChannelResponse_ParsesTranscript()
    {
        var json = """
        {
            "language_code": "eng",
            "language_probability": 0.98,
            "text": "Hello world",
            "words": [
                {"text": "Hello", "start": 0.0, "end": 0.5, "type": "word", "logprob": -0.1},
                {"text": "world", "start": 0.6, "end": 1.0, "type": "word", "logprob": -0.2}
            ]
        }
        """;

        var result = AnyOf<SpeechToTextChunkResponseModel, MultichannelSpeechToTextResponseModel, SpeechToTextWebhookResponseModel>
            .FromJson(json, SourceGenerationContext.Default);

        result.Should().NotBeNull();
        result!.Value.IsValue1.Should().BeTrue($"Expected Value1 (single-channel). IsValue1={result.Value.IsValue1}, IsValue2={result.Value.IsValue2}, IsValue3={result.Value.IsValue3}");
        result.Value.Value1!.Text.Should().Be("Hello world");
        result.Value.Value1.Words.Should().HaveCount(2);
    }

    [TestMethod]
    public void SpeechToText_WithMultiChannelResponse_ParsesTranscripts()
    {
        var json = """
        {
            "transcripts": [
                {
                    "text": "Channel 1 text",
                    "words": [],
                    "channel": 0,
                    "language_code": "eng",
                    "language_probability": 0.95
                }
            ]
        }
        """;

        var result = AnyOf<SpeechToTextChunkResponseModel, MultichannelSpeechToTextResponseModel, SpeechToTextWebhookResponseModel>
            .FromJson(json, SourceGenerationContext.Default);

        result.Should().NotBeNull();
        result!.Value.IsValue2.Should().BeTrue($"Expected Value2 (multichannel). IsValue1={result.Value.IsValue1}, IsValue2={result.Value.IsValue2}, IsValue3={result.Value.IsValue3}");
        result.Value.Value2!.Transcripts.Should().HaveCount(1);
        result.Value.Value2.Transcripts[0].Text.Should().Be("Channel 1 text");
    }

    [TestMethod]
    public void SpeechToText_WithWebhookResponse_ParsesWebhookPayload()
    {
        var json = """
        {
            "message": "Transcription queued",
            "request_id": "abc-123"
        }
        """;

        var result = AnyOf<SpeechToTextChunkResponseModel, MultichannelSpeechToTextResponseModel, SpeechToTextWebhookResponseModel>
            .FromJson(json, SourceGenerationContext.Default);

        result.Should().NotBeNull();
        result!.Value.IsValue3.Should().BeTrue($"Expected Value3 (webhook). IsValue1={result.Value.IsValue1}, IsValue2={result.Value.IsValue2}, IsValue3={result.Value.IsValue3}");
        result.Value.Value3!.Message.Should().Be("Transcription queued");
        result.Value.Value3.RequestId.Should().Be("abc-123");
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

        var client = new SpeechToText2Client(httpClient, disposeHttpClient: false);

        try
        {
            await client.ConvertAsync(
                modelId: BodySpeechToTextV1SpeechToTextPostModelId.ScribeV1,
                sourceUrl: "https://example.com/audio.wav",
                xiApiKey: "test-api-key");
        }
        catch (InvalidOperationException)
        {
            // AnyOf deserialization may fail for stubbed responses
        }

        capturedApiKey.Should().Be("test-api-key");
    }

    [TestMethod]
    public async Task SpeechToText_WithRealApi_TranscribesAudioFile()
    {
        using var client = GetAuthenticatedClient();

        byte[] audioFile = await File.ReadAllBytesAsync(
            Path.Combine(AppContext.BaseDirectory, "Resources", "hello-in-russian-24k-pcm16.wav"));

        var result = await client.SpeechToText2.ConvertAsync(
            modelId: BodySpeechToTextV1SpeechToTextPostModelId.ScribeV2,
            file: audioFile,
            filename: "hello-in-russian-24k-pcm16.wav",
            languageCode: "ru",
            timestampsGranularity: BodySpeechToTextV1SpeechToTextPostTimestampsGranularity.Word);

        result.IsValue1.Should().BeTrue(
            $"Expected single-channel response. IsValue1={result.IsValue1}, IsValue2={result.IsValue2}, IsValue3={result.IsValue3}");

        var transcript = result.Value1!;
        transcript.Text.Should().NotBeNullOrWhiteSpace();
        transcript.LanguageCode.Should().Be("rus");
        transcript.Words.Should().NotBeEmpty();
        transcript.Words[0].Type.Should().Be(SpeechToTextWordResponseModelType.Word);
        transcript.Words[0].Start.Should().NotBeNull();
        transcript.Words[0].End.Should().NotBeNull();
    }
}
