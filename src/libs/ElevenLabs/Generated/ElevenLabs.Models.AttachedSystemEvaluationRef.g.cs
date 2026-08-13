
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttachedSystemEvaluationRef
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"system"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string Source { get; set; } = "system";

        /// <summary>
        /// Id of the referenced built-in system evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_item_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AttachedSystemEvaluationRefAnalysisItemIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AttachedSystemEvaluationRefAnalysisItemId AnalysisItemId { get; set; }

        /// <summary>
        /// Transcript context ('conversation' or 'agent') used when running this item.<br/>
        /// Default Value: conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter))]
        public global::ElevenLabs.AnalysisScope? Scope { get; set; }

        /// <summary>
        /// Optional relative weight for aggregate scoring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedSystemEvaluationRef" /> class.
        /// </summary>
        /// <param name="analysisItemId">
        /// Id of the referenced built-in system evaluation.
        /// </param>
        /// <param name="scope">
        /// Transcript context ('conversation' or 'agent') used when running this item.<br/>
        /// Default Value: conversation
        /// </param>
        /// <param name="weight">
        /// Optional relative weight for aggregate scoring.
        /// </param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachedSystemEvaluationRef(
            global::ElevenLabs.AttachedSystemEvaluationRefAnalysisItemId analysisItemId,
            global::ElevenLabs.AnalysisScope? scope,
            double? weight,
            string source = "system")
        {
            this.Source = source;
            this.AnalysisItemId = analysisItemId;
            this.Scope = scope;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedSystemEvaluationRef" /> class.
        /// </summary>
        public AttachedSystemEvaluationRef()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AttachedSystemEvaluationRef"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AttachedSystemEvaluationRef FromAnalysisItemId(global::ElevenLabs.AttachedSystemEvaluationRefAnalysisItemId analysisItemId)
        {
            return new AttachedSystemEvaluationRef
            {
                AnalysisItemId = analysisItemId,
            };
        }

    }
}