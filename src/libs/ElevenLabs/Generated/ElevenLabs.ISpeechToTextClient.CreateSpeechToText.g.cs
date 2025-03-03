#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextClient
    {
        /// <summary>
        /// Speech To Text<br/>
        /// Transcribe an audio or video file.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SpeechToTextChunkResponseModel> CreateSpeechToTextAsync(
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Speech To Text<br/>
        /// Transcribe an audio or video file.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="modelId">
        /// The ID of the model to use for transcription, currently only 'scribe_v1' is available.
        /// </param>
        /// <param name="file">
        /// The file to transcribe. All major audio and video formats are supported. The file size must be less than 1GB.
        /// </param>
        /// <param name="filename">
        /// The file to transcribe. All major audio and video formats are supported. The file size must be less than 1GB.
        /// </param>
        /// <param name="languageCode">
        /// An ISO-639-1 or ISO-639-3 language_code corresponding to the language of the audio file. Can sometimes improve transcription performance if known beforehand. Defaults to null, in this case the language is predicted automatically.
        /// </param>
        /// <param name="tagAudioEvents">
        /// Whether to tag audio events like (laughter), (footsteps), etc. in the transcription.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="numSpeakers">
        /// The maximum amount of speakers talking in the uploaded file. Can help with predicting who speaks when. The maximum amount of speakers that can be predicted is 32. Defaults to null, in this case the amount of speakers is set to the maximum value the model supports.
        /// </param>
        /// <param name="timestampsGranularity">
        /// The granularity of the timestamps in the transcription. 'word' provides word-level timestamps and 'character' provides character-level timestamps per word.<br/>
        /// Default Value: word
        /// </param>
        /// <param name="diarize">
        /// Whether to annotate which speaker is currently talking in the uploaded file. Enabling this will limit the maximum duration of your inputs to 8 minutes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SpeechToTextChunkResponseModel> CreateSpeechToTextAsync(
            string modelId,
            byte[] file,
            string filename,
            string? xiApiKey = default,
            string? languageCode = default,
            bool? tagAudioEvents = default,
            int? numSpeakers = default,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? timestampsGranularity = default,
            bool? diarize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}