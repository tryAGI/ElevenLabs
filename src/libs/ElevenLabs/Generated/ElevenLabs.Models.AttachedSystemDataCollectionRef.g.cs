
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttachedSystemDataCollectionRef
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"system"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string Source { get; set; } = "system";

        /// <summary>
        /// Id of the referenced built-in system data-collection item.
        /// </summary>
        /// <default>"__system_data_collection_topic"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_item_id")]
        public string AnalysisItemId { get; set; } = "__system_data_collection_topic";

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
        /// Initializes a new instance of the <see cref="AttachedSystemDataCollectionRef" /> class.
        /// </summary>
        /// <param name="scope">
        /// Transcript context ('conversation' or 'agent') used when running this item.<br/>
        /// Default Value: conversation
        /// </param>
        /// <param name="source"></param>
        /// <param name="analysisItemId">
        /// Id of the referenced built-in system data-collection item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachedSystemDataCollectionRef(
            global::ElevenLabs.AnalysisScope? scope,
            string source = "system",
            string analysisItemId = "__system_data_collection_topic")
        {
            this.Source = source;
            this.AnalysisItemId = analysisItemId;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedSystemDataCollectionRef" /> class.
        /// </summary>
        public AttachedSystemDataCollectionRef()
        {
        }

    }
}