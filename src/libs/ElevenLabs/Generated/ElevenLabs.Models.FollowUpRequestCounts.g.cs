
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FollowUpRequestCounts
    {
        /// <summary>
        /// How many times contacts asked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Requested { get; set; }

        /// <summary>
        /// Requests by what the campaign did about them; adds up to `requested`. Missing keys mean none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_by_disposition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> RequestedByDisposition { get; set; }

        /// <summary>
        /// Leads that asked at least once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_leads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DistinctLeads { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowUpRequestCounts" /> class.
        /// </summary>
        /// <param name="requested">
        /// How many times contacts asked.
        /// </param>
        /// <param name="requestedByDisposition">
        /// Requests by what the campaign did about them; adds up to `requested`. Missing keys mean none.
        /// </param>
        /// <param name="distinctLeads">
        /// Leads that asked at least once.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FollowUpRequestCounts(
            int requested,
            global::System.Collections.Generic.Dictionary<string, int> requestedByDisposition,
            int distinctLeads)
        {
            this.Requested = requested;
            this.RequestedByDisposition = requestedByDisposition ?? throw new global::System.ArgumentNullException(nameof(requestedByDisposition));
            this.DistinctLeads = distinctLeads;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowUpRequestCounts" /> class.
        /// </summary>
        public FollowUpRequestCounts()
        {
        }

    }
}