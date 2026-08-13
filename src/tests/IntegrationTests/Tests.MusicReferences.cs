using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ElevenMusicReferences_AreSerializedAndSongIdIsCaptured()
    {
        const string sourceSongId = "source-song-id";
        var requestCount = 0;

        using var httpClient = new HttpClient(new MusicRecordingHttpMessageHandler(async (request, cancellationToken) =>
        {
            requestCount++;

            request.Method.Should().Be(HttpMethod.Post);
            request.RequestUri.Should().NotBeNull();
            request.RequestUri!.PathAndQuery.Should().Be("/v1/music?output_format=mp3_48000_192");
            request.Headers.GetValues("xi-api-key").Should().Contain(TestApiKey);

            string body = await request.Content!.ReadAsStringAsync(cancellationToken);
            using var json = JsonDocument.Parse(body);
            JsonElement root = json.RootElement;

            if (requestCount == 1)
            {
                root.GetProperty("prompt").GetString().Should().Be(MusicPromptText);

                return MusicReferenceByteResponse([1, 2, 3], sourceSongId);
            }

            root.GetProperty("model_id").GetString().Should().Be("music_v2");
            JsonElement chunks = root.GetProperty("composition_plan").GetProperty("chunks");
            chunks.GetArrayLength().Should().Be(2);

            JsonElement generatedChunk = chunks[0];
            generatedChunk.GetProperty("conditioning_ref").GetProperty("song_id").GetString().Should().Be(sourceSongId);
            generatedChunk.GetProperty("conditioning_ref").GetProperty("range").GetProperty("start_ms").GetInt32().Should().Be(0);
            generatedChunk.GetProperty("conditioning_ref").GetProperty("range").GetProperty("end_ms").GetInt32().Should().Be(10_000);
            generatedChunk.GetProperty("condition_strength").GetString().Should().Be("high");

            JsonElement reusedChunk = chunks[1];
            reusedChunk.GetProperty("song_id").GetString().Should().Be(sourceSongId);
            reusedChunk.GetProperty("range").GetProperty("start_ms").GetInt32().Should().Be(10_000);
            reusedChunk.GetProperty("range").GetProperty("end_ms").GetInt32().Should().Be(20_000);

            return MusicReferenceByteResponse([4, 5, 6], "referenced-song-id");
        }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        using var client = new ElevenLabsClient(TestApiKey, httpClient, disposeHttpClient: false);
        MusicClient music = client.Music;

        byte[] sourceAudio = await music.ComposeAsync(
            outputFormat: GenerateOutputFormat.Mp348000192,
            prompt: MusicPromptText,
            musicLengthMs: 10_000,
            modelId: BodyComposeMusicV1MusicPostModelId.MusicV2,
            storeForInpainting: true);

        sourceAudio.Should().BeEquivalentTo([1, 2, 3], options => options.WithStrictOrdering());
        music.LastSongId.Should().Be(sourceSongId);
        music.GetLastResponseHeader("song-id").Should().Be(sourceSongId);

        var conditioningReference = new AudioRefChunk(
            songId: music.LastSongId!,
            range: new TimeRange(startMs: 0, endMs: 10_000));
        var reusedReference = new AudioRefChunk(
            songId: music.LastSongId!,
            range: new TimeRange(startMs: 10_000, endMs: 20_000));
        var referencePlan = new CompositionPlan(
        [
            new GenerationChunkInput(
                text: "[Intro]\nInstrumental opening",
                durationMs: 10_000,
                positiveStyles: ["synthwave", "bright arpeggios", "steady drums"],
                negativeStyles: [],
                contextAdherence: GenerationChunkInputContextAdherence.High,
                conditioningRef: conditioningReference,
                conditionStrength: GenerationChunkInputConditionStrength2.High),
            reusedReference,
        ]);

        byte[] referencedAudio = await music.ComposeAsync(
            outputFormat: GenerateOutputFormat.Mp348000192,
            compositionPlan: referencePlan,
            modelId: BodyComposeMusicV1MusicPostModelId.MusicV2);

        referencedAudio.Should().BeEquivalentTo([4, 5, 6], options => options.WithStrictOrdering());
        music.LastSongId.Should().Be("referenced-song-id");
        client.Music.LastSongId.Should().Be("referenced-song-id");
        requestCount.Should().Be(2);
    }

    private static HttpResponseMessage MusicReferenceByteResponse(byte[] bytes, string songId)
    {
        var response = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new ByteArrayContent(bytes),
        };
        response.Content.Headers.ContentType = new MediaTypeHeaderValue("audio/mpeg");
        response.Headers.Add("song-id", songId);
        return response;
    }
}
