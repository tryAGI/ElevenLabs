
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceApiKeyResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        public int? CreatedAtUnix { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_disabled")]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_reason")]
        public global::ElevenLabs.LockReason? DisableReason { get; set; }

        /// <summary>
        /// Maximum number of credits allowed in the current billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_limit")]
        public int? CharacterLimit { get; set; }

        /// <summary>
        /// Credits already used in the current billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_count")]
        public int? CharacterCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashed_xi_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HashedXiApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_ips")]
        public global::System.Collections.Generic.IList<string>? AllowedIps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("third_party_disable_allowed")]
        public bool? ThirdPartyDisableAllowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceApiKeyResponseModel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hint"></param>
        /// <param name="keyId"></param>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="hashedXiApiKey"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="isDisabled">
        /// Default Value: false
        /// </param>
        /// <param name="permissions"></param>
        /// <param name="disableReason"></param>
        /// <param name="characterLimit">
        /// Maximum number of credits allowed in the current billing period.
        /// </param>
        /// <param name="characterCount">
        /// Credits already used in the current billing period.
        /// </param>
        /// <param name="allowedIps"></param>
        /// <param name="thirdPartyDisableAllowed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceApiKeyResponseModel(
            string name,
            string hint,
            string keyId,
            string serviceAccountUserId,
            string hashedXiApiKey,
            int? createdAtUnix,
            bool? isDisabled,
            global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>? permissions,
            global::ElevenLabs.LockReason? disableReason,
            int? characterLimit,
            int? characterCount,
            global::System.Collections.Generic.IList<string>? allowedIps,
            bool? thirdPartyDisableAllowed)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Hint = hint ?? throw new global::System.ArgumentNullException(nameof(hint));
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.ServiceAccountUserId = serviceAccountUserId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountUserId));
            this.CreatedAtUnix = createdAtUnix;
            this.IsDisabled = isDisabled;
            this.Permissions = permissions;
            this.DisableReason = disableReason;
            this.CharacterLimit = characterLimit;
            this.CharacterCount = characterCount;
            this.HashedXiApiKey = hashedXiApiKey ?? throw new global::System.ArgumentNullException(nameof(hashedXiApiKey));
            this.AllowedIps = allowedIps;
            this.ThirdPartyDisableAllowed = thirdPartyDisableAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceApiKeyResponseModel" /> class.
        /// </summary>
        public WorkspaceApiKeyResponseModel()
        {
        }

    }
}