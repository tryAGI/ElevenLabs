
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A whitelist of fields that can be overridden by users when<br/>
    /// configuring an API Integration Webhook Tool.
    /// </summary>
    public sealed partial class ApiIntegrationWebhookOverrides
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_overrides")]
        public object? SchemaOverrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_filter_mode")]
        public global::ElevenLabs.ResponseFilterMode? ResponseFilterMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_filters")]
        public global::System.Collections.Generic.IList<string>? ResponseFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationWebhookOverrides" /> class.
        /// </summary>
        /// <param name="schemaOverrides"></param>
        /// <param name="requestHeaders"></param>
        /// <param name="responseFilterMode"></param>
        /// <param name="responseFilters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiIntegrationWebhookOverrides(
            object? schemaOverrides,
            object? requestHeaders,
            global::ElevenLabs.ResponseFilterMode? responseFilterMode,
            global::System.Collections.Generic.IList<string>? responseFilters)
        {
            this.SchemaOverrides = schemaOverrides;
            this.RequestHeaders = requestHeaders;
            this.ResponseFilterMode = responseFilterMode;
            this.ResponseFilters = responseFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationWebhookOverrides" /> class.
        /// </summary>
        public ApiIntegrationWebhookOverrides()
        {
        }

    }
}