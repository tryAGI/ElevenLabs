
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request model for creating OAuth2 JWT auth connections - inherits common settings and includes sensitive fields
    /// </summary>
    public sealed partial class CreateOAuth2JWTRequest
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmJsonConverter))]
        public global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm? Algorithm { get; set; }

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
        /// Token field to extract from the token endpoint response.<br/>
        /// Default Value: access_token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_response_field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldJsonConverter))]
        public global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField? TokenResponseField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOAuth2JWTRequest" /> class.
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
        /// <param name="secretKey"></param>
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
        /// <param name="tokenResponseField">
        /// Token field to extract from the token endpoint response.<br/>
        /// Default Value: access_token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOAuth2JWTRequest(
            string name,
            string provider,
            string issuer,
            string audience,
            string subject,
            string tokenUrl,
            string secretKey,
            string? authType,
            global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm? algorithm,
            string? keyId,
            int? expirationSeconds,
            global::System.Collections.Generic.Dictionary<string, string>? extraParams,
            global::System.Collections.Generic.IList<string>? scopes,
            global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField? tokenResponseField)
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
            this.TokenResponseField = tokenResponseField;
            this.SecretKey = secretKey ?? throw new global::System.ArgumentNullException(nameof(secretKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOAuth2JWTRequest" /> class.
        /// </summary>
        public CreateOAuth2JWTRequest()
        {
        }
    }
}