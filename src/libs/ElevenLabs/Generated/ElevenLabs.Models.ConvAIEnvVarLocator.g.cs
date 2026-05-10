
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Used to reference an environment variable by label.
    /// </summary>
    public sealed partial class ConvAIEnvVarLocator
    {
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
        /// Initializes a new instance of the <see cref="ConvAIEnvVarLocator" /> class.
        /// </summary>
        /// <param name="envVarLabel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvAIEnvVarLocator(
            string envVarLabel)
        {
            this.EnvVarLabel = envVarLabel ?? throw new global::System.ArgumentNullException(nameof(envVarLabel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIEnvVarLocator" /> class.
        /// </summary>
        public ConvAIEnvVarLocator()
        {
        }

    }
}