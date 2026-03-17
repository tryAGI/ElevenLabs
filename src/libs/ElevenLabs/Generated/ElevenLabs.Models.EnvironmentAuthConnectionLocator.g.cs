
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// References an environment variable of type 'auth_connection' by label.<br/>
    /// At runtime, resolves to the auth connection for the current environment,<br/>
    /// falling back to the default environment.
    /// </summary>
    public sealed partial class EnvironmentAuthConnectionLocator
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
        /// Initializes a new instance of the <see cref="EnvironmentAuthConnectionLocator" /> class.
        /// </summary>
        /// <param name="envVarLabel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentAuthConnectionLocator(
            string envVarLabel)
        {
            this.EnvVarLabel = envVarLabel ?? throw new global::System.ArgumentNullException(nameof(envVarLabel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentAuthConnectionLocator" /> class.
        /// </summary>
        public EnvironmentAuthConnectionLocator()
        {
        }
    }
}