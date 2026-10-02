
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationHistoryRedactionConfig
    {
        /// <summary>
        /// Whether conversation history redaction is enabled<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The entities to redact from the conversation transcript, audio and analysis. Use top-level types like 'name', 'email_address', or dot notation for specific subtypes like 'name.full_name'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConfigEntityType>? Entities { get; set; }

        /// <summary>
        /// Data collection item IDs whose extracted values are not redacted. Their rationales are still redacted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_data_collection_ids")]
        public global::System.Collections.Generic.IList<string>? ExcludedDataCollectionIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryRedactionConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether conversation history redaction is enabled<br/>
        /// Default Value: false
        /// </param>
        /// <param name="entities">
        /// The entities to redact from the conversation transcript, audio and analysis. Use top-level types like 'name', 'email_address', or dot notation for specific subtypes like 'name.full_name'.
        /// </param>
        /// <param name="excludedDataCollectionIds">
        /// Data collection item IDs whose extracted values are not redacted. Their rationales are still redacted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryRedactionConfig(
            bool? enabled,
            global::System.Collections.Generic.IList<global::ElevenLabs.ConfigEntityType>? entities,
            global::System.Collections.Generic.IList<string>? excludedDataCollectionIds)
        {
            this.Enabled = enabled;
            this.Entities = entities;
            this.ExcludedDataCollectionIds = excludedDataCollectionIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryRedactionConfig" /> class.
        /// </summary>
        public ConversationHistoryRedactionConfig()
        {
        }

    }
}