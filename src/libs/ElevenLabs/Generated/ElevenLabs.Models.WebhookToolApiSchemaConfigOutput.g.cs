
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Configuration for a webhook that will be called by an LLM tool.
    /// </summary>
    public sealed partial class WebhookToolApiSchemaConfigOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Default Value: GET
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter))]
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod? Method { get; set; }

        /// <summary>
        /// 
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
        public global::ElevenLabs.ObjectJsonSchemaPropertyOutput? RequestBodySchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolApiSchemaConfigOutput" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="method">
        /// Default Value: GET
        /// </param>
        /// <param name="pathParamsSchema"></param>
        /// <param name="queryParamsSchema"></param>
        /// <param name="requestBodySchema"></param>
        /// <param name="requestHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookToolApiSchemaConfigOutput(
            string url,
            global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod? method,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? pathParamsSchema,
            global::ElevenLabs.QueryParamsJsonSchema? queryParamsSchema,
            global::ElevenLabs.ObjectJsonSchemaPropertyOutput? requestBodySchema,
            object? requestHeaders)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
            this.PathParamsSchema = pathParamsSchema;
            this.QueryParamsSchema = queryParamsSchema;
            this.RequestBodySchema = requestBodySchema;
            this.RequestHeaders = requestHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolApiSchemaConfigOutput" /> class.
        /// </summary>
        public WebhookToolApiSchemaConfigOutput()
        {
        }
    }
}