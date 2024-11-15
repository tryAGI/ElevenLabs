
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationHistoryTranscriptCommonModelRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_in_call_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimeInCallSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptCommonModel" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="message"></param>
        /// <param name="timeInCallSecs"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ConversationHistoryTranscriptCommonModel(
            global::ElevenLabs.ConversationHistoryTranscriptCommonModelRole role,
            string message,
            int timeInCallSecs)
        {
            this.Role = role;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.TimeInCallSecs = timeInCallSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptCommonModel" /> class.
        /// </summary>
        public ConversationHistoryTranscriptCommonModel()
        {
        }
    }
}