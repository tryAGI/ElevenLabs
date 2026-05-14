
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateOAuth2ClientCredsRequest
    {
        /// <summary>
        /// Default Value: oauth2_client_credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public string? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_params")]
        public global::System.Collections.Generic.Dictionary<string, string>? ExtraParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic_auth_in_header")]
        public bool? BasicAuthInHeader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOAuth2ClientCredsRequest" /> class.
        /// </summary>
        /// <param name="authType">
        /// Default Value: oauth2_client_credentials
        /// </param>
        /// <param name="provider"></param>
        /// <param name="clientId"></param>
        /// <param name="scopes"></param>
        /// <param name="extraParams"></param>
        /// <param name="basicAuthInHeader"></param>
        /// <param name="clientSecret"></param>
        /// <param name="customHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOAuth2ClientCredsRequest(
            string? authType,
            string? provider,
            string? clientId,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.Dictionary<string, string>? extraParams,
            bool? basicAuthInHeader,
            string? clientSecret,
            global::System.Collections.Generic.Dictionary<string, string>? customHeaders)
        {
            this.AuthType = authType;
            this.Provider = provider;
            this.ClientId = clientId;
            this.Scopes = scopes;
            this.ExtraParams = extraParams;
            this.BasicAuthInHeader = basicAuthInHeader;
            this.ClientSecret = clientSecret;
            this.CustomHeaders = customHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOAuth2ClientCredsRequest" /> class.
        /// </summary>
        public UpdateOAuth2ClientCredsRequest()
        {
        }

    }
}