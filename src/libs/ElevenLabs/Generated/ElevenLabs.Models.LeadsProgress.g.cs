
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LeadsProgress
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Unfinished leads whose first call hasn't been placed yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uncalled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Uncalled { get; set; }

        /// <summary>
        /// Unfinished leads whose next call an attention item holds back.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leads_needing_attention")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LeadsNeedingAttention { get; set; }

        /// <summary>
        /// Other unfinished leads: a call under way, awaiting analysis or a follow-up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Active { get; set; }

        /// <summary>
        /// Leads that won't be called again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Finished { get; set; }

        /// <summary>
        /// Finished leads by why they finished. Missing keys mean none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_by_disposition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> FinishedByDisposition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadsProgress" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="uncalled">
        /// Unfinished leads whose first call hasn't been placed yet.
        /// </param>
        /// <param name="leadsNeedingAttention">
        /// Unfinished leads whose next call an attention item holds back.
        /// </param>
        /// <param name="active">
        /// Other unfinished leads: a call under way, awaiting analysis or a follow-up.
        /// </param>
        /// <param name="finished">
        /// Leads that won't be called again.
        /// </param>
        /// <param name="finishedByDisposition">
        /// Finished leads by why they finished. Missing keys mean none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LeadsProgress(
            int total,
            int uncalled,
            int leadsNeedingAttention,
            int active,
            int finished,
            global::System.Collections.Generic.Dictionary<string, int> finishedByDisposition)
        {
            this.Total = total;
            this.Uncalled = uncalled;
            this.LeadsNeedingAttention = leadsNeedingAttention;
            this.Active = active;
            this.Finished = finished;
            this.FinishedByDisposition = finishedByDisposition ?? throw new global::System.ArgumentNullException(nameof(finishedByDisposition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadsProgress" /> class.
        /// </summary>
        public LeadsProgress()
        {
        }

    }
}