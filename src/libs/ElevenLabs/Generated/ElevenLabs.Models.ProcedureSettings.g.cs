
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcedureSettings
    {
        /// <summary>
        /// Default Value: llm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compiler_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProcedureCompilerModeJsonConverter))]
        public global::ElevenLabs.ProcedureCompilerMode? CompilerMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureSettings" /> class.
        /// </summary>
        /// <param name="compilerMode">
        /// Default Value: llm
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcedureSettings(
            global::ElevenLabs.ProcedureCompilerMode? compilerMode)
        {
            this.CompilerMode = compilerMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureSettings" /> class.
        /// </summary>
        public ProcedureSettings()
        {
        }
    }
}