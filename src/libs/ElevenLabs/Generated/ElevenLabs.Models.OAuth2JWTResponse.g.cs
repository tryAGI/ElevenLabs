
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response model for OAuth2 JWT auth connections
    /// </summary>
    public sealed partial class OAuth2JWTResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: oauth2_jwt
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
        /// JWT signing algorithm<br/>
        /// Default Value: HS256
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmJsonConverter))]
        public global::ElevenLabs.OAuth2JWTResponseAlgorithm? Algorithm { get; set; }

        /// <summary>
        /// Key ID (kid) for JWT header - useful for key rotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        public string? KeyId { get; set; }

        /// <summary>
        /// JWT issuer (iss claim)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Issuer { get; set; }

        /// <summary>
        /// JWT audience (aud claim)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audience { get; set; }

        /// <summary>
        /// JWT subject (sub claim)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        /// Token expiration time in seconds<br/>
        /// Default Value: 3600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_seconds")]
        public int? ExpirationSeconds { get; set; }

        /// <summary>
        /// Additional custom claims to include in the JWT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_params")]
        public global::System.Collections.Generic.Dictionary<string, string>? ExtraParams { get; set; }

        /// <summary>
        /// Token endpoint URL for exchanging JWT for access token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenUrl { get; set; }

        /// <summary>
        /// OAuth2 scopes to request when exchanging JWT for access token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2JWTResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="issuer">
        /// JWT issuer (iss claim)
        /// </param>
        /// <param name="audience">
        /// JWT audience (aud claim)
        /// </param>
        /// <param name="subject">
        /// JWT subject (sub claim)
        /// </param>
        /// <param name="tokenUrl">
        /// Token endpoint URL for exchanging JWT for access token
        /// </param>
        /// <param name="id"></param>
        /// <param name="authType">
        /// Default Value: oauth2_jwt
        /// </param>
        /// <param name="algorithm">
        /// JWT signing algorithm<br/>
        /// Default Value: HS256
        /// </param>
        /// <param name="keyId">
        /// Key ID (kid) for JWT header - useful for key rotation
        /// </param>
        /// <param name="expirationSeconds">
        /// Token expiration time in seconds<br/>
        /// Default Value: 3600
        /// </param>
        /// <param name="extraParams">
        /// Additional custom claims to include in the JWT
        /// </param>
        /// <param name="scopes">
        /// OAuth2 scopes to request when exchanging JWT for access token
        /// </param>
        /// <param name="usedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuth2JWTResponse(
            string name,
            string provider,
            string issuer,
            string audience,
            string subject,
            string tokenUrl,
            string id,
            string? authType,
            global::ElevenLabs.OAuth2JWTResponseAlgorithm? algorithm,
            string? keyId,
            int? expirationSeconds,
            global::System.Collections.Generic.Dictionary<string, string>? extraParams,
            global::System.Collections.Generic.IList<string>? scopes,
            global::ElevenLabs.AuthConnectionDependencies? usedBy)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthType = authType;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Algorithm = algorithm;
            this.KeyId = keyId;
            this.Issuer = issuer ?? throw new global::System.ArgumentNullException(nameof(issuer));
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.ExpirationSeconds = expirationSeconds;
            this.ExtraParams = extraParams;
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.Scopes = scopes;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UsedBy = usedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2JWTResponse" /> class.
        /// </summary>
        public OAuth2JWTResponse()
        {
        }
    }
}