
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch
    {
        /// <summary>
        /// A custom, human-readable name for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated content for the document. Only supported for text documents, URL documents with auto-sync disabled, and file documents that are not synced from an external source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Whether the document or folder is refreshed automatically. Only applicable to URL documents, folders, and externally-synced files. Leave unset to keep the current value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_auto_sync")]
        public bool? EnableAutoSync { get; set; }

        /// <summary>
        /// Whether to automatically remove the document once its source is no longer available. Only applicable when auto-sync is enabled. Leave unset to keep the current value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_remove")]
        public bool? AutoRemove { get; set; }

        /// <summary>
        /// Minimum frequency (in days) at which the document is refreshed. The actual interval may be shorter, never longer. Only applicable when auto-sync is enabled. Leave unset to keep the current value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_frequency_days")]
        public int? MinimumFrequencyDays { get; set; }

        /// <summary>
        /// Folders only. When true, items already in the folder are only tightened to stay at least as strict as the folder, and keep any setting that is stricter than the folder's. When false, they are set to exactly the folder's auto-sync settings. Ignored for externally synced folders, whose contents always follow the folder's schedule.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tighten_only")]
        public bool? TightenOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch" /> class.
        /// </summary>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        /// <param name="content">
        /// Updated content for the document. Only supported for text documents, URL documents with auto-sync disabled, and file documents that are not synced from an external source.
        /// </param>
        /// <param name="enableAutoSync">
        /// Whether the document or folder is refreshed automatically. Only applicable to URL documents, folders, and externally-synced files. Leave unset to keep the current value.
        /// </param>
        /// <param name="autoRemove">
        /// Whether to automatically remove the document once its source is no longer available. Only applicable when auto-sync is enabled. Leave unset to keep the current value.
        /// </param>
        /// <param name="minimumFrequencyDays">
        /// Minimum frequency (in days) at which the document is refreshed. The actual interval may be shorter, never longer. Only applicable when auto-sync is enabled. Leave unset to keep the current value.
        /// </param>
        /// <param name="tightenOnly">
        /// Folders only. When true, items already in the folder are only tightened to stay at least as strict as the folder, and keep any setting that is stricter than the folder's. When false, they are set to exactly the folder's auto-sync settings. Ignored for externally synced folders, whose contents always follow the folder's schedule.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch(
            string? name,
            string? content,
            bool? enableAutoSync,
            bool? autoRemove,
            int? minimumFrequencyDays,
            bool? tightenOnly)
        {
            this.Name = name;
            this.Content = content;
            this.EnableAutoSync = enableAutoSync;
            this.AutoRemove = autoRemove;
            this.MinimumFrequencyDays = minimumFrequencyDays;
            this.TightenOnly = tightenOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch" /> class.
        /// </summary>
        public BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch()
        {
        }

    }
}