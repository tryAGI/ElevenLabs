
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Cost of running post-call analysis on this conversation.<br/>
    /// Present once an analysis pass has run, billed or not.
    /// </summary>
    public sealed partial class AnalysisCharging
    {
        /// <summary>
        /// Cumulative LLM cost of running post-call analysis on this conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnalysisRunningTotal Total { get; set; }

        /// <summary>
        /// LLM cost of the most recent post-call analysis pass on this conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnalysisRunSnapshot LastRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisCharging" /> class.
        /// </summary>
        /// <param name="total">
        /// Cumulative LLM cost of running post-call analysis on this conversation.
        /// </param>
        /// <param name="lastRun">
        /// LLM cost of the most recent post-call analysis pass on this conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalysisCharging(
            global::ElevenLabs.AnalysisRunningTotal total,
            global::ElevenLabs.AnalysisRunSnapshot lastRun)
        {
            this.Total = total ?? throw new global::System.ArgumentNullException(nameof(total));
            this.LastRun = lastRun ?? throw new global::System.ArgumentNullException(nameof(lastRun));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisCharging" /> class.
        /// </summary>
        public AnalysisCharging()
        {
        }

    }
}