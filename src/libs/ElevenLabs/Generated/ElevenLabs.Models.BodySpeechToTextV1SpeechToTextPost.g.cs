
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySpeechToTextV1SpeechToTextPost
    {
        /// <summary>
        /// The ID of the model to use for transcription, currently only 'scribe_v1' and 'scribe_v1_experimental' are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// The file to transcribe. All major audio and video formats are supported. The file size must be less than 1GB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The file to transcribe. All major audio and video formats are supported. The file size must be less than 1GB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// An ISO-639-1 or ISO-639-3 language_code corresponding to the language of the audio file. Can sometimes improve transcription performance if known beforehand. Defaults to null, in this case the language is predicted automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Whether to tag audio events like (laughter), (footsteps), etc. in the transcription.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_audio_events")]
        public bool? TagAudioEvents { get; set; }

        /// <summary>
        /// The maximum amount of speakers talking in the uploaded file. Can help with predicting who speaks when. The maximum amount of speakers that can be predicted is 32. Defaults to null, in this case the amount of speakers is set to the maximum value the model supports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_speakers")]
        public int? NumSpeakers { get; set; }

        /// <summary>
        /// The granularity of the timestamps in the transcription. 'word' provides word-level timestamps and 'character' provides character-level timestamps per word.<br/>
        /// Default Value: word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamps_granularity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter))]
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? TimestampsGranularity { get; set; }

        /// <summary>
        /// Whether to annotate which speaker is currently talking in the uploaded file.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarize")]
        public bool? Diarize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_formats")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ExportOptions>? AdditionalFormats { get; set; }

        /// <summary>
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other<br/>
        /// Example: pcm_s16le_16
        /// </summary>
        /// <example>pcm_s16le_16</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatJsonConverter))]
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat? FileFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySpeechToTextV1SpeechToTextPost" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model to use for transcription, currently only 'scribe_v1' and 'scribe_v1_experimental' are available.
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
        /// Whether to annotate which speaker is currently talking in the uploaded file.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="additionalFormats"></param>
        /// <param name="fileFormat">
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other<br/>
        /// Example: pcm_s16le_16
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySpeechToTextV1SpeechToTextPost(
            string modelId,
            byte[] file,
            string filename,
            string? languageCode,
            bool? tagAudioEvents,
            int? numSpeakers,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? timestampsGranularity,
            bool? diarize,
            global::System.Collections.Generic.IList<global::ElevenLabs.ExportOptions>? additionalFormats,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat? fileFormat)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.LanguageCode = languageCode;
            this.TagAudioEvents = tagAudioEvents;
            this.NumSpeakers = numSpeakers;
            this.TimestampsGranularity = timestampsGranularity;
            this.Diarize = diarize;
            this.AdditionalFormats = additionalFormats;
            this.FileFormat = fileFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySpeechToTextV1SpeechToTextPost" /> class.
        /// </summary>
        public BodySpeechToTextV1SpeechToTextPost()
        {
        }
    }
}