
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomerFacingConfigOutput
    {
        /// <summary>
        /// Extra instructions for the agent (e.g., 'Always ask callers to spell out their name')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_instructions")]
        public string? AdditionalInstructions { get; set; }

        /// <summary>
        /// Personality/tone trait keys that drive the Personality prompt section (e.g. ['professional', 'concise']).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone_traits")]
        public global::System.Collections.Generic.IList<string>? ToneTraits { get; set; }

        /// <summary>
        /// Details the agent should always try to collect from callers (presets + custom labels, e.g. ['full name', 'phone number']).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details_to_collect")]
        public global::System.Collections.Generic.IList<string>? DetailsToCollect { get; set; }

        /// <summary>
        /// Concrete LLM powering the receptionist. Constrained to SMB_ALLOWED_LLMS (see validate_reasoning_effort). None means no explicit model was chosen; the factory falls back to the historical default (SMB_DEFAULT_LEGACY_LLM) so configs predating this field keep their original model. New agents are created with SMB_DEFAULT_NEW_AGENT_LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::ElevenLabs.Llm? Llm { get; set; }

        /// <summary>
        /// Reasoning effort for the receptionist's model. Must be one of the model's supported efforts (see LLM.available_reasoning_efforts) and is capped at MEDIUM for SMB (see SMB_RECEPTIONIST_REASONING_EFFORTS); use null for the model default / models without configurable reasoning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        public global::ElevenLabs.LLMReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// When true, the receptionist's knowledge base is injected in full into the system prompt instead of being retrieved via vector RAG on every turn. This removes the per-turn embedding + vector-search latency, but is only viable for small knowledge bases that fit within the prompt budget (KNOWLEDGE_BASE_IN_PROMPT_MAX_LEN). Knowledge bases too large to inline fall back to RAG at build time.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_rag")]
        public bool? DisableRag { get; set; }

        /// <summary>
        /// Filter out far-field human speech before transcription.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_voice_detection")]
        public bool? BackgroundVoiceDetection { get; set; }

        /// <summary>
        /// How quickly the receptionist decides the caller has finished speaking. Eager replies soonest; patient waits for a clearer end of turn.<br/>
        /// Default Value: eager
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_eagerness")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SMBTurnEagernessJsonConverter))]
        public global::ElevenLabs.SMBTurnEagerness? TurnEagerness { get; set; }

        /// <summary>
        /// ElevenLabs voice ID<br/>
        /// Default Value: 5kMbtRSEKIkRZSdXxrZg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Primary language code<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional language codes the agent can communicate in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_languages")]
        public global::System.Collections.Generic.IList<string>? AdditionalLanguages { get; set; }

        /// <summary>
        /// The first message the agent says when starting a conversation<br/>
        /// Default Value: Hello! Thanks for calling. How can I help you today?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// When true, callers cannot interrupt the receptionist while the first message is being delivered. Use when the greeting carries a recording or legal notice callers must hear in full.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_first_message_interruptions")]
        public bool? DisableFirstMessageInterruptions { get; set; }

        /// <summary>
        /// Allow the end_call system tool during conversations.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_end_call_tool")]
        public bool? EnableEndCallTool { get; set; }

        /// <summary>
        /// Allow the skip_turn system tool during conversations.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_skip_turn_tool")]
        public bool? EnableSkipTurnTool { get; set; }

        /// <summary>
        /// Allow the play_keypad_touch_tone (DTMF) system tool during conversations. When enabled, the receptionist can play touch-tone digits on a live call to navigate automated phone menus or answer carrier prompts such as a 'press 1 to accept' call-screening step.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_play_keypad_touch_tone_tool")]
        public bool? EnablePlayKeypadTouchToneTool { get; set; }

        /// <summary>
        /// Behavioral rules this agent must follow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_rules")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentRule>? AgentRules { get; set; }

        /// <summary>
        /// Phone numbers this agent can transfer calls to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_rules")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBTransferRule>? TransferRules { get; set; }

        /// <summary>
        /// Show the business's own number, rather than the caller's, as the caller ID on transferred calls.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hide_caller_number_on_transfers")]
        public bool? HideCallerNumberOnTransfers { get; set; }

        /// <summary>
        /// Keep recording after a call is transferred and add that audio to the call recording.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("record_after_transfers")]
        public bool? RecordAfterTransfers { get; set; }

        /// <summary>
        /// Standard operating procedures (SOPs) this agent can run on calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("procedures")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBProcedure>? Procedures { get; set; }

        /// <summary>
        /// When enabled, the receptionist may only look up or modify appointments and client records tied to the caller's verified phone number.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_secure_mode")]
        public bool? EnableSecureMode { get; set; }

        /// <summary>
        /// When enabled, inbound calls to US numbers are screened before the receptionist answers: calls whose caller ID failed carrier (STIR/SHAKEN) verification are rejected, and unknown callers whose caller ID the carrier could not vouch for must press a key to be connected.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_spam_protection")]
        public bool? EnableSpamProtection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerFacingConfigOutput" /> class.
        /// </summary>
        /// <param name="additionalInstructions">
        /// Extra instructions for the agent (e.g., 'Always ask callers to spell out their name')
        /// </param>
        /// <param name="toneTraits">
        /// Personality/tone trait keys that drive the Personality prompt section (e.g. ['professional', 'concise']).
        /// </param>
        /// <param name="detailsToCollect">
        /// Details the agent should always try to collect from callers (presets + custom labels, e.g. ['full name', 'phone number']).
        /// </param>
        /// <param name="llm">
        /// Concrete LLM powering the receptionist. Constrained to SMB_ALLOWED_LLMS (see validate_reasoning_effort). None means no explicit model was chosen; the factory falls back to the historical default (SMB_DEFAULT_LEGACY_LLM) so configs predating this field keep their original model. New agents are created with SMB_DEFAULT_NEW_AGENT_LLM.
        /// </param>
        /// <param name="reasoningEffort">
        /// Reasoning effort for the receptionist's model. Must be one of the model's supported efforts (see LLM.available_reasoning_efforts) and is capped at MEDIUM for SMB (see SMB_RECEPTIONIST_REASONING_EFFORTS); use null for the model default / models without configurable reasoning.
        /// </param>
        /// <param name="disableRag">
        /// When true, the receptionist's knowledge base is injected in full into the system prompt instead of being retrieved via vector RAG on every turn. This removes the per-turn embedding + vector-search latency, but is only viable for small knowledge bases that fit within the prompt budget (KNOWLEDGE_BASE_IN_PROMPT_MAX_LEN). Knowledge bases too large to inline fall back to RAG at build time.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="backgroundVoiceDetection">
        /// Filter out far-field human speech before transcription.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="turnEagerness">
        /// How quickly the receptionist decides the caller has finished speaking. Eager replies soonest; patient waits for a clearer end of turn.<br/>
        /// Default Value: eager
        /// </param>
        /// <param name="voiceId">
        /// ElevenLabs voice ID<br/>
        /// Default Value: 5kMbtRSEKIkRZSdXxrZg
        /// </param>
        /// <param name="language">
        /// Primary language code<br/>
        /// Default Value: en
        /// </param>
        /// <param name="additionalLanguages">
        /// Additional language codes the agent can communicate in
        /// </param>
        /// <param name="firstMessage">
        /// The first message the agent says when starting a conversation<br/>
        /// Default Value: Hello! Thanks for calling. How can I help you today?
        /// </param>
        /// <param name="disableFirstMessageInterruptions">
        /// When true, callers cannot interrupt the receptionist while the first message is being delivered. Use when the greeting carries a recording or legal notice callers must hear in full.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableEndCallTool">
        /// Allow the end_call system tool during conversations.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enableSkipTurnTool">
        /// Allow the skip_turn system tool during conversations.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enablePlayKeypadTouchToneTool">
        /// Allow the play_keypad_touch_tone (DTMF) system tool during conversations. When enabled, the receptionist can play touch-tone digits on a live call to navigate automated phone menus or answer carrier prompts such as a 'press 1 to accept' call-screening step.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="agentRules">
        /// Behavioral rules this agent must follow.
        /// </param>
        /// <param name="transferRules">
        /// Phone numbers this agent can transfer calls to.
        /// </param>
        /// <param name="hideCallerNumberOnTransfers">
        /// Show the business's own number, rather than the caller's, as the caller ID on transferred calls.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="recordAfterTransfers">
        /// Keep recording after a call is transferred and add that audio to the call recording.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="procedures">
        /// Standard operating procedures (SOPs) this agent can run on calls.
        /// </param>
        /// <param name="enableSecureMode">
        /// When enabled, the receptionist may only look up or modify appointments and client records tied to the caller's verified phone number.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableSpamProtection">
        /// When enabled, inbound calls to US numbers are screened before the receptionist answers: calls whose caller ID failed carrier (STIR/SHAKEN) verification are rejected, and unknown callers whose caller ID the carrier could not vouch for must press a key to be connected.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerFacingConfigOutput(
            string? additionalInstructions,
            global::System.Collections.Generic.IList<string>? toneTraits,
            global::System.Collections.Generic.IList<string>? detailsToCollect,
            global::ElevenLabs.Llm? llm,
            global::ElevenLabs.LLMReasoningEffort? reasoningEffort,
            bool? disableRag,
            bool? backgroundVoiceDetection,
            global::ElevenLabs.SMBTurnEagerness? turnEagerness,
            string? voiceId,
            string? language,
            global::System.Collections.Generic.IList<string>? additionalLanguages,
            string? firstMessage,
            bool? disableFirstMessageInterruptions,
            bool? enableEndCallTool,
            bool? enableSkipTurnTool,
            bool? enablePlayKeypadTouchToneTool,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentRule>? agentRules,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBTransferRule>? transferRules,
            bool? hideCallerNumberOnTransfers,
            bool? recordAfterTransfers,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBProcedure>? procedures,
            bool? enableSecureMode,
            bool? enableSpamProtection)
        {
            this.AdditionalInstructions = additionalInstructions;
            this.ToneTraits = toneTraits;
            this.DetailsToCollect = detailsToCollect;
            this.Llm = llm;
            this.ReasoningEffort = reasoningEffort;
            this.DisableRag = disableRag;
            this.BackgroundVoiceDetection = backgroundVoiceDetection;
            this.TurnEagerness = turnEagerness;
            this.VoiceId = voiceId;
            this.Language = language;
            this.AdditionalLanguages = additionalLanguages;
            this.FirstMessage = firstMessage;
            this.DisableFirstMessageInterruptions = disableFirstMessageInterruptions;
            this.EnableEndCallTool = enableEndCallTool;
            this.EnableSkipTurnTool = enableSkipTurnTool;
            this.EnablePlayKeypadTouchToneTool = enablePlayKeypadTouchToneTool;
            this.AgentRules = agentRules;
            this.TransferRules = transferRules;
            this.HideCallerNumberOnTransfers = hideCallerNumberOnTransfers;
            this.RecordAfterTransfers = recordAfterTransfers;
            this.Procedures = procedures;
            this.EnableSecureMode = enableSecureMode;
            this.EnableSpamProtection = enableSpamProtection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerFacingConfigOutput" /> class.
        /// </summary>
        public CustomerFacingConfigOutput()
        {
        }

    }
}