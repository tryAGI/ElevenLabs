
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceMailDetectionResultSuccessModel
    {
        /// <summary>
        /// Default Value: voicemail_detection_success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.VoiceMailDetectionResultSuccessModelResultTypeJsonConverter))]
        public global::ElevenLabs.VoiceMailDetectionResultSuccessModelResultType? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.VoiceMailDetectionResultSuccessModelStatusJsonConverter))]
        public global::ElevenLabs.VoiceMailDetectionResultSuccessModelStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemail_message")]
        public string? VoicemailMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceMailDetectionResultSuccessModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: voicemail_detection_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="voicemailMessage"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceMailDetectionResultSuccessModel(
            global::ElevenLabs.VoiceMailDetectionResultSuccessModelResultType? resultType,
            global::ElevenLabs.VoiceMailDetectionResultSuccessModelStatus? status,
            string? voicemailMessage,
            string? reason)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.VoicemailMessage = voicemailMessage;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceMailDetectionResultSuccessModel" /> class.
        /// </summary>
        public VoiceMailDetectionResultSuccessModel()
        {
        }
    }
}