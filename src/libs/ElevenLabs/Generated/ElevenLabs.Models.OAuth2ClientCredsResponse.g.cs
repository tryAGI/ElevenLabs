
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response model for oauth2 client creds
    /// </summary>
    public sealed partial class OAuth2ClientCredsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: oauth2_client_credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public string? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenUrl { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_params")]
        public global::System.Collections.Generic.Dictionary<string, string>? ExtraParams { get; set; }

        /// <summary>
        /// If True, send client credentials in Authorization header as Basic Auth instead of request body<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic_auth_in_header")]
        public bool? BasicAuthInHeader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_by")]
        public global::ElevenLabs.AuthConnectionDependencies? UsedBy { get; set; }

        /// <summary>
        /// Custom headers configured for OAuth2 token requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2ClientCredsResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="clientId"></param>
        /// <param name="tokenUrl"></param>
        /// <param name="id"></param>
        /// <param name="authType">
        /// Default Value: oauth2_client_credentials
        /// </param>
        /// <param name="scopes">
        /// Default Value: []
        /// </param>
        /// <param name="extraParams">
        /// Default Value: {}
        /// </param>
        /// <param name="basicAuthInHeader">
        /// If True, send client credentials in Authorization header as Basic Auth instead of request body<br/>
        /// Default Value: false
        /// </param>
        /// <param name="usedBy"></param>
        /// <param name="customHeaders">
        /// Custom headers configured for OAuth2 token requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuth2ClientCredsResponse(
            string name,
            string provider,
            string clientId,
            string tokenUrl,
            string id,
            string? authType,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.Dictionary<string, string>? extraParams,
            bool? basicAuthInHeader,
            global::ElevenLabs.AuthConnectionDependencies? usedBy,
            global::System.Collections.Generic.Dictionary<string, string>? customHeaders)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthType = authType;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.Scopes = scopes;
            this.ExtraParams = extraParams;
            this.BasicAuthInHeader = basicAuthInHeader;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UsedBy = usedBy;
            this.CustomHeaders = customHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2ClientCredsResponse" /> class.
        /// </summary>
        public OAuth2ClientCredsResponse()
        {
        }

    }
}