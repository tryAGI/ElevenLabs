
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"agent_id":"agent_01k6m3w9xq4f2c8t7n5b0r1d2e","entities":[{"events":[],"facts":[{"attribute":"diet","id":"umfa_01k6m3w9xq4f2c8t7n5b0r1d2e","last_seen_conversation_id":"conv_01k6m3w9xq4f2c8t7n5b0r1d2e","learned_at_unix_secs":1789000000,"reference_count":2,"text":"Is vegetarian.","valid_from":"2026-03-01"}],"id":"umen_01k6m3w9xq4f2c8t7n5b0r1d2e","is_user":true,"name":"user","relations":[],"type":"person"}],"exported_at_unix_secs":1790000000,"user_id":"ausr_01k6m3w9xq4f2c8t7n5b0r1d2e"}
    /// </summary>
    public sealed partial class ExportUserMemoryResponseModel
    {
        /// <summary>
        /// ID of the agent whose memory was exported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// ID of the end user the export is about.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// When the export was taken.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exported_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExportedAtUnixSecs { get; set; }

        /// <summary>
        /// Everything the agent remembers about the user, by who or what it is about, the user first. Includes what is no longer believed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.RenderedUserMemoryEntity> Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportUserMemoryResponseModel" /> class.
        /// </summary>
        /// <param name="agentId">
        /// ID of the agent whose memory was exported.
        /// </param>
        /// <param name="userId">
        /// ID of the end user the export is about.
        /// </param>
        /// <param name="exportedAtUnixSecs">
        /// When the export was taken.
        /// </param>
        /// <param name="entities">
        /// Everything the agent remembers about the user, by who or what it is about, the user first. Includes what is no longer believed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportUserMemoryResponseModel(
            string agentId,
            string userId,
            int exportedAtUnixSecs,
            global::System.Collections.Generic.IList<global::ElevenLabs.RenderedUserMemoryEntity> entities)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ExportedAtUnixSecs = exportedAtUnixSecs;
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportUserMemoryResponseModel" /> class.
        /// </summary>
        public ExportUserMemoryResponseModel()
        {
        }

    }
}