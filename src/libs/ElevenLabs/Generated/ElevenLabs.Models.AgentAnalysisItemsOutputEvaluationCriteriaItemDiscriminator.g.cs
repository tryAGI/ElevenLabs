
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSourceJsonConverter))]
        public global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminator" /> class.
        /// </summary>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminator(
            global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource? source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminator" /> class.
        /// </summary>
        public AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminator()
        {
        }

    }
}