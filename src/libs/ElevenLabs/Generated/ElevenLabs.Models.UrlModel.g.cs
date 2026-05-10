
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// OCSF URL object.<br/>
    /// Spec: https://schema.ocsf.io/1.6.0/objects/url
    /// </summary>
    public sealed partial class UrlModel
    {
        /// <summary>
        /// Full URL string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_string")]
        public string? UrlString { get; set; }

        /// <summary>
        /// URL scheme (e.g., https)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheme")]
        public string? Scheme { get; set; }

        /// <summary>
        /// URL hostname
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// URL port
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public int? Port { get; set; }

        /// <summary>
        /// URL path
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// URL query string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_string")]
        public string? QueryString { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlModel" /> class.
        /// </summary>
        /// <param name="urlString">
        /// Full URL string
        /// </param>
        /// <param name="scheme">
        /// URL scheme (e.g., https)
        /// </param>
        /// <param name="hostname">
        /// URL hostname
        /// </param>
        /// <param name="port">
        /// URL port
        /// </param>
        /// <param name="path">
        /// URL path
        /// </param>
        /// <param name="queryString">
        /// URL query string
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UrlModel(
            string? urlString,
            string? scheme,
            string? hostname,
            int? port,
            string? path,
            string? queryString)
        {
            this.UrlString = urlString;
            this.Scheme = scheme;
            this.Hostname = hostname;
            this.Port = port;
            this.Path = path;
            this.QueryString = queryString;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlModel" /> class.
        /// </summary>
        public UrlModel()
        {
        }

    }
}