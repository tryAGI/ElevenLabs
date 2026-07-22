
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAnalysisItemsInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_criteria")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.EvaluationCriteriaItem>? EvaluationCriteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionItem>? DataCollection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAnalysisItemsInput" /> class.
        /// </summary>
        /// <param name="evaluationCriteria"></param>
        /// <param name="dataCollection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAnalysisItemsInput(
            global::System.Collections.Generic.IList<global::ElevenLabs.EvaluationCriteriaItem>? evaluationCriteria,
            global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionItem>? dataCollection)
        {
            this.EvaluationCriteria = evaluationCriteria;
            this.DataCollection = dataCollection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAnalysisItemsInput" /> class.
        /// </summary>
        public AgentAnalysisItemsInput()
        {
        }

    }
}