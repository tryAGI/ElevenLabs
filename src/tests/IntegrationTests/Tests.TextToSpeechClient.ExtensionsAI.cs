#nullable enable
#pragma warning disable MEAI001

using Microsoft.Extensions.AI;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void TextToSpeechClient_GetService_Metadata()
    {
        using var api = new ElevenLabsClient(TestApiKey);
        Microsoft.Extensions.AI.ITextToSpeechClient ttsClient = api;

        var metadata = ttsClient.GetService<TextToSpeechClientMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be("elevenlabs");
        metadata.DefaultModelId.Should().Be("eleven_flash_v2_5");
        metadata.ProviderUri.Should().NotBeNull();
        ttsClient.GetService<ElevenLabsClient>().Should().BeSameAs(api);
    }

    [TestMethod]
    public async Task TextToSpeechClient_RequiresVoiceId()
    {
        using var api = new ElevenLabsClient(TestApiKey);
        Microsoft.Extensions.AI.ITextToSpeechClient ttsClient = api;

        var act = () => ttsClient.GetAudioAsync("Hello from ElevenLabs.").WaitAsync(TimeSpan.FromSeconds(5));

        await Assert.ThrowsExactlyAsync<ArgumentException>(act);
    }

    [TestMethod]
    public async Task TextToSpeechClient_MapsOptionsToRequest()
    {
        var handler = new StaticResponseHandler(System.Net.HttpStatusCode.BadRequest, "{}");
        using var api = new ElevenLabsClient(
            TestApiKey,
            new HttpClient(handler)
            {
                BaseAddress = new Uri(ElevenLabsClient.DefaultBaseUrl),
            });

        Microsoft.Extensions.AI.ITextToSpeechClient ttsClient = api;
        BodyTextToSpeechFull? capturedRequest = null;

        var options = new TextToSpeechOptions
        {
            ModelId = "eleven_flash_v2_5",
            VoiceId = "voice-id",
            AudioFormat = "wav",
            Language = "en-US",
            Speed = 1.08f,
            AdditionalProperties = new()
            {
                [ElevenLabsTextToSpeechPropertyNames.Stability] = 0.4d,
                [ElevenLabsTextToSpeechPropertyNames.SimilarityBoost] = 0.8d,
                [ElevenLabsTextToSpeechPropertyNames.Style] = 0.1d,
                [ElevenLabsTextToSpeechPropertyNames.UseSpeakerBoost] = false,
                [ElevenLabsTextToSpeechPropertyNames.OptimizeStreamingLatency] = 3,
                [ElevenLabsTextToSpeechPropertyNames.ApplyTextNormalization] = "off",
            },
            RawRepresentationFactory = _ =>
            {
                capturedRequest = new BodyTextToSpeechFull
                    {
                        Text = string.Empty,
                    };

                return capturedRequest;
            },
        };

        await Assert.ThrowsExactlyAsync<ApiException>(() => ttsClient.GetAudioAsync("Hello from ElevenLabs.", options));

        capturedRequest.Should().NotBeNull();
        capturedRequest!.Text.Should().Be("Hello from ElevenLabs.");
        capturedRequest.ModelId.Should().Be("eleven_flash_v2_5");
        capturedRequest.LanguageCode.Should().Be("en");
        capturedRequest.ApplyTextNormalization.Should().Be(BodyTextToSpeechFullApplyTextNormalization.Off);
        capturedRequest.VoiceSettings.Should().NotBeNull();
        capturedRequest.VoiceSettings!.Speed.Should().BeApproximately(1.08d, 0.00001d);
        capturedRequest.VoiceSettings.Stability.Should().Be(0.4d);
        capturedRequest.VoiceSettings.SimilarityBoost.Should().Be(0.8d);
        capturedRequest.VoiceSettings.Style.Should().Be(0.1d);
        capturedRequest.VoiceSettings.UseSpeakerBoost.Should().BeFalse();

        handler.LastRequest.Should().NotBeNull();
        handler.LastRequest!.RequestUri!.ToString().Should().Contain("/v1/text-to-speech/voice-id");
        handler.LastRequest.RequestUri!.Query.Should().Contain("output_format=wav_44100");
        handler.LastRequest.RequestUri.Query.Should().Contain("optimize_streaming_latency=3");
    }

    private sealed class StaticResponseHandler(
        System.Net.HttpStatusCode statusCode,
        string responseBody) : HttpMessageHandler
    {
        public HttpRequestMessage? LastRequest { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            LastRequest = request;
            return Task.FromResult(new HttpResponseMessage(statusCode)
            {
                RequestMessage = request,
                Content = new StringContent(responseBody),
            });
        }
    }
}
