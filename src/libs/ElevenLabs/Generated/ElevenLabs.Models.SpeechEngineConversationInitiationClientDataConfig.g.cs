
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechEngineConversationInitiationClientDataConfig
    {
        /// <summary>
        /// Whether the first message can be overridden by the client<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public bool? FirstMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechEngineConversationInitiationClientDataConfig" /> class.
        /// </summary>
        /// <param name="firstMessage">
        /// Whether the first message can be overridden by the client<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechEngineConversationInitiationClientDataConfig(
            bool? firstMessage)
        {
            this.FirstMessage = firstMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechEngineConversationInitiationClientDataConfig" /> class.
        /// </summary>
        public SpeechEngineConversationInitiationClientDataConfig()
        {
        }

    }
}