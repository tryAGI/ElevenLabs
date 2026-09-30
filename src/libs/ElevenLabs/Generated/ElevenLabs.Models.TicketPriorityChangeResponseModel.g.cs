
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketPriorityChangeResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public global::ElevenLabs.AgentConversationTicketPriority? Priority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed_by_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChangedByUserId { get; set; }

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
        /// Initializes a new instance of the <see cref="TicketPriorityChangeResponseModel" /> class.
        /// </summary>
        /// <param name="changedByUserId"></param>
        /// <param name="changedAtUnixSecs"></param>
        /// <param name="priority"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketPriorityChangeResponseModel(
            string changedByUserId,
            int changedAtUnixSecs,
            global::ElevenLabs.AgentConversationTicketPriority? priority)
        {
            this.Priority = priority;
            this.ChangedByUserId = changedByUserId ?? throw new global::System.ArgumentNullException(nameof(changedByUserId));
            this.ChangedAtUnixSecs = changedAtUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketPriorityChangeResponseModel" /> class.
        /// </summary>
        public TicketPriorityChangeResponseModel()
        {
        }

    }
}