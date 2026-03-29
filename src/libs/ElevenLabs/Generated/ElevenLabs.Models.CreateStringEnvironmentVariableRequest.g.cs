
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStringEnvironmentVariableRequest
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"string"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "string";

        /// <summary>
        /// Unique label for the environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Environment-specific values. Must include 'production' key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStringEnvironmentVariableRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// Unique label for the environment variable.
        /// </param>
        /// <param name="values">
        /// Environment-specific values. Must include 'production' key.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStringEnvironmentVariableRequest(
            string label,
            global::System.Collections.Generic.Dictionary<string, string> values,
            string type = "string")
        {
            this.Type = type;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStringEnvironmentVariableRequest" /> class.
        /// </summary>
        public CreateStringEnvironmentVariableRequest()
        {
        }
    }
}