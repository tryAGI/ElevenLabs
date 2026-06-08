
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeToolContextVariable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env_var_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvVarLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeToolContextVariable" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="envVarLabel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeToolContextVariable(
            string name,
            string envVarLabel)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.EnvVarLabel = envVarLabel ?? throw new global::System.ArgumentNullException(nameof(envVarLabel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeToolContextVariable" /> class.
        /// </summary>
        public CodeToolContextVariable()
        {
        }

    }
}