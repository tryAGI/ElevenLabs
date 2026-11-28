
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubagentConfigOutput
    {
        /// <summary>
        /// Agents this agent can hand a single turn to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SubAgentOutput>? Agents { get; set; }

        /// <summary>
        /// Lets this agent hand a single turn to a fresh copy of itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_subagent")]
        public global::ElevenLabs.SelfSubagent? SelfSubagent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubagentConfigOutput" /> class.
        /// </summary>
        /// <param name="agents">
        /// Agents this agent can hand a single turn to.
        /// </param>
        /// <param name="selfSubagent">
        /// Lets this agent hand a single turn to a fresh copy of itself.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubagentConfigOutput(
            global::System.Collections.Generic.IList<global::ElevenLabs.SubAgentOutput>? agents,
            global::ElevenLabs.SelfSubagent? selfSubagent)
        {
            this.Agents = agents;
            this.SelfSubagent = selfSubagent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubagentConfigOutput" /> class.
        /// </summary>
        public SubagentConfigOutput()
        {
        }

    }
}