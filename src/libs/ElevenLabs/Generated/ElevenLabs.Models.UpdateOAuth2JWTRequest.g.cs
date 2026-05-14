
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateOAuth2JWTRequest
    {
        /// <summary>
        /// Default Value: oauth2_jwt
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
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        public global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm2? Algorithm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        public string? KeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_seconds")]
        public int? ExpirationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_params")]
        public global::System.Collections.Generic.Dictionary<string, string>? ExtraParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_response_field")]
        public global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField2? TokenResponseField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_key")]
        public string? SecretKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOAuth2JWTRequest" /> class.
        /// </summary>
        /// <param name="authType">
        /// Default Value: oauth2_jwt
        /// </param>
        /// <param name="provider"></param>
        /// <param name="algorithm"></param>
        /// <param name="keyId"></param>
        /// <param name="issuer"></param>
        /// <param name="audience"></param>
        /// <param name="subject"></param>
        /// <param name="expirationSeconds"></param>
        /// <param name="extraParams"></param>
        /// <param name="scopes"></param>
        /// <param name="tokenResponseField"></param>
        /// <param name="secretKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOAuth2JWTRequest(
            string? authType,
            string? provider,
            global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm2? algorithm,
            string? keyId,
            string? issuer,
            string? audience,
            string? subject,
            int? expirationSeconds,
            global::System.Collections.Generic.Dictionary<string, string>? extraParams,
            global::System.Collections.Generic.IList<string>? scopes,
            global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField2? tokenResponseField,
            string? secretKey)
        {
            this.AuthType = authType;
            this.Provider = provider;
            this.Algorithm = algorithm;
            this.KeyId = keyId;
            this.Issuer = issuer;
            this.Audience = audience;
            this.Subject = subject;
            this.ExpirationSeconds = expirationSeconds;
            this.ExtraParams = extraParams;
            this.Scopes = scopes;
            this.TokenResponseField = tokenResponseField;
            this.SecretKey = secretKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOAuth2JWTRequest" /> class.
        /// </summary>
        public UpdateOAuth2JWTRequest()
        {
        }

    }
}