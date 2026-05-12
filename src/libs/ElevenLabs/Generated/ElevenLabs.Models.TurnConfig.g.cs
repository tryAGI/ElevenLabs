
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"interruption_ignore_terms":[],"mode":"turn","retranscribe_on_turn_timeout":false,"silence_end_call_timeout":-1.0,"soft_timeout_config":{"message":"Hhmmmm...yeah.","timeout_seconds":-1.0},"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0}
    /// </summary>
    public sealed partial class TurnConfig
    {
        /// <summary>
        /// Maximum wait time for the user's reply before re-engaging the user<br/>
        /// Default Value: 7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_timeout")]
        public double? TurnTimeout { get; set; }

        /// <summary>
        /// How long the agent will wait for the user to start the conversation if the first message is empty. If not set, uses the regular turn_timeout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_wait_time")]
        public double? InitialWaitTime { get; set; }

        /// <summary>
        /// Maximum wait time since the user last spoke before terminating the call<br/>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_end_call_timeout")]
        public double? SilenceEndCallTimeout { get; set; }

        /// <summary>
        /// The mode of turn detection<br/>
        /// Default Value: turn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TurnModeJsonConverter))]
        public global::ElevenLabs.TurnMode? Mode { get; set; }

        /// <summary>
        /// Controls how eager the agent is to respond. Low = less eager (waits longer), Standard = default eagerness, High = more eager (responds sooner)<br/>
        /// Default Value: normal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_eagerness")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TurnEagernessJsonConverter))]
        public global::ElevenLabs.TurnEagerness? TurnEagerness { get; set; }

        /// <summary>
        /// Controls if the agent should be more patient when user is spelling numbers and named entities. Auto = model based, Off = never wait extra<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spelling_patience")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SpellingPatienceJsonConverter))]
        public global::ElevenLabs.SpellingPatience? SpellingPatience { get; set; }

        /// <summary>
        /// When enabled, starts generating LLM responses during silence before full turn confidence is reached, reducing perceived latency. May increase LLM costs.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speculative_turn")]
        public bool? SpeculativeTurn { get; set; }

        /// <summary>
        /// When enabled, if VAD detects no speech, attempts to re-transcribe accumulated audio at turn timeout. Disables silence discount billing for affected turns.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retranscribe_on_turn_timeout")]
        public bool? RetranscribeOnTurnTimeout { get; set; }

        /// <summary>
        /// Configuration for soft timeout functionality. Provides immediate feedback during longer LLM responses.<br/>
        /// Example: {"message":"Hhmmmm...yeah.","timeout_seconds":2.0,"use_llm_generated_message":false}
        /// </summary>
        /// <example>{"message":"Hhmmmm...yeah.","timeout_seconds":2.0,"use_llm_generated_message":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_timeout_config")]
        public global::ElevenLabs.SoftTimeoutConfig? SoftTimeoutConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfig" /> class.
        /// </summary>
        /// <param name="turnTimeout">
        /// Maximum wait time for the user's reply before re-engaging the user<br/>
        /// Default Value: 7F
        /// </param>
        /// <param name="initialWaitTime">
        /// How long the agent will wait for the user to start the conversation if the first message is empty. If not set, uses the regular turn_timeout.
        /// </param>
        /// <param name="silenceEndCallTimeout">
        /// Maximum wait time since the user last spoke before terminating the call<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="mode">
        /// The mode of turn detection<br/>
        /// Default Value: turn
        /// </param>
        /// <param name="turnEagerness">
        /// Controls how eager the agent is to respond. Low = less eager (waits longer), Standard = default eagerness, High = more eager (responds sooner)<br/>
        /// Default Value: normal
        /// </param>
        /// <param name="spellingPatience">
        /// Controls if the agent should be more patient when user is spelling numbers and named entities. Auto = model based, Off = never wait extra<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="speculativeTurn">
        /// When enabled, starts generating LLM responses during silence before full turn confidence is reached, reducing perceived latency. May increase LLM costs.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="retranscribeOnTurnTimeout">
        /// When enabled, if VAD detects no speech, attempts to re-transcribe accumulated audio at turn timeout. Disables silence discount billing for affected turns.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="softTimeoutConfig">
        /// Configuration for soft timeout functionality. Provides immediate feedback during longer LLM responses.<br/>
        /// Example: {"message":"Hhmmmm...yeah.","timeout_seconds":2.0,"use_llm_generated_message":false}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurnConfig(
            double? turnTimeout,
            double? initialWaitTime,
            double? silenceEndCallTimeout,
            global::ElevenLabs.TurnMode? mode,
            global::ElevenLabs.TurnEagerness? turnEagerness,
            global::ElevenLabs.SpellingPatience? spellingPatience,
            bool? speculativeTurn,
            bool? retranscribeOnTurnTimeout,
            global::ElevenLabs.SoftTimeoutConfig? softTimeoutConfig)
        {
            this.TurnTimeout = turnTimeout;
            this.InitialWaitTime = initialWaitTime;
            this.SilenceEndCallTimeout = silenceEndCallTimeout;
            this.Mode = mode;
            this.TurnEagerness = turnEagerness;
            this.SpellingPatience = spellingPatience;
            this.SpeculativeTurn = speculativeTurn;
            this.RetranscribeOnTurnTimeout = retranscribeOnTurnTimeout;
            this.SoftTimeoutConfig = softTimeoutConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfig" /> class.
        /// </summary>
        public TurnConfig()
        {
        }

    }
}