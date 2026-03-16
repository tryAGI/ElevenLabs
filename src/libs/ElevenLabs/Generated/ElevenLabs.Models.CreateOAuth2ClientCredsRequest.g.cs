
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request model for creating auth connections - inherits common settings and includes sensitive fields
    /// </summary>
    public sealed partial class CreateOAuth2ClientCredsRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOAuth2ClientCredsRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="authType">
        /// Default Value: oauth2_client_credentials
        /// </param>
        /// <param name="provider"></param>
        /// <param name="clientId"></param>
        /// <param name="tokenUrl"></param>
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
        /// <param name="clientSecret"></param>
        /// <param name="customHeaders">
        /// Default Value: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOAuth2ClientCredsRequest(
            string name,
            string provider,
            string clientId,
            string tokenUrl,
            string clientSecret,
            string? authType,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.Dictionary<string, string>? extraParams,
            bool? basicAuthInHeader,
            global::System.Collections.Generic.Dictionary<string, string>? customHeaders)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.AuthType = authType;
            this.Scopes = scopes;
            this.ExtraParams = extraParams;
            this.BasicAuthInHeader = basicAuthInHeader;
            this.CustomHeaders = customHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOAuth2ClientCredsRequest" /> class.
        /// </summary>
        public CreateOAuth2ClientCredsRequest()
        {
        }
    }
}