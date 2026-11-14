
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Which `campaign__` dynamic variables follow-up calls get.
    /// </summary>
    public sealed partial class FollowupContextPolicy
    {
        /// <summary>
        /// Pass the call type as `campaign__call_type`.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_type")]
        public bool? CallType { get; set; }

        /// <summary>
        /// Pass the last conversation's ID as `campaign__previous_conversation_id`.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_conversation_id")]
        public bool? PreviousConversationId { get; set; }

        /// <summary>
        /// Pass the last conversation's summary as `campaign__previous_summary`.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_summary")]
        public bool? PreviousSummary { get; set; }

        /// <summary>
        /// Pass the last conversation's transcript as `campaign__previous_transcript`.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_transcript")]
        public bool? PreviousTranscript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowupContextPolicy" /> class.
        /// </summary>
        /// <param name="callType">
        /// Pass the call type as `campaign__call_type`.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="previousConversationId">
        /// Pass the last conversation's ID as `campaign__previous_conversation_id`.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="previousSummary">
        /// Pass the last conversation's summary as `campaign__previous_summary`.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="previousTranscript">
        /// Pass the last conversation's transcript as `campaign__previous_transcript`.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FollowupContextPolicy(
            bool? callType,
            bool? previousConversationId,
            bool? previousSummary,
            bool? previousTranscript)
        {
            this.CallType = callType;
            this.PreviousConversationId = previousConversationId;
            this.PreviousSummary = previousSummary;
            this.PreviousTranscript = previousTranscript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowupContextPolicy" /> class.
        /// </summary>
        public FollowupContextPolicy()
        {
        }

    }
}