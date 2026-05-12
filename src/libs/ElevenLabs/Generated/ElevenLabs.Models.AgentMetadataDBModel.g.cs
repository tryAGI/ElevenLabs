
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentMetadataDBModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAtUnixSecs { get; set; }

        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter))]
        public global::ElevenLabs.AgentDefinitionSource? CreatedFrom { get; set; }

        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter))]
        public global::ElevenLabs.AgentDefinitionSource? LastUpdatedFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMetadataDBModel" /> class.
        /// </summary>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="updatedAtUnixSecs"></param>
        /// <param name="createdFrom">
        /// Default Value: unknown
        /// </param>
        /// <param name="lastUpdatedFrom">
        /// Default Value: unknown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMetadataDBModel(
            int createdAtUnixSecs,
            int updatedAtUnixSecs,
            global::ElevenLabs.AgentDefinitionSource? createdFrom,
            global::ElevenLabs.AgentDefinitionSource? lastUpdatedFrom)
        {
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.UpdatedAtUnixSecs = updatedAtUnixSecs;
            this.CreatedFrom = createdFrom;
            this.LastUpdatedFrom = lastUpdatedFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMetadataDBModel" /> class.
        /// </summary>
        public AgentMetadataDBModel()
        {
        }

    }
}