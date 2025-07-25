
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Configuration for a webhook that will be called by an LLM tool.
    /// </summary>
    public sealed partial class WebhookToolApiSchemaConfigInput
    {
        /// <summary>
        /// The URL that the webhook will be sent to. May include path parameters, e.g. https://example.com/agents/{agent_id}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The HTTP method to use for the webhook<br/>
        /// Default Value: GET
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodJsonConverter))]
        public global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod? Method { get; set; }

        /// <summary>
        /// Schema for path parameters, if any. The keys should match the placeholders in the URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path_params_schema")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? PathParamsSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_params_schema")]
        public global::ElevenLabs.QueryParamsJsonSchema? QueryParamsSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body_schema")]
        public global::ElevenLabs.ObjectJsonSchemaPropertyInput? RequestBodySchema { get; set; }

        /// <summary>
        /// Headers that should be included in the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// Used to reference an auth connection from the workspace's auth connection store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_connection")]
        public global::ElevenLabs.AuthConnectionLocator? AuthConnection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolApiSchemaConfigInput" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL that the webhook will be sent to. May include path parameters, e.g. https://example.com/agents/{agent_id}
        /// </param>
        /// <param name="method">
        /// The HTTP method to use for the webhook<br/>
        /// Default Value: GET
        /// </param>
        /// <param name="pathParamsSchema">
        /// Schema for path parameters, if any. The keys should match the placeholders in the URL.
        /// </param>
        /// <param name="queryParamsSchema"></param>
        /// <param name="requestBodySchema"></param>
        /// <param name="requestHeaders">
        /// Headers that should be included in the request
        /// </param>
        /// <param name="authConnection">
        /// Used to reference an auth connection from the workspace's auth connection store.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookToolApiSchemaConfigInput(
            string url,
            global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod? method,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? pathParamsSchema,
            global::ElevenLabs.QueryParamsJsonSchema? queryParamsSchema,
            global::ElevenLabs.ObjectJsonSchemaPropertyInput? requestBodySchema,
            object? requestHeaders,
            global::ElevenLabs.AuthConnectionLocator? authConnection)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
            this.PathParamsSchema = pathParamsSchema;
            this.QueryParamsSchema = queryParamsSchema;
            this.RequestBodySchema = requestBodySchema;
            this.RequestHeaders = requestHeaders;
            this.AuthConnection = authConnection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolApiSchemaConfigInput" /> class.
        /// </summary>
        public WebhookToolApiSchemaConfigInput()
        {
        }
    }
}