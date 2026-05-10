
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Execution-related properties for a tool.
    /// </summary>
    public sealed partial class ToolExecution2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskSupport")]
        public global::ElevenLabs.ToolExecutionTaskSupport2? TaskSupport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolExecution2" /> class.
        /// </summary>
        /// <param name="taskSupport"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolExecution2(
            global::ElevenLabs.ToolExecutionTaskSupport2? taskSupport)
        {
            this.TaskSupport = taskSupport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolExecution2" /> class.
        /// </summary>
        public ToolExecution2()
        {
        }

    }
}