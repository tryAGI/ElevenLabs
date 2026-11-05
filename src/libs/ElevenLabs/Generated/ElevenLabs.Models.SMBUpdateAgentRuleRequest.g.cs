
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request model for updating an existing agent rule.
    /// </summary>
    public sealed partial class SMBUpdateAgentRuleRequest
    {
        /// <summary>
        /// Title of the rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// What the agent should do, in detail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// strict: the agent must always follow the rule; suggestion: a guideline.<br/>
        /// Default Value: strict
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RulePriorityJsonConverter))]
        public global::ElevenLabs.RulePriority? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBUpdateAgentRuleRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the rule.
        /// </param>
        /// <param name="description">
        /// What the agent should do, in detail.
        /// </param>
        /// <param name="priority">
        /// strict: the agent must always follow the rule; suggestion: a guideline.<br/>
        /// Default Value: strict
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBUpdateAgentRuleRequest(
            string title,
            string description,
            global::ElevenLabs.RulePriority? priority)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBUpdateAgentRuleRequest" /> class.
        /// </summary>
        public SMBUpdateAgentRuleRequest()
        {
        }

    }
}