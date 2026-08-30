
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LanguageDetectionToolConfig
    {
        /// <summary>
        /// Default Value: language_detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        public string? SystemToolType { get; set; }

        /// <summary>
        /// If no language switch happens in the first 2 user turns, later attempts fail and the conversation stays in the current language. If the language switches during those turns, later switching stays available. Enable to reduce the possibility of false switching.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("only_at_conversation_start")]
        public bool? OnlyAtConversationStart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDetectionToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: language_detection
        /// </param>
        /// <param name="onlyAtConversationStart">
        /// If no language switch happens in the first 2 user turns, later attempts fail and the conversation stays in the current language. If the language switches during those turns, later switching stays available. Enable to reduce the possibility of false switching.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageDetectionToolConfig(
            string? systemToolType,
            bool? onlyAtConversationStart)
        {
            this.SystemToolType = systemToolType;
            this.OnlyAtConversationStart = onlyAtConversationStart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDetectionToolConfig" /> class.
        /// </summary>
        public LanguageDetectionToolConfig()
        {
        }

    }
}