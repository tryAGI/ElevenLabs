
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunSubagentToolConfigOutput
    {
        /// <summary>
        /// Default Value: run_subagent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        public string? SystemToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.SubAgentOutput> Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSubagentToolConfigOutput" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="systemToolType">
        /// Default Value: run_subagent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunSubagentToolConfigOutput(
            global::System.Collections.Generic.IList<global::ElevenLabs.SubAgentOutput> agents,
            string? systemToolType)
        {
            this.SystemToolType = systemToolType;
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSubagentToolConfigOutput" /> class.
        /// </summary>
        public RunSubagentToolConfigOutput()
        {
        }

    }
}