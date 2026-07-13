
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// provenance for an auto-generated simulation-library test (drives dedup + ui grouping).
    /// </summary>
    public sealed partial class AutoGenerationMetadata
    {
        /// <summary>
        /// Agent whose simulation library this test belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Stable topic id (from topic discovery) this test covers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stable_topic_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StableTopicId { get; set; }

        /// <summary>
        /// Evaluation criterion id this test targets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CriteriaId { get; set; }

        /// <summary>
        /// Human-readable topic label at generation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TopicLabel { get; set; }

        /// <summary>
        /// Conversation the test was generated from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceConversationId { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) when the test was generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset GeneratedAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoGenerationMetadata" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Agent whose simulation library this test belongs to.
        /// </param>
        /// <param name="stableTopicId">
        /// Stable topic id (from topic discovery) this test covers.
        /// </param>
        /// <param name="criteriaId">
        /// Evaluation criterion id this test targets.
        /// </param>
        /// <param name="topicLabel">
        /// Human-readable topic label at generation time.
        /// </param>
        /// <param name="sourceConversationId">
        /// Conversation the test was generated from.
        /// </param>
        /// <param name="generatedAtUnix">
        /// Unix timestamp (seconds) when the test was generated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoGenerationMetadata(
            string agentId,
            string stableTopicId,
            string criteriaId,
            string topicLabel,
            string sourceConversationId,
            global::System.DateTimeOffset generatedAtUnix)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.StableTopicId = stableTopicId ?? throw new global::System.ArgumentNullException(nameof(stableTopicId));
            this.CriteriaId = criteriaId ?? throw new global::System.ArgumentNullException(nameof(criteriaId));
            this.TopicLabel = topicLabel ?? throw new global::System.ArgumentNullException(nameof(topicLabel));
            this.SourceConversationId = sourceConversationId ?? throw new global::System.ArgumentNullException(nameof(sourceConversationId));
            this.GeneratedAtUnix = generatedAtUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoGenerationMetadata" /> class.
        /// </summary>
        public AutoGenerationMetadata()
        {
        }

    }
}