
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// HTTP request details.<br/>
    /// Spec: https://schema.ocsf.io/1.6.0/objects/http_request
    /// </summary>
    public sealed partial class HttpRequestModel
    {
        /// <summary>
        /// HTTP method (GET, POST, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HttpMethod { get; set; }

        /// <summary>
        /// Request URL object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.UrlModel Url { get; set; }

        /// <summary>
        /// User agent string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// X-Forwarded-For header as a list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_forwarded_for")]
        public global::System.Collections.Generic.IList<string>? XForwardedFor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestModel" /> class.
        /// </summary>
        /// <param name="httpMethod">
        /// HTTP method (GET, POST, etc.)
        /// </param>
        /// <param name="url">
        /// Request URL object
        /// </param>
        /// <param name="userAgent">
        /// User agent string
        /// </param>
        /// <param name="xForwardedFor">
        /// X-Forwarded-For header as a list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HttpRequestModel(
            string httpMethod,
            global::ElevenLabs.UrlModel url,
            string? userAgent,
            global::System.Collections.Generic.IList<string>? xForwardedFor)
        {
            this.HttpMethod = httpMethod ?? throw new global::System.ArgumentNullException(nameof(httpMethod));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.UserAgent = userAgent;
            this.XForwardedFor = xForwardedFor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestModel" /> class.
        /// </summary>
        public HttpRequestModel()
        {
        }

    }
}