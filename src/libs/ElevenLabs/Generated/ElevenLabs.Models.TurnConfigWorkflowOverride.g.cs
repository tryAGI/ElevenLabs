
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"interruption_ignore_term_languages":[],"interruption_ignore_terms":[],"mode":"turn","retranscribe_on_turn_timeout":false,"silence_end_call_timeout":-1.0,"soft_timeout_config":{"message":"Hhmmmm...yeah.","timeout_seconds":-1.0,"use_llm_generated_message":false},"speculative_turn":false,"spelling_patience":"auto","transcribe_on_disabled_interruptions":false,"turn_eagerness":"normal","turn_model":"turn_v3","turn_timeout":7.0}
    /// </summary>
    public sealed partial class TurnConfigWorkflowOverride
    {
        /// <summary>
        /// Maximum wait time for the user's reply before re-engaging the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_timeout")]
        public double? TurnTimeout { get; set; }

        /// <summary>
        /// How long the agent will wait for the user to start the conversation if the first message is empty. If not set, uses the regular turn_timeout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_wait_time")]
        public double? InitialWaitTime { get; set; }

        /// <summary>
        /// Maximum wait time since the user last spoke before terminating the call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_end_call_timeout")]
        public double? SilenceEndCallTimeout { get; set; }

        /// <summary>
        /// The mode of turn detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public global::ElevenLabs.TurnMode? Mode { get; set; }

        /// <summary>
        /// Controls how eager the agent is to respond. Low = less eager (waits longer), Standard = default eagerness, High = more eager (responds sooner)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_eagerness")]
        public global::ElevenLabs.TurnEagerness? TurnEagerness { get; set; }

        /// <summary>
        /// Controls if the agent should be more patient when user is spelling numbers and named entities. Auto = model based, Off = never wait extra
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spelling_patience")]
        public global::ElevenLabs.SpellingPatience? SpellingPatience { get; set; }

        /// <summary>
        /// When enabled, starts generating LLM responses during silence before full turn confidence is reached, reducing perceived latency. May increase LLM costs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speculative_turn")]
        public bool? SpeculativeTurn { get; set; }

        /// <summary>
        /// When enabled, if VAD detects no speech, attempts to re-transcribe accumulated audio at turn timeout. Disables silence discount billing for affected turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retranscribe_on_turn_timeout")]
        public bool? RetranscribeOnTurnTimeout { get; set; }

        /// <summary>
        /// Version of the turn detection model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_model")]
        public global::ElevenLabs.TurnModel? TurnModel { get; set; }

        /// <summary>
        /// List of terms that should not trigger an interruption when spoken by the user (e.g. 'gotcha', 'understood'). Uses case-insensitive exact matching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_ignore_terms")]
        public global::System.Collections.Generic.IList<string>? InterruptionIgnoreTerms { get; set; }

        /// <summary>
        /// Language codes for which preset ignore-term categories have been activated. Stored explicitly so display is not inferred from term overlap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_ignore_term_languages")]
        public global::System.Collections.Generic.IList<string>? InterruptionIgnoreTermLanguages { get; set; }

        /// <summary>
        /// When interruptions are disabled, still transcribe what the user says so it can carry into the next turn. When off, user speech during a non-interruptible turn is ignored and won't trigger a turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribe_on_disabled_interruptions")]
        public bool? TranscribeOnDisabledInterruptions { get; set; }

        /// <summary>
        /// Configuration for soft timeout functionality. Provides immediate feedback during longer LLM responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_timeout_config")]
        public global::ElevenLabs.SoftTimeoutConfigWorkflowOverride? SoftTimeoutConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfigWorkflowOverride" /> class.
        /// </summary>
        /// <param name="turnTimeout">
        /// Maximum wait time for the user's reply before re-engaging the user
        /// </param>
        /// <param name="initialWaitTime">
        /// How long the agent will wait for the user to start the conversation if the first message is empty. If not set, uses the regular turn_timeout.
        /// </param>
        /// <param name="silenceEndCallTimeout">
        /// Maximum wait time since the user last spoke before terminating the call
        /// </param>
        /// <param name="mode">
        /// The mode of turn detection
        /// </param>
        /// <param name="turnEagerness">
        /// Controls how eager the agent is to respond. Low = less eager (waits longer), Standard = default eagerness, High = more eager (responds sooner)
        /// </param>
        /// <param name="spellingPatience">
        /// Controls if the agent should be more patient when user is spelling numbers and named entities. Auto = model based, Off = never wait extra
        /// </param>
        /// <param name="speculativeTurn">
        /// When enabled, starts generating LLM responses during silence before full turn confidence is reached, reducing perceived latency. May increase LLM costs.
        /// </param>
        /// <param name="retranscribeOnTurnTimeout">
        /// When enabled, if VAD detects no speech, attempts to re-transcribe accumulated audio at turn timeout. Disables silence discount billing for affected turns.
        /// </param>
        /// <param name="turnModel">
        /// Version of the turn detection model to use.
        /// </param>
        /// <param name="interruptionIgnoreTerms">
        /// List of terms that should not trigger an interruption when spoken by the user (e.g. 'gotcha', 'understood'). Uses case-insensitive exact matching.
        /// </param>
        /// <param name="interruptionIgnoreTermLanguages">
        /// Language codes for which preset ignore-term categories have been activated. Stored explicitly so display is not inferred from term overlap.
        /// </param>
        /// <param name="transcribeOnDisabledInterruptions">
        /// When interruptions are disabled, still transcribe what the user says so it can carry into the next turn. When off, user speech during a non-interruptible turn is ignored and won't trigger a turn.
        /// </param>
        /// <param name="softTimeoutConfig">
        /// Configuration for soft timeout functionality. Provides immediate feedback during longer LLM responses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurnConfigWorkflowOverride(
            double? turnTimeout,
            double? initialWaitTime,
            double? silenceEndCallTimeout,
            global::ElevenLabs.TurnMode? mode,
            global::ElevenLabs.TurnEagerness? turnEagerness,
            global::ElevenLabs.SpellingPatience? spellingPatience,
            bool? speculativeTurn,
            bool? retranscribeOnTurnTimeout,
            global::ElevenLabs.TurnModel? turnModel,
            global::System.Collections.Generic.IList<string>? interruptionIgnoreTerms,
            global::System.Collections.Generic.IList<string>? interruptionIgnoreTermLanguages,
            bool? transcribeOnDisabledInterruptions,
            global::ElevenLabs.SoftTimeoutConfigWorkflowOverride? softTimeoutConfig)
        {
            this.TurnTimeout = turnTimeout;
            this.InitialWaitTime = initialWaitTime;
            this.SilenceEndCallTimeout = silenceEndCallTimeout;
            this.Mode = mode;
            this.TurnEagerness = turnEagerness;
            this.SpellingPatience = spellingPatience;
            this.SpeculativeTurn = speculativeTurn;
            this.RetranscribeOnTurnTimeout = retranscribeOnTurnTimeout;
            this.TurnModel = turnModel;
            this.InterruptionIgnoreTerms = interruptionIgnoreTerms;
            this.InterruptionIgnoreTermLanguages = interruptionIgnoreTermLanguages;
            this.TranscribeOnDisabledInterruptions = transcribeOnDisabledInterruptions;
            this.SoftTimeoutConfig = softTimeoutConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfigWorkflowOverride" /> class.
        /// </summary>
        public TurnConfigWorkflowOverride()
        {
        }

    }
}