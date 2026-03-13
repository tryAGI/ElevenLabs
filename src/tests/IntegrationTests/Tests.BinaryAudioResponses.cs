using System.Net;
using System.Net.Http;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ConversationAudio_ReturnsByteArray_ForBinaryResponse()
    {
        HttpRequestMessage? capturedRequest = null;

        using var httpClient = new HttpClient(new RecordingHttpMessageHandler(
            request =>
            {
                capturedRequest = request;

                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent([1, 2, 3, 4]),
                };
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new AgentsPlatformClient(httpClient, disposeHttpClient: false);

        byte[] audio = await client.GetConvaiConversationsByConversationIdAudioAsync("conversation-id");

        audio.Should().BeEquivalentTo([1, 2, 3, 4], options => options.WithStrictOrdering());
        capturedRequest.Should().NotBeNull();
        capturedRequest!.Method.Should().Be(HttpMethod.Get);
        capturedRequest.RequestUri.Should().NotBeNull();
        capturedRequest.RequestUri!.PathAndQuery.Should().Be("/v1/convai/conversations/conversation-id/audio");
    }

    [TestMethod]
    public void BinaryAudioEndpoints_ExposeByteArrayReturnTypes()
    {
        AssertBinaryReturnType(
            typeof(IAgentsPlatformClient),
            nameof(IAgentsPlatformClient.GetConvaiConversationsByConversationIdAudioAsync),
            typeof(string),
            typeof(string),
            typeof(CancellationToken));

        AssertBinaryReturnType(
            typeof(IAudioIsolationClient),
            nameof(IAudioIsolationClient.CreateAudioIsolationAsync),
            typeof(BodyAudioIsolationV1AudioIsolationPost),
            typeof(string),
            typeof(CancellationToken));

        AssertBinaryReturnType(
            typeof(IAudioIsolationClient),
            nameof(IAudioIsolationClient.CreateAudioIsolationStreamAsync),
            typeof(BodyAudioIsolationStreamV1AudioIsolationStreamPost),
            typeof(string),
            typeof(CancellationToken));

        AssertBinaryReturnType(
            typeof(ISamplesClient),
            nameof(ISamplesClient.GetVoicesByVoiceIdSamplesBySampleIdAudioAsync),
            typeof(string),
            typeof(string),
            typeof(string),
            typeof(CancellationToken));
    }

    private static void AssertBinaryReturnType(
        Type clientType,
        string methodName,
        params Type[] parameterTypes)
    {
        var method = clientType.GetMethod(methodName, parameterTypes);

        method.Should().NotBeNull($"{clientType.Name}.{methodName} should exist");
        method!.ReturnType.Should().Be(typeof(Task<byte[]>));
    }

    private sealed class RecordingHttpMessageHandler(Func<HttpRequestMessage, HttpResponseMessage> responder) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            return Task.FromResult(responder(request));
        }
    }
}
