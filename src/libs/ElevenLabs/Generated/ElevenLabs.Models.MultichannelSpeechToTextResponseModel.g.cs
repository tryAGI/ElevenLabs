
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response model for multichannel speech-to-text transcription.
    /// </summary>
    public sealed partial class MultichannelSpeechToTextResponseModel
    {
        /// <summary>
        /// List of transcripts, one for each audio channel. Each transcript contains the text and word-level details for its respective channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcripts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextChunkResponseModel> Transcripts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultichannelSpeechToTextResponseModel" /> class.
        /// </summary>
        /// <param name="transcripts">
        /// List of transcripts, one for each audio channel. Each transcript contains the text and word-level details for its respective channel.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultichannelSpeechToTextResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextChunkResponseModel> transcripts)
        {
            this.Transcripts = transcripts ?? throw new global::System.ArgumentNullException(nameof(transcripts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultichannelSpeechToTextResponseModel" /> class.
        /// </summary>
        public MultichannelSpeechToTextResponseModel()
        {
        }
    }
}