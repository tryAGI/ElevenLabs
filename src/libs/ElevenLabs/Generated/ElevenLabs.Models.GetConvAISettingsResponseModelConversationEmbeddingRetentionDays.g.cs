
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Days to retain conversation embeddings. None means use the system default (30 days).
    /// </summary>
    public sealed partial class GetConvAISettingsResponseModelConversationEmbeddingRetentionDays
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}