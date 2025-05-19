
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationConfigClientOverrideOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::ElevenLabs.AgentConfigOverride? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::ElevenLabs.TTSConversationalConfigOverride? Tts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::ElevenLabs.ConversationConfigOverride? Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideOutput" /> class.
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="tts"></param>
        /// <param name="conversation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConfigClientOverrideOutput(
            global::ElevenLabs.AgentConfigOverride? agent,
            global::ElevenLabs.TTSConversationalConfigOverride? tts,
            global::ElevenLabs.ConversationConfigOverride? conversation)
        {
            this.Agent = agent;
            this.Tts = tts;
            this.Conversation = conversation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideOutput" /> class.
        /// </summary>
        public ConversationConfigClientOverrideOutput()
        {
        }
    }
}