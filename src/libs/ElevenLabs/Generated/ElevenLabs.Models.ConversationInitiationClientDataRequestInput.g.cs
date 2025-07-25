
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationInitiationClientDataRequestInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config_override")]
        public global::ElevenLabs.ConversationConfigClientOverrideInput? ConversationConfigOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm_extra_body")]
        public object? CustomLlmExtraBody { get; set; }

        /// <summary>
        /// ID of the end user participating in this conversation (for agent owner's user identification)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Information about the source of conversation initiation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_info")]
        public global::ElevenLabs.ConversationInitiationSourceInfo? SourceInfo { get; set; }

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
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataRequestInput" /> class.
        /// </summary>
        /// <param name="conversationConfigOverride"></param>
        /// <param name="customLlmExtraBody"></param>
        /// <param name="userId">
        /// ID of the end user participating in this conversation (for agent owner's user identification)
        /// </param>
        /// <param name="sourceInfo">
        /// Information about the source of conversation initiation
        /// </param>
        /// <param name="dynamicVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationInitiationClientDataRequestInput(
            global::ElevenLabs.ConversationConfigClientOverrideInput? conversationConfigOverride,
            object? customLlmExtraBody,
            string? userId,
            global::ElevenLabs.ConversationInitiationSourceInfo? sourceInfo,
            object? dynamicVariables)
        {
            this.ConversationConfigOverride = conversationConfigOverride;
            this.CustomLlmExtraBody = customLlmExtraBody;
            this.UserId = userId;
            this.SourceInfo = sourceInfo;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataRequestInput" /> class.
        /// </summary>
        public ConversationInitiationClientDataRequestInput()
        {
        }
    }
}