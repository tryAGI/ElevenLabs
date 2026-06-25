
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response model for the internal Slack BYO bot auth connection.
    /// </summary>
    public sealed partial class SlackBotAuthResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: slack_bot_auth
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public string? AuthType { get; set; }

        /// <summary>
        /// Default Value: Slack
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

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
        /// Initializes a new instance of the <see cref="SlackBotAuthResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="authType">
        /// Default Value: slack_bot_auth
        /// </param>
        /// <param name="provider">
        /// Default Value: Slack
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
        public SlackBotAuthResponse(
            string name,
            string id,
            string? authType,
            string? provider,
            global::ElevenLabs.AuthConnectionDependencies? usedBy,
            global::ElevenLabs.AuthConnectionStatus? status,
            string? statusDetail,
            string? statusUpdatedAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthType = authType;
            this.Provider = provider;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UsedBy = usedBy;
            this.Status = status;
            this.StatusDetail = statusDetail;
            this.StatusUpdatedAt = statusUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackBotAuthResponse" /> class.
        /// </summary>
        public SlackBotAuthResponse()
        {
        }

    }
}