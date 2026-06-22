
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch
    {
        /// <summary>
        /// Whether to enable or disable the API key.<br/>
        /// Default Value: no_update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, string>))]
        public global::ElevenLabs.AnyOf<bool?, string>? IsEnabled { get; set; }

        /// <summary>
        /// The name of the XI API key to use (used for identification purposes only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The permissions of the XI API.<br/>
        /// Default Value: no_update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?>))]
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?>? Permissions { get; set; }

        /// <summary>
        /// The character limit of the XI API key. If provided this will limit the usage of this api key to n characters per month where n is the chosen value. Requests that incur charges will fail after reaching this monthly limit.<br/>
        /// Default Value: no_update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_limit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>))]
        public global::ElevenLabs.AnyOf<int?, string, object>? CharacterLimit { get; set; }

        /// <summary>
        /// List of IP addresses or CIDR ranges allowed to use this API key. Each entry may be a CIDR range (e.g. '10.0.0.0/24') or a bare IP address (normalized to /32 or /128). On create, omit or pass null to allow all IPs. On update, omit to leave the whitelist unchanged, or pass "clear" to remove it.<br/>
        /// Default Value: no_update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_ips")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>))]
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>? AllowedIps { get; set; }

        /// <summary>
        /// Whether the holder of this key may disable it via the self-disable endpoint. On create, omit or pass null to use the workspace's default (enabled for non-Enterprise plans, disabled for Enterprise plans). On update, omit to leave it unchanged, or pass "clear" to reset it to the workspace default. Only honored for workspaces with self-disable access enabled.<br/>
        /// Default Value: no_update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("third_party_disable_allowed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed?>))]
        public global::ElevenLabs.AnyOf<bool?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed?>? ThirdPartyDisableAllowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// Whether to enable or disable the API key.<br/>
        /// Default Value: no_update
        /// </param>
        /// <param name="name">
        /// The name of the XI API key to use (used for identification purposes only).
        /// </param>
        /// <param name="permissions">
        /// The permissions of the XI API.<br/>
        /// Default Value: no_update
        /// </param>
        /// <param name="characterLimit">
        /// The character limit of the XI API key. If provided this will limit the usage of this api key to n characters per month where n is the chosen value. Requests that incur charges will fail after reaching this monthly limit.<br/>
        /// Default Value: no_update
        /// </param>
        /// <param name="allowedIps">
        /// List of IP addresses or CIDR ranges allowed to use this API key. Each entry may be a CIDR range (e.g. '10.0.0.0/24') or a bare IP address (normalized to /32 or /128). On create, omit or pass null to allow all IPs. On update, omit to leave the whitelist unchanged, or pass "clear" to remove it.<br/>
        /// Default Value: no_update
        /// </param>
        /// <param name="thirdPartyDisableAllowed">
        /// Whether the holder of this key may disable it via the self-disable endpoint. On create, omit or pass null to use the workspace's default (enabled for non-Enterprise plans, disabled for Enterprise plans). On update, omit to leave it unchanged, or pass "clear" to reset it to the workspace default. Only honored for workspaces with self-disable access enabled.<br/>
        /// Default Value: no_update
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch(
            global::ElevenLabs.AnyOf<bool?, string>? isEnabled,
            string? name,
            global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?>? permissions,
            global::ElevenLabs.AnyOf<int?, string, object>? characterLimit,
            global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>? allowedIps,
            global::ElevenLabs.AnyOf<bool?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed?>? thirdPartyDisableAllowed)
        {
            this.IsEnabled = isEnabled;
            this.Name = name;
            this.Permissions = permissions;
            this.CharacterLimit = characterLimit;
            this.AllowedIps = allowedIps;
            this.ThirdPartyDisableAllowed = thirdPartyDisableAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch" /> class.
        /// </summary>
        public BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch()
        {
        }

    }
}