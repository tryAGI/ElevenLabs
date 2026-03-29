/*
order: 40
title: Streaming Text to Speech with Timestamps
slug: streaming-text-to-speech-with-timestamps

Pick a voice from the available catalog, then stream synthesized audio together with character-level timing information for subtitles, captions, or lip-sync.
*/
namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_StreamingTextToSpeechWithTimestamps()
    {
        using var client = GetAuthenticatedClient();

        //// Choose a voice to synthesize with.
        var voices = await client.Voices.GetAllAsync();
        var voice = voices.Voices[0];
        const string text = "Hello, this has timestamps.";

        Console.WriteLine($"Using voice: {voice.Name} ({voice.VoiceId})");
        Console.WriteLine($"Input text: {text}");

        //// Request streamed speech audio with timing metadata.
        StreamingAudioChunkWithTimestampsResponseModel? firstChunk = null;
        int chunkCount = 0;

        await foreach (var chunk in client.TextToSpeech.StreamWithTimestampsAsync(
                           voiceId: voice.VoiceId,
                           text: text,
                           modelId: "eleven_multilingual_v2",
                           outputFormat: TextToSpeechStreamWithTimestampsOutputFormat.Mp32205032))
        {
            firstChunk ??= chunk;
            chunkCount++;

            //// Inspect the alignment information when it is present.
            if (chunkCount == 1 && chunk.Alignment is { } alignment)
            {
                for (int i = 0; i < alignment.Characters?.Count; i++)
                {
                    Console.WriteLine($"'{alignment.Characters[i]}' " +
                                      $"{alignment.CharacterStartTimesSeconds?[i]:F3}s - " +
                                      $"{alignment.CharacterEndTimesSeconds?[i]:F3}s");
                }
            }
        }

        chunkCount.Should().BeGreaterThan(0);
        firstChunk.Should().NotBeNull();
        firstChunk!.AudioBase64.Should().NotBeNullOrWhiteSpace();
    }
}
