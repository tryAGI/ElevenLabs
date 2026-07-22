
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttachedUserEvaluationRef
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string Source { get; set; } = "user";

        /// <summary>
        /// Id of the referenced user evaluation item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnalysisItemId { get; set; }

        /// <summary>
        /// Primary item version whose result feeds scoring. None tracks the item's latest published version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Extra item versions to also run for comparison (A/B). These are executed and stored but excluded from scoring; the primary version_id is the one that scores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_version_ids")]
        public global::System.Collections.Generic.IList<string>? AdditionalVersionIds { get; set; }

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
        /// Initializes a new instance of the <see cref="AttachedUserEvaluationRef" /> class.
        /// </summary>
        /// <param name="analysisItemId">
        /// Id of the referenced user evaluation item.
        /// </param>
        /// <param name="versionId">
        /// Primary item version whose result feeds scoring. None tracks the item's latest published version.
        /// </param>
        /// <param name="additionalVersionIds">
        /// Extra item versions to also run for comparison (A/B). These are executed and stored but excluded from scoring; the primary version_id is the one that scores.
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
        public AttachedUserEvaluationRef(
            string analysisItemId,
            string? versionId,
            global::System.Collections.Generic.IList<string>? additionalVersionIds,
            global::ElevenLabs.AnalysisScope? scope,
            double? weight,
            string source = "user")
        {
            this.Source = source;
            this.AnalysisItemId = analysisItemId ?? throw new global::System.ArgumentNullException(nameof(analysisItemId));
            this.VersionId = versionId;
            this.AdditionalVersionIds = additionalVersionIds;
            this.Scope = scope;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedUserEvaluationRef" /> class.
        /// </summary>
        public AttachedUserEvaluationRef()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AttachedUserEvaluationRef"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AttachedUserEvaluationRef FromAnalysisItemId(string analysisItemId)
        {
            return new AttachedUserEvaluationRef
            {
                AnalysisItemId = analysisItemId,
            };
        }

    }
}