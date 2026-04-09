#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs
{
    public partial interface ISpeechToText2Client
    {
        /// <summary>
        /// Speech To Text<br/>
        /// Transcribe an audio or video file. If webhook is set to true, the request will be processed asynchronously and results sent to configured webhooks. When use_multi_channel is true and the provided audio has multiple channels, a 'transcripts' object with separate transcripts for each channel is returned. Otherwise, returns a single transcript. The optional webhook_metadata parameter allows you to attach custom data that will be included in webhook responses for request correlation and tracking.
        /// </summary>
        /// <param name="enableLogging">
        /// When enable_logging is set to false zero retention mode will be used for the request. This will mean log and transcript storage features are unavailable for this request. Zero retention mode may only be used by enterprise customers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>> ConvertAsync(

            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost request,
            bool? enableLogging = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speech To Text<br/>
        /// Transcribe an audio or video file. If webhook is set to true, the request will be processed asynchronously and results sent to configured webhooks. When use_multi_channel is true and the provided audio has multiple channels, a 'transcripts' object with separate transcripts for each channel is returned. Otherwise, returns a single transcript. The optional webhook_metadata parameter allows you to attach custom data that will be included in webhook responses for request correlation and tracking.
        /// </summary>
        /// <param name="enableLogging">
        /// When enable_logging is set to false zero retention mode will be used for the request. This will mean log and transcript storage features are unavailable for this request. Zero retention mode may only be used by enterprise customers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="modelId">
        /// The ID of the model to use for transcription.
        /// </param>
        /// <param name="file">
        /// The file to transcribe (100ms minimum audio length). All major audio and video formats are supported. Exactly one of the file or cloud_storage_url parameters must be provided. The file size must be less than 3.0GB.
        /// </param>
        /// <param name="filename">
        /// The file to transcribe (100ms minimum audio length). All major audio and video formats are supported. Exactly one of the file or cloud_storage_url parameters must be provided. The file size must be less than 3.0GB.
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
        /// Whether to annotate which speaker is currently talking in the uploaded file.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="diarizationThreshold">
        /// Diarization threshold to apply during speaker diarization. A higher value means there will be a lower chance of one speaker being diarized as two different speakers but also a higher chance of two different speakers being diarized as one speaker (less total speakers predicted). A low value means there will be a higher chance of one speaker being diarized as two different speakers but also a lower chance of two different speakers being diarized as one speaker (more total speakers predicted). Can only be set when diarize=True and num_speakers=None. Defaults to None, in which case we will choose a threshold based on the model_id (0.22 usually).
        /// </param>
        /// <param name="additionalFormats">
        /// A list of additional formats to export the transcript to.
        /// </param>
        /// <param name="fileFormat">
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other
        /// </param>
        /// <param name="sourceUrl">
        /// The URL of an audio or video file to transcribe. Supports hosted video or audio files, YouTube video URLs, TikTok video URLs, and other video hosting services.
        /// </param>
        /// <param name="webhook">
        /// Whether to send the transcription result to configured speech-to-text webhooks.  If set the request will return early without the transcription, which will be delivered later via webhook.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookId">
        /// Optional specific webhook ID to send the transcription result to. Only valid when webhook is set to true. If not provided, transcription will be sent to all configured speech-to-text webhooks.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the transcription output. Accepts values between 0.0 and 2.0, where higher values result in more diverse and less deterministic results. If omitted, we will use a temperature based on the model you selected which is usually 0.
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be an integer between 0 and 2147483647.
        /// </param>
        /// <param name="useMultiChannel">
        /// Whether the audio file contains multiple channels where each channel contains a single speaker. When enabled, each channel will be transcribed independently and the results will be combined. Each word in the response will include a 'channel_index' field indicating which channel it was spoken on. A maximum of 5 channels is supported. Each channel is billed independently at the full audio duration, so cost scales linearly with the number of channels.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookMetadata">
        /// Optional metadata to be included in the webhook response. This should be a JSON string representing an object with a maximum depth of 2 levels and maximum size of 16KB. Useful for tracking internal IDs, job references, or other contextual information.
        /// </param>
        /// <param name="entityDetection">
        /// Detect entities in the transcript. Can be 'all' to detect all entities, a single entity type or category string, or a list of entity types/categories. Categories include 'pii', 'phi', 'pci', 'other', 'offensive_language'. When enabled, detected entities will be returned in the 'entities' field with their text, type, and character positions. Usage of this parameter will incur an additional 30% surcharge on the base transcription cost.
        /// </param>
        /// <param name="noVerbatim">
        /// If true, the transcription will not have any filler words, false starts and non-speech sounds. Only supported with scribe_v2 model.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="entityRedaction">
        /// Redact entities from the transcript text. Accepts the same format as entity_detection: 'all', a category ('pii', 'phi'), or specific entity types. Must be a subset of entity_detection. When redaction is enabled, the entities field will not be returned. Usage of this parameter will incur an additional 30% surcharge on the base transcription cost.
        /// </param>
        /// <param name="entityRedactionMode">
        /// How to format redacted entities. 'redacted' replaces with {REDACTED}, 'entity_type' replaces with {ENTITY_TYPE}, 'enumerated_entity_type' replaces with {ENTITY_TYPE_N} where N enumerates each occurrence. Only used when entity_redaction is set.<br/>
        /// Default Value: enumerated_entity_type
        /// </param>
        /// <param name="keyterms">
        /// A list of keyterms to bias the transcription towards.           The keyterms are words or phrases you want the model to recognise more accurately.           The number of keyterms cannot exceed 1000.           The length of each keyterm must be less than 50 characters.           Keyterms can contain at most 5 words (after normalisation).           For example ["hello", "world", "technical term"].           Usage of this parameter will incur an additional 20% surcharge on the base transcription cost.           When more than 100 keyterms are provided, a minimum billable duration of 20 seconds applies per request.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>> ConvertAsync(
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostModelId modelId,
            bool? enableLogging = default,
            byte[]? file = default,
            string? filename = default,
            string? languageCode = default,
            bool? tagAudioEvents = default,
            int? numSpeakers = default,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? timestampsGranularity = default,
            bool? diarize = default,
            double? diarizationThreshold = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ExportOptions>? additionalFormats = default,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat? fileFormat = default,
            string? sourceUrl = default,
            bool? webhook = default,
            string? webhookId = default,
            double? temperature = default,
            int? seed = default,
            bool? useMultiChannel = default,
            global::ElevenLabs.AnyOf<string, object, object>? webhookMetadata = default,
            global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? entityDetection = default,
            bool? noVerbatim = default,
            global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? entityRedaction = default,
            string? entityRedactionMode = default,
            global::System.Collections.Generic.IList<string>? keyterms = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}