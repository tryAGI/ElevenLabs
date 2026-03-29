using System.Net;
using System.Net.Http;
using System.IO;
using System.Text;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TextToSpeech_LastRequestId_IsCaptured_ForBinaryResponses()
    {
        using var httpClient = new HttpClient(new StubHttpMessageHandler(
            static _ =>
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent([1, 2, 3, 4]),
                };
                response.Headers.Add("request-id", "req-binary-123");
                return response;
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new TextToSpeechClient(httpClient, disposeHttpClient: false);

        byte[] audio = await client.ConvertAsync(
            voiceId: "voice-id",
            text: "hello");

        audio.Should().BeEquivalentTo([1, 2, 3, 4], options => options.WithStrictOrdering());
        client.LastRequestId.Should().Be("req-binary-123");
        client.GetLastResponseHeader("request-id").Should().Be("req-binary-123");
        client.GetLastResponseHeaderValues("request-id").Should().BeEquivalentTo(["req-binary-123"]);
        new TextToSpeechClient(httpClient, disposeHttpClient: false).LastRequestId.Should().Be("req-binary-123");
    }

    [TestMethod]
    public async Task TextToSpeech_LastRequestId_IsCaptured_ForJsonResponses()
    {
        using var httpClient = new HttpClient(new StubHttpMessageHandler(
            static _ =>
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(
                        "{\"audio_base64\":\"AQID\",\"alignment\":null,\"normalized_alignment\":null}",
                        Encoding.UTF8,
                        "application/json"),
                };
                response.Headers.Add("request-id", "req-json-456");
                return response;
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new TextToSpeechClient(httpClient, disposeHttpClient: false);

        AudioWithTimestampsResponseModel response = await client.ConvertWithTimestampsAsync(
            voiceId: "voice-id",
            text: "hello");

        response.AudioBase64.Should().Be("AQID");
        client.LastRequestId.Should().Be("req-json-456");
        client.GetLastResponseHeader("request-id").Should().Be("req-json-456");
    }

    [TestMethod]
    public async Task TextToSpeech_LastRequestId_IsCaptured_ForStreamBinaryResponses()
    {
        using var httpClient = new HttpClient(new StubHttpMessageHandler(
            static _ =>
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent([5, 6, 7, 8]),
                };
                response.Headers.Add("request-id", "req-stream-binary-789");
                return response;
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new TextToSpeechClient(httpClient, disposeHttpClient: false);

        using Stream audio = await client.StreamAsync(
            voiceId: "voice-id",
            text: "hello");
        using var buffer = new MemoryStream();
        await audio.CopyToAsync(buffer);

        buffer.ToArray().Should().BeEquivalentTo([5, 6, 7, 8], options => options.WithStrictOrdering());
        client.LastRequestId.Should().Be("req-stream-binary-789");
    }

    [TestMethod]
    public async Task TextToSpeech_LastRequestId_IsCaptured_ForStreamJsonResponses()
    {
        using var httpClient = new HttpClient(new StubHttpMessageHandler(
            static _ =>
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(
                        "{\"audio_base64\":\"BQYH\",\"alignment\":null,\"normalized_alignment\":null}",
                        Encoding.UTF8,
                        "application/json"),
                };
                response.Headers.Add("request-id", "req-stream-json-012");
                return response;
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new TextToSpeechClient(httpClient, disposeHttpClient: false);

        StreamingAudioChunkWithTimestampsResponseModel? response = null;

        await foreach (var chunk in client.StreamWithTimestampsAsync(
                           voiceId: "voice-id",
                           text: "hello"))
        {
            response = chunk;
            break;
        }

        response.Should().NotBeNull();
        response!.AudioBase64.Should().Be("BQYH");
        client.LastRequestId.Should().Be("req-stream-json-012");
    }

    private sealed class StubHttpMessageHandler(Func<HttpRequestMessage, HttpResponseMessage> responder) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            return Task.FromResult(responder(request));
        }
    }
}
