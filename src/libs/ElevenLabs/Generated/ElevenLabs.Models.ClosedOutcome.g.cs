
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClosedOutcome
    {
        /// <summary>
        /// Default Value: closed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MergeProposalCloseReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.MergeProposalCloseReason Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int At { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_user_id")]
        public string? ByUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClosedOutcome" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="at"></param>
        /// <param name="status">
        /// Default Value: closed
        /// </param>
        /// <param name="byUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClosedOutcome(
            global::ElevenLabs.MergeProposalCloseReason reason,
            int at,
            string? status,
            string? byUserId)
        {
            this.Status = status;
            this.Reason = reason;
            this.At = at;
            this.ByUserId = byUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClosedOutcome" /> class.
        /// </summary>
        public ClosedOutcome()
        {
        }

    }
}