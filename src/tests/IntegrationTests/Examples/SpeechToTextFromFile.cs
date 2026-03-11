/*
order: 60
title: Speech to Text from a File
slug: speech-to-text-from-a-file

Transcribe a WAV file from disk and print the returned transcript text.
*/
namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SpeechToTextFromFile()
    {
        using var client = GetAuthenticatedClient();

        //// Load an audio file to transcribe.
        byte[] audioFile = await File.ReadAllBytesAsync(
            Path.Combine(AppContext.BaseDirectory, "Resources", "hello-in-russian-24k-pcm16.wav"));

        //// Submit the file for transcription.
        var transcription = await client.SpeechToText.CreateSpeechToTextAsync(
            modelId: BodySpeechToTextV1SpeechToTextPostModelId.ScribeV1,
            file: audioFile,
            languageCode: "ru");

        //// Print the transcript text when it is available.
        var transcriptText = transcription.Value1 is { } chunk
            ? chunk.Text
            : null;

        if (!string.IsNullOrWhiteSpace(transcriptText))
        {
            Console.WriteLine(transcriptText);
        }

        transcription.Should().NotBeNull();
        transcriptText.Should().NotBeNullOrWhiteSpace();
    }
}
