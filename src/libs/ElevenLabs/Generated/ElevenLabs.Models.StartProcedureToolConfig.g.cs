
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StartProcedureToolConfig
    {
        /// <summary>
        /// Default Value: start_procedure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        public string? SystemToolType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("procedures")]
        public object? Procedures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartProcedureToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: start_procedure
        /// </param>
        /// <param name="procedures"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartProcedureToolConfig(
            string? systemToolType,
            object? procedures)
        {
            this.SystemToolType = systemToolType;
            this.Procedures = procedures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartProcedureToolConfig" /> class.
        /// </summary>
        public StartProcedureToolConfig()
        {
        }

    }
}