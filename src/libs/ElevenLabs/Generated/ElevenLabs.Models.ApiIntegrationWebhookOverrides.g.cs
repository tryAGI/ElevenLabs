
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
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
        [global::System.Text.Json.Serialization.JsonPropertyName("response_filter_mode")]
        public global::ElevenLabs.ResponseFilterMode? ResponseFilterMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_filters")]
        public global::System.Collections.Generic.IList<string>? ResponseFilters { get; set; }

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
        /// Initializes a new instance of the <see cref="ApiIntegrationWebhookOverrides" /> class.
        /// </summary>
        /// <param name="schemaOverrides"></param>
        /// <param name="responseFilterMode"></param>
        /// <param name="responseFilters"></param>
        /// <param name="requestHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiIntegrationWebhookOverrides(
            object? schemaOverrides,
            global::ElevenLabs.ResponseFilterMode? responseFilterMode,
            global::System.Collections.Generic.IList<string>? responseFilters,
            object? requestHeaders)
        {
            this.SchemaOverrides = schemaOverrides;
            this.ResponseFilterMode = responseFilterMode;
            this.ResponseFilters = responseFilters;
            this.RequestHeaders = requestHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationWebhookOverrides" /> class.
        /// </summary>
        public ApiIntegrationWebhookOverrides()
        {
        }

    }
}