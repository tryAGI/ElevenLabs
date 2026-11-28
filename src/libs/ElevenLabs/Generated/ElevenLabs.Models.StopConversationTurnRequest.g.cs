
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StopConversationTurnRequest
    {
        /// <summary>
        /// The turn to stop. If you omit it, the endpoint stops the latest turn of the conversation. Send it so that a late stop cannot stop a newer turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopConversationTurnRequest" /> class.
        /// </summary>
        /// <param name="turnId">
        /// The turn to stop. If you omit it, the endpoint stops the latest turn of the conversation. Send it so that a late stop cannot stop a newer turn.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopConversationTurnRequest(
            string? turnId)
        {
            this.TurnId = turnId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopConversationTurnRequest" /> class.
        /// </summary>
        public StopConversationTurnRequest()
        {
        }

    }
}