
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Cost of running post-call analysis on this conversation.<br/>
    /// Present once analysis has incurred a cost. `last_run` is null when the<br/>
    /// most recent pass incurred none.
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run")]
        public global::ElevenLabs.AnalysisRunSnapshot? LastRun { get; set; }

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
        /// <param name="lastRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalysisCharging(
            global::ElevenLabs.AnalysisRunningTotal total,
            global::ElevenLabs.AnalysisRunSnapshot? lastRun)
        {
            this.Total = total ?? throw new global::System.ArgumentNullException(nameof(total));
            this.LastRun = lastRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisCharging" /> class.
        /// </summary>
        public AnalysisCharging()
        {
        }

    }
}