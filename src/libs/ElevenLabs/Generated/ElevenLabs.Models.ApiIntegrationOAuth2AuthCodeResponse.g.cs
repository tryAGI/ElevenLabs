
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response model for integration-managed OAuth2 Auth Code auth connections
    /// </summary>
    public sealed partial class ApiIntegrationOAuth2AuthCodeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: api_integration_oauth2_auth_code
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
        [global::System.Text.Json.Serialization.JsonPropertyName("token_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Separator for scopes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope_separator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorJsonConverter))]
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator? ScopeSeparator { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the access token expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CredentialId { get; set; }

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
        /// Single status field shared by every auth type's stored credential.<br/>
        /// OAuth values (``REFRESH_FAILED``, ``REVOKED``) are written by the OAuth<br/>
        /// token-manager refresh path. ``CREDENTIAL_INVALID`` is written by the<br/>
        /// tool execution path when an upstream response matches a credential's<br/>
        /// ``failure_signatures`` entry (Bearer, Basic auth, etc.).<br/>
        /// Default Value: active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AuthConnectionStatusJsonConverter))]
        public global::ElevenLabs.AuthConnectionStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_detail")]
        public string? StatusDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_updated_at")]
        public string? StatusUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationOAuth2AuthCodeResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="tokenUrl"></param>
        /// <param name="expiresAt">
        /// ISO 8601 timestamp of when the access token expires
        /// </param>
        /// <param name="integrationId"></param>
        /// <param name="credentialId"></param>
        /// <param name="id"></param>
        /// <param name="authType">
        /// Default Value: api_integration_oauth2_auth_code
        /// </param>
        /// <param name="scopes"></param>
        /// <param name="scopeSeparator">
        /// Separator for scopes
        /// </param>
        /// <param name="usedBy"></param>
        /// <param name="status">
        /// Single status field shared by every auth type's stored credential.<br/>
        /// OAuth values (``REFRESH_FAILED``, ``REVOKED``) are written by the OAuth<br/>
        /// token-manager refresh path. ``CREDENTIAL_INVALID`` is written by the<br/>
        /// tool execution path when an upstream response matches a credential's<br/>
        /// ``failure_signatures`` entry (Bearer, Basic auth, etc.).<br/>
        /// Default Value: active
        /// </param>
        /// <param name="statusDetail"></param>
        /// <param name="statusUpdatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiIntegrationOAuth2AuthCodeResponse(
            string name,
            string provider,
            string tokenUrl,
            string expiresAt,
            string integrationId,
            string credentialId,
            string id,
            string? authType,
            global::System.Collections.Generic.IList<string>? scopes,
            global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator? scopeSeparator,
            global::ElevenLabs.AuthConnectionDependencies? usedBy,
            global::ElevenLabs.AuthConnectionStatus? status,
            string? statusDetail,
            string? statusUpdatedAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthType = authType;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.Scopes = scopes;
            this.ScopeSeparator = scopeSeparator;
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.CredentialId = credentialId ?? throw new global::System.ArgumentNullException(nameof(credentialId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UsedBy = usedBy;
            this.Status = status;
            this.StatusDetail = statusDetail;
            this.StatusUpdatedAt = statusUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationOAuth2AuthCodeResponse" /> class.
        /// </summary>
        public ApiIntegrationOAuth2AuthCodeResponse()
        {
        }

    }
}