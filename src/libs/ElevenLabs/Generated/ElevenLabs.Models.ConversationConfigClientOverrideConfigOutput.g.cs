
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationConfigClientOverrideConfigOutput
    {
        /// <summary>
        /// Configures overrides for nested fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public global::ElevenLabs.TurnConfigOverrideConfig? Turn { get; set; }

        /// <summary>
        /// Configures overrides for nested fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::ElevenLabs.TTSConversationalConfigOverrideConfig? Tts { get; set; }

        /// <summary>
        /// Configures overrides for nested fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::ElevenLabs.ConversationConfigOverrideConfig? Conversation { get; set; }

        /// <summary>
        /// Configures overrides for nested fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::ElevenLabs.AgentConfigOverrideConfig? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideConfigOutput" /> class.
        /// </summary>
        /// <param name="turn">
        /// Configures overrides for nested fields.
        /// </param>
        /// <param name="tts">
        /// Configures overrides for nested fields.
        /// </param>
        /// <param name="conversation">
        /// Configures overrides for nested fields.
        /// </param>
        /// <param name="agent">
        /// Configures overrides for nested fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConfigClientOverrideConfigOutput(
            global::ElevenLabs.TurnConfigOverrideConfig? turn,
            global::ElevenLabs.TTSConversationalConfigOverrideConfig? tts,
            global::ElevenLabs.ConversationConfigOverrideConfig? conversation,
            global::ElevenLabs.AgentConfigOverrideConfig? agent)
        {
            this.Turn = turn;
            this.Tts = tts;
            this.Conversation = conversation;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideConfigOutput" /> class.
        /// </summary>
        public ConversationConfigClientOverrideConfigOutput()
        {
        }
    }
}