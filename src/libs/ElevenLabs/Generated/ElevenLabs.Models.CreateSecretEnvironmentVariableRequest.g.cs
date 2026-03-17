
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecretEnvironmentVariableRequest
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"secret"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "secret";

        /// <summary>
        /// Unique label for the environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Environment-specific secret references. Must include 'production' key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretEnvironmentVariableRequest" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="label">
        /// Unique label for the environment variable.
        /// </param>
        /// <param name="values">
        /// Environment-specific secret references. Must include 'production' key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSecretEnvironmentVariableRequest(
            string label,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest> values,
            string type = "secret")
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretEnvironmentVariableRequest" /> class.
        /// </summary>
        public CreateSecretEnvironmentVariableRequest()
        {
        }
    }
}