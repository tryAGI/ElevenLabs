
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Allows the agent to explicitly skip its turn.<br/>
    /// This tool should be invoked by the LLM when the user indicates they would like<br/>
    /// to think or take a short pause before continuing the conversation—e.g. when<br/>
    /// they say: "Give me a second", "Let me think", or "One moment please".  After<br/>
    /// calling this tool, the assistant should not speak until the user speaks<br/>
    /// again, or if wait_timeout_secs is set, until that wait elapses and the<br/>
    /// agent generates a check-in.
    /// </summary>
    public sealed partial class SkipTurnToolConfig
    {
        /// <summary>
        /// Default Value: skip_turn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        public string? SystemToolType { get; set; }

        /// <summary>
        /// Seconds to wait after skip_turn before the agent generates a contextual check-in. The "End conversation after silence" timer is paused during the wait. -1 disables the wait: after skip_turn the agent stays silent until the caller speaks, and that timer keeps running. Applies to voice conversations only.<br/>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_timeout_secs")]
        public double? WaitTimeoutSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipTurnToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: skip_turn
        /// </param>
        /// <param name="waitTimeoutSecs">
        /// Seconds to wait after skip_turn before the agent generates a contextual check-in. The "End conversation after silence" timer is paused during the wait. -1 disables the wait: after skip_turn the agent stays silent until the caller speaks, and that timer keeps running. Applies to voice conversations only.<br/>
        /// Default Value: -1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkipTurnToolConfig(
            string? systemToolType,
            double? waitTimeoutSecs)
        {
            this.SystemToolType = systemToolType;
            this.WaitTimeoutSecs = waitTimeoutSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipTurnToolConfig" /> class.
        /// </summary>
        public SkipTurnToolConfig()
        {
        }

    }
}