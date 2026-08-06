
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Parameter schema for an integration tool the brain answers itself.<br/>
    /// Unlike ``WebhookToolApiSchemaConfig`` there is no HTTP transport: ``handler``<br/>
    /// receives the LLM's parameters and produces the tool result.
    /// </summary>
    public sealed partial class CustomToolApiSchemaConfig
    {
        /// <summary>
        /// JSON schema for the parameters the LLM provides to this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ObjectJsonSchemaPropertyOutput RequestBodySchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolApiSchemaConfig" /> class.
        /// </summary>
        /// <param name="requestBodySchema">
        /// JSON schema for the parameters the LLM provides to this tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolApiSchemaConfig(
            global::ElevenLabs.ObjectJsonSchemaPropertyOutput requestBodySchema)
        {
            this.RequestBodySchema = requestBodySchema ?? throw new global::System.ArgumentNullException(nameof(requestBodySchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolApiSchemaConfig" /> class.
        /// </summary>
        public CustomToolApiSchemaConfig()
        {
        }

    }
}