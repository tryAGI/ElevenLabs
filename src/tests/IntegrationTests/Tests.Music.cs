using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    private const string MusicPromptText =
        "Create a short upbeat instrumental synthwave loop with bright arpeggios and a steady drum groove.";

    private const string MusicPromptJson = """
        {
          "positive_global_styles": ["synthwave", "upbeat", "instrumental"],
          "negative_global_styles": ["vocals", "distorted", "slow"],
          "sections": [
            {
              "section_name": "Loop",
              "positive_local_styles": ["bright arpeggios", "steady drums"],
              "negative_local_styles": ["vocals"],
              "duration_ms": 3000,
              "lines": []
            }
          ]
        }
        """;

    [TestMethod]
    public void ElevenMusicClients_ExposeCurrentPublicMusicApiSurface()
    {
        AssertReturnType(
            typeof(IMusicGenerationClient),
            nameof(IMusicGenerationClient.CreateAsync),
            typeof(Task<AnyOf<MusicPrompt, CompositionPlan>>),
            typeof(BodyGenerateCompositionPlanV1MusicPlanPost),
            typeof(AutoSDKRequestOptions),
            typeof(CancellationToken));

        AssertReturnType(
            typeof(IMusicClient),
            nameof(IMusicClient.ComposeAsync),
            typeof(Task<byte[]>),
            typeof(BodyComposeMusicV1MusicPost),
            typeof(GenerateOutputFormat?),
            typeof(AutoSDKRequestOptions),
            typeof(CancellationToken));

        AssertReturnType(
            typeof(IMusicClient),
            nameof(IMusicClient.StreamAsync),
            typeof(Task<Stream>),
            typeof(BodyStreamComposedMusicV1MusicStreamPost),
            typeof(StreamComposeOutputFormat?),
            typeof(AutoSDKRequestOptions),
            typeof(CancellationToken));

        AssertReturnType(
            typeof(IMusicClient),
            nameof(IMusicClient.ComposeDetailedAsync),
            typeof(Task<byte[]>),
            typeof(BodyComposeMusicWithADetailedResponseV1MusicDetailedPost),
            typeof(ComposeDetailedOutputFormat?),
            typeof(AutoSDKRequestOptions),
            typeof(CancellationToken));

        AssertReturnType(
            typeof(IMusicClient),
            nameof(IMusicClient.VideoToMusicAsync),
            typeof(Task<byte[]>),
            typeof(BodyVideoToMusicV1MusicVideoToMusicPost),
            typeof(AllowedOutputFormats?),
            typeof(AutoSDKRequestOptions),
            typeof(CancellationToken));

        AssertReturnType(
            typeof(IMusicClient),
            nameof(IMusicClient.UploadAsync),
            typeof(Task<MusicUploadResponse>),
            typeof(BodyUploadMusicV1MusicUploadPost),
            typeof(AutoSDKRequestOptions),
            typeof(CancellationToken));

        AssertReturnType(
            typeof(IMusicClient),
            nameof(IMusicClient.SeparateStemsAsync),
            typeof(Task<byte[]>),
            typeof(BodyStemSeparationV1MusicStemSeparationPost),
            typeof(AllowedOutputFormats?),
            typeof(AutoSDKRequestOptions),
            typeof(CancellationToken));
    }

    [TestMethod]
    public async Task ElevenMusicEndpoints_SendExpectedRequests()
    {
        var expectedRequests = new Queue<MusicEndpointExpectation>(
        [
            new(
                "/v1/music/plan",
                "application/json",
                body => body.Should().Contain("\"prompt\"").And.Contain(MusicPromptText),
                _ => JsonResponse(MusicPromptJson)),
            new(
                "/v1/music?output_format=mp3_22050_32",
                "application/json",
                body => body.Should().Contain("\"composition_plan\"").And.Contain("\"positive_global_styles\""),
                _ => ByteResponse([1, 2, 3], "audio/mpeg", ("song-id", "song-compose"))),
            new(
                "/v1/music/stream?output_format=mp3_22050_32",
                "application/json",
                body => body.Should().Contain("\"prompt\"").And.Contain(MusicPromptText),
                _ => ByteResponse([4, 5, 6], "audio/mpeg", ("song-id", "song-stream"))),
            new(
                "/v1/music/detailed?output_format=mp3_22050_32",
                "application/json",
                body => body.Should().Contain("\"with_timestamps\":true"),
                _ => ByteResponse([7, 8, 9], "multipart/mixed", ("song-id", "song-detailed"))),
            new(
                "/v1/music/video-to-music?output_format=mp3_22050_32",
                "multipart/form-data",
                body => body.Should().Contain("name=\"videos\"").And.Contain("name=\"description\"").And.Contain("upbeat"),
                _ => ByteResponse([10, 11, 12], "audio/mpeg")),
            new(
                "/v1/music/upload",
                "multipart/form-data",
                body => body.Should().Contain("name=\"file\"").And.Contain("song.mp3").And.Contain("extract_composition_plan"),
                _ => JsonResponse("""{"song_id":"uploaded-song","composition_plan":null}""")),
            new(
                "/v1/music/stem-separation?output_format=mp3_22050_32",
                "multipart/form-data",
                body => body.Should().Contain("name=\"file\"").And.Contain("song.mp3").And.Contain("stem_variation_id"),
                _ => ByteResponse([13, 14, 15], "application/zip")),
        ]);

        using var httpClient = new HttpClient(new MusicRecordingHttpMessageHandler(async (request, cancellationToken) =>
        {
            expectedRequests.Should().NotBeEmpty("the SDK should not send unexpected music endpoint requests");

            var expectation = expectedRequests.Dequeue();
            var body = request.Content is null
                ? string.Empty
                : await request.Content.ReadAsStringAsync(cancellationToken);

            AssertMusicRequest(request, expectation.PathAndQuery, expectation.ContentType);
            expectation.AssertBody(body);

            return expectation.CreateResponse(body);
        }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        using var client = new ElevenLabsClient(TestApiKey, httpClient, disposeHttpClient: false);

        var compositionPlan = (await client.MusicGeneration.CreateAsync(
            prompt: MusicPromptText,
            musicLengthMs: 3000)).PickValue1();
        compositionPlan.Sections.Should().ContainSingle();

        byte[] composedAudio = await client.Music.ComposeAsync(
            outputFormat: GenerateOutputFormat.Mp32205032,
            compositionPlan: compositionPlan);
        composedAudio.Should().BeEquivalentTo([1, 2, 3], options => options.WithStrictOrdering());

        using var streamedAudio = await client.Music.StreamAsync(
            outputFormat: StreamComposeOutputFormat.Mp32205032,
            prompt: MusicPromptText,
            musicLengthMs: 3000,
            forceInstrumental: true);
        using var streamedBuffer = new MemoryStream();
        await streamedAudio.CopyToAsync(streamedBuffer);
        streamedBuffer.ToArray().Should().BeEquivalentTo([4, 5, 6], options => options.WithStrictOrdering());

        byte[] detailedAudio = await client.Music.ComposeDetailedAsync(
            outputFormat: ComposeDetailedOutputFormat.Mp32205032,
            prompt: MusicPromptText,
            musicLengthMs: 3000,
            forceInstrumental: true,
            withTimestamps: true);
        detailedAudio.Should().BeEquivalentTo([7, 8, 9], options => options.WithStrictOrdering());

        byte[] videoMusic = await client.Music.VideoToMusicAsync(
            videos: [[16, 17, 18]],
            outputFormat: AllowedOutputFormats.Mp32205032,
            description: "Create upbeat background music for a product clip.",
            tags: ["upbeat", "synthwave"]);
        videoMusic.Should().BeEquivalentTo([10, 11, 12], options => options.WithStrictOrdering());

        var upload = await client.Music.UploadAsync(
            file: [19, 20, 21],
            filename: "song.mp3",
            extractCompositionPlan: true);
        upload.SongId.Should().Be("uploaded-song");

        byte[] stems = await client.Music.SeparateStemsAsync(
            file: [22, 23, 24],
            filename: "song.mp3",
            outputFormat: AllowedOutputFormats.Mp32205032,
            stemVariationId: BodyStemSeparationV1MusicStemSeparationPostStemVariationId.TwoStemsV1);
        stems.Should().BeEquivalentTo([13, 14, 15], options => options.WithStrictOrdering());

        expectedRequests.Should().BeEmpty();
    }

    private static void AssertReturnType(
        Type clientType,
        string methodName,
        Type returnType,
        params Type[] parameterTypes)
    {
        var method = clientType.GetMethod(methodName, parameterTypes);

        method.Should().NotBeNull($"{clientType.Name}.{methodName} should exist");
        method!.ReturnType.Should().Be(returnType);
    }

    private static void AssertMusicRequest(
        HttpRequestMessage request,
        string pathAndQuery,
        string contentType)
    {
        request.Method.Should().Be(HttpMethod.Post);
        request.RequestUri.Should().NotBeNull();
        request.RequestUri!.PathAndQuery.Should().Be(pathAndQuery);
        request.Headers.GetValues("xi-api-key").Should().Contain(TestApiKey);
        request.Content.Should().NotBeNull();
        request.Content!.Headers.ContentType.Should().NotBeNull();
        request.Content.Headers.ContentType!.MediaType.Should().Be(contentType);
    }

    private static HttpResponseMessage JsonResponse(string json) =>
        new(HttpStatusCode.OK)
        {
            Content = new StringContent(json, Encoding.UTF8, "application/json"),
        };

    private static HttpResponseMessage ByteResponse(
        byte[] bytes,
        string mediaType,
        params (string Name, string Value)[] headers)
    {
        var response = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new ByteArrayContent(bytes),
        };
        response.Content.Headers.ContentType = new MediaTypeHeaderValue(mediaType);

        foreach (var (name, value) in headers)
        {
            response.Headers.Add(name, value);
        }

        return response;
    }

    private sealed record MusicEndpointExpectation(
        string PathAndQuery,
        string ContentType,
        Action<string> AssertBody,
        Func<string, HttpResponseMessage> CreateResponse);

    private sealed class MusicRecordingHttpMessageHandler(
        Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> responder) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            return responder(request, cancellationToken);
        }
    }
}
