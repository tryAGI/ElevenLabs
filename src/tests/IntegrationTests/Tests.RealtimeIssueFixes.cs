using System.Net;
using System.Net.Http;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SingleUseToken_UsesApiValueForRealtimeScribePath()
    {
        HttpRequestMessage? capturedRequest = null;

        using var httpClient = new HttpClient(new SingleUseTokenRecordingHttpMessageHandler(
            request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("""{"token":"sutkn_test"}""", Encoding.UTF8, "application/json"),
                };
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new SingleUseTokenClient(
            httpClient: httpClient,
            authorizations: CreateApiKeyAuthorizations(),
            options: null,
            disposeHttpClient: false);

        var response = await client.CreateAsync(SingleUseTokenType.RealtimeScribe);

        response.Token.Should().Be("sutkn_test");
        capturedRequest.Should().NotBeNull();
        capturedRequest!.RequestUri.Should().NotBeNull();
        capturedRequest.RequestUri!.AbsolutePath.Should().Be("/v1/single-use-token/realtime_scribe");
    }

    [TestMethod]
    public void RealtimeUri_AddsRepeatedKeytermsQueryParameters()
    {
        using var httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new SpeechToText2Client(
            httpClient: httpClient,
            authorizations: CreateApiKeyAuthorizations(),
            options: null,
            disposeHttpClient: false);

        var method = typeof(SpeechToText2Client)
            .GetMethod("BuildRealtimeUri", BindingFlags.Instance | BindingFlags.NonPublic);
        method.Should().NotBeNull();

        var uri = (Uri)method!.Invoke(client,
        [
            new RealtimeSpeechToTextOptions
            {
                ModelId = "scribe_v1",
                Keyterms = ["Haven", "voice id"],
            },
        ])!;

        uri.Scheme.Should().Be("wss");
        uri.AbsolutePath.Should().Be("/v1/speech-to-text/realtime");
        uri.Query.Should().Contain("keyterms=Haven");
        uri.Query.Should().Contain("keyterms=voice%20id");
        uri.Query.Split("keyterms=", StringSplitOptions.None).Length.Should().Be(3);
    }

    [TestMethod]
    public void RealtimeSpeechToTextSession_ExposesWebSocketCloseDetails()
    {
        var closeStatus = typeof(RealtimeSpeechToTextSession)
            .GetProperty(nameof(RealtimeSpeechToTextSession.CloseStatus));
        var closeStatusDescription = typeof(RealtimeSpeechToTextSession)
            .GetProperty(nameof(RealtimeSpeechToTextSession.CloseStatusDescription));

        closeStatus.Should().NotBeNull();
        closeStatus!.PropertyType.Should().Be(typeof(WebSocketCloseStatus?));
        closeStatusDescription.Should().NotBeNull();
        closeStatusDescription!.PropertyType.Should().Be(typeof(string));
    }

    private sealed class SingleUseTokenRecordingHttpMessageHandler(
        Func<HttpRequestMessage, HttpResponseMessage> responder) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            return Task.FromResult(responder(request));
        }
    }
}
