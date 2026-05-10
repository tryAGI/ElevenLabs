
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetryTriggerAction
    {
        /// <summary>
        /// Default Value: retry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Custom feedback to inject into the agent when retrying after guardrail trigger.<br/>
        /// Default Value: Your response was blocked by a guardrail that blocks content that matches this condition/category: '{{trigger_reason}}' During your next turn you must tell the user "I'm sorry but I can't answer that question, would you like to know something else?".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public string? Feedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryTriggerAction" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: retry
        /// </param>
        /// <param name="feedback">
        /// Custom feedback to inject into the agent when retrying after guardrail trigger.<br/>
        /// Default Value: Your response was blocked by a guardrail that blocks content that matches this condition/category: '{{trigger_reason}}' During your next turn you must tell the user "I'm sorry but I can't answer that question, would you like to know something else?".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetryTriggerAction(
            string? type,
            string? feedback)
        {
            this.Type = type;
            this.Feedback = feedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryTriggerAction" /> class.
        /// </summary>
        public RetryTriggerAction()
        {
        }

    }
}