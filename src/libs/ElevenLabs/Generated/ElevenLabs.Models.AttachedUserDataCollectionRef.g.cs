
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttachedUserDataCollectionRef
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string Source { get; set; } = "user";

        /// <summary>
        /// Id of the referenced user data-collection item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnalysisItemId { get; set; }

        /// <summary>
        /// Pinned item version. None tracks the item's latest published version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Transcript context ('conversation' or 'agent') used when running this item.<br/>
        /// Default Value: conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter))]
        public global::ElevenLabs.AnalysisScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedUserDataCollectionRef" /> class.
        /// </summary>
        /// <param name="analysisItemId">
        /// Id of the referenced user data-collection item.
        /// </param>
        /// <param name="versionId">
        /// Pinned item version. None tracks the item's latest published version.
        /// </param>
        /// <param name="scope">
        /// Transcript context ('conversation' or 'agent') used when running this item.<br/>
        /// Default Value: conversation
        /// </param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachedUserDataCollectionRef(
            string analysisItemId,
            string? versionId,
            global::ElevenLabs.AnalysisScope? scope,
            string source = "user")
        {
            this.Source = source;
            this.AnalysisItemId = analysisItemId ?? throw new global::System.ArgumentNullException(nameof(analysisItemId));
            this.VersionId = versionId;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedUserDataCollectionRef" /> class.
        /// </summary>
        public AttachedUserDataCollectionRef()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AttachedUserDataCollectionRef"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AttachedUserDataCollectionRef FromAnalysisItemId(string analysisItemId)
        {
            return new AttachedUserDataCollectionRef
            {
                AnalysisItemId = analysisItemId,
            };
        }

    }
}