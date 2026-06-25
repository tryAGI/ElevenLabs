
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response model for Custom Header Auth auth connections
    /// </summary>
    public sealed partial class CustomHeaderAuthResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: custom_header_auth
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
        /// The name of the header to use for authentication (e.g., 'x-api-key')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeaderName { get; set; }

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
        /// Initializes a new instance of the <see cref="CustomHeaderAuthResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="headerName">
        /// The name of the header to use for authentication (e.g., 'x-api-key')
        /// </param>
        /// <param name="id"></param>
        /// <param name="authType">
        /// Default Value: custom_header_auth
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
        public CustomHeaderAuthResponse(
            string name,
            string provider,
            string headerName,
            string id,
            string? authType,
            global::ElevenLabs.AuthConnectionDependencies? usedBy,
            global::ElevenLabs.AuthConnectionStatus? status,
            string? statusDetail,
            string? statusUpdatedAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthType = authType;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.HeaderName = headerName ?? throw new global::System.ArgumentNullException(nameof(headerName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UsedBy = usedBy;
            this.Status = status;
            this.StatusDetail = statusDetail;
            this.StatusUpdatedAt = statusUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomHeaderAuthResponse" /> class.
        /// </summary>
        public CustomHeaderAuthResponse()
        {
        }

    }
}