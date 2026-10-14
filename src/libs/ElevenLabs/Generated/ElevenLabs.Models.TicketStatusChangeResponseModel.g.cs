
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketStatusChangeResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentConversationTicketStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentConversationTicketStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed_by_user_id")]
        public string? ChangedByUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChangedAtUnixSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketStatusChangeResponseModel" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="changedAtUnixSecs"></param>
        /// <param name="changedByUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketStatusChangeResponseModel(
            global::ElevenLabs.AgentConversationTicketStatus status,
            int changedAtUnixSecs,
            string? changedByUserId)
        {
            this.Status = status;
            this.ChangedByUserId = changedByUserId;
            this.ChangedAtUnixSecs = changedAtUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketStatusChangeResponseModel" /> class.
        /// </summary>
        public TicketStatusChangeResponseModel()
        {
        }

    }
}