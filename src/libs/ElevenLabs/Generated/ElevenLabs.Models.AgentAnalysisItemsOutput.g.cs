
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAnalysisItemsOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_criteria")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.EvaluationCriteriaItem2>? EvaluationCriteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionItem2>? DataCollection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAnalysisItemsOutput" /> class.
        /// </summary>
        /// <param name="evaluationCriteria"></param>
        /// <param name="dataCollection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAnalysisItemsOutput(
            global::System.Collections.Generic.IList<global::ElevenLabs.EvaluationCriteriaItem2>? evaluationCriteria,
            global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionItem2>? dataCollection)
        {
            this.EvaluationCriteria = evaluationCriteria;
            this.DataCollection = dataCollection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAnalysisItemsOutput" /> class.
        /// </summary>
        public AgentAnalysisItemsOutput()
        {
        }

    }
}