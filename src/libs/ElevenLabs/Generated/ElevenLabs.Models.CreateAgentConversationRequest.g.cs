
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentConversationRequest
    {
        /// <summary>
        /// The agent that runs the turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentMessagesPersistedAgent Agent { get; set; }

        /// <summary>
        /// The environment to use for resolving environment variables (e.g. 'production', 'staging'). Defaults to the branch's environment, then 'production'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// ID of the end user participating in this conversation (for agent owner's user identification)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConversationRequest" /> class.
        /// </summary>
        /// <param name="agent">
        /// The agent that runs the turns.
        /// </param>
        /// <param name="environment">
        /// The environment to use for resolving environment variables (e.g. 'production', 'staging'). Defaults to the branch's environment, then 'production'.
        /// </param>
        /// <param name="userId">
        /// ID of the end user participating in this conversation (for agent owner's user identification)
        /// </param>
        /// <param name="dynamicVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentConversationRequest(
            global::ElevenLabs.AgentMessagesPersistedAgent agent,
            string? environment,
            string? userId,
            object? dynamicVariables)
        {
            this.Agent = agent ?? throw new global::System.ArgumentNullException(nameof(agent));
            this.Environment = environment;
            this.UserId = userId;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConversationRequest" /> class.
        /// </summary>
        public CreateAgentConversationRequest()
        {
        }

    }
}