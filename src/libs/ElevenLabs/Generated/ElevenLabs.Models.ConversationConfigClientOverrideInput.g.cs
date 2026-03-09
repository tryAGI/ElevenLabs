
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}},"tts":{"voice_id":"cjVigY5qzO86Huf0OWal"}}
    /// </summary>
    public sealed partial class ConversationConfigClientOverrideInput
    {
        /// <summary>
        /// Example: {"voice_id":"cjVigY5qzO86Huf0OWal"}
        /// </summary>
        /// <example>{"voice_id":"cjVigY5qzO86Huf0OWal"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::ElevenLabs.TTSConversationalConfigOverride? Tts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::ElevenLabs.ConversationConfigOverride? Conversation { get; set; }

        /// <summary>
        /// Example: {"first_message":"Hello, how can I help you today?","language":"en","prompt":{"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}}
        /// </summary>
        /// <example>{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::ElevenLabs.AgentConfigOverride? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideInput" /> class.
        /// </summary>
        /// <param name="tts">
        /// Example: {"voice_id":"cjVigY5qzO86Huf0OWal"}
        /// </param>
        /// <param name="conversation"></param>
        /// <param name="agent">
        /// Example: {"first_message":"Hello, how can I help you today?","language":"en","prompt":{"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConfigClientOverrideInput(
            global::ElevenLabs.TTSConversationalConfigOverride? tts,
            global::ElevenLabs.ConversationConfigOverride? conversation,
            global::ElevenLabs.AgentConfigOverride? agent)
        {
            this.Tts = tts;
            this.Conversation = conversation;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideInput" /> class.
        /// </summary>
        public ConversationConfigClientOverrideInput()
        {
        }
    }
}