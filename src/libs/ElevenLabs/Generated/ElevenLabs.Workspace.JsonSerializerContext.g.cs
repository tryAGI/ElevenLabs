
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<bool?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed?>), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableA_b4904817606742f2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit?, object>), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrency_e31f214f80941c25")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit?, object>), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLi_d9395579f1fbd7ab")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateBearerAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>), TypeInfoPropertyName = "CreateMTLSAuthRequest_bba5e3e4c26f6b46")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?>?), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions_11860bbba1af83bb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?, object>?), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit_obj_736b26f766ef46a6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<bool?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed?>?), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableA_218fc888e8ab8453")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit?, object>?), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimi_d839658101c6e5b4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit?, object>?), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrency_65e809d5305d8290")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit?, object>?), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLi_70c6537f90df263e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateBearerAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>?), TypeInfoPropertyName = "CreateMTLSAuthRequest_d3123ae541f7c02c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ActorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UserModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddWorkspaceGroupMemberResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddWorkspaceInviteResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator), TypeInfoPropertyName = "ApiIntegrationOAuth2AuthCodeResponseScopeSeparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependencies))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionStatus), TypeInfoPropertyName = "AuthConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator), TypeInfoPropertyName = "ApiIntegrationOAuth2CustomAppResponseScopeSeparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem), TypeInfoPropertyName = "ToolsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableToolIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentUnknownToolIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType), TypeInfoPropertyName = "AuthConnectionDependenciesToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.McpServersItem), TypeInfoPropertyName = "McpServersItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentUnknownMCPServerIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType), TypeInfoPropertyName = "AuthConnectionDependenciesMcpServerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentIntegrationConnectionIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentIntegrationConnectionIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BasicAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BearerAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookHMACSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDeleteExistingInvitationV1WorkspaceInvitesDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SeatType), TypeInfoPropertyName = "SeatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyInviteUserV1WorkspaceInvitesAddPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySetWorkspaceThirdPartyDisablingPolicyV1WorkspacesApiKeysThirdPartyDisablingPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole), TypeInfoPropertyName = "BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceResourceType), TypeInfoPropertyName = "WorkspaceResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceWebhookEventType), TypeInfoPropertyName = "WorkspaceWebhookEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>), TypeInfoPropertyName = "AnyOfIListPermissionTypeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PermissionType), TypeInfoPropertyName = "PermissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateServiceAccountV1ServiceAccountsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DefaultSharingGroupConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<bool?, string>), TypeInfoPropertyName = "AnyOfBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?>), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions_71e98ef04d3922c0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?, object>), TypeInfoPropertyName = "AnyOfInt32BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimitObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>), TypeInfoPropertyName = "AnyOfIListStringBodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit?, object>), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimi_ef7a0bbe85d5364e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ComputedUsagePlatformLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem2), TypeInfoPropertyName = "ToolsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.McpServersItem2), TypeInfoPropertyName = "McpServersItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateBasicAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateBearerAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateCustomHeaderAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateMTLSAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2ClientCredsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2JWTRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm), TypeInfoPropertyName = "CreateOAuth2JWTRequestAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField), TypeInfoPropertyName = "CreateOAuth2JWTRequestTokenResponseField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatePrivateKeyJWTRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm), TypeInfoPropertyName = "CreatePrivateKeyJWTRequestAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomHeaderAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel), TypeInfoPropertyName = "DefaultSharingGroupConfigPermissionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DefaultSharingGroupResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceGroupResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel), TypeInfoPropertyName = "DefaultSharingGroupResponseModelPermissionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteWorkspaceGroupMemberResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteWorkspaceInviteResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteWorkspaceWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel), TypeInfoPropertyName = "DependentAvailableMCPServerIdentifierAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel), TypeInfoPropertyName = "DependentAvailableToolIdentifierAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeviceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependenciesVariant1Item), TypeInfoPropertyName = "DependenciesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HttpRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UrlModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAuthConnectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AuthConnectionsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionsItem), TypeInfoPropertyName = "AuthConnectionsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2ClientCredsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RefreshTokenAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2JWTResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PrivateKeyJWTResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MTLSAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SlackBotAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UrlSecretAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType), TypeInfoPropertyName = "ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LockReason), TypeInfoPropertyName = "LockReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2JWTResponseAlgorithm), TypeInfoPropertyName = "OAuth2JWTResponseAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2JWTResponseTokenResponseField), TypeInfoPropertyName = "OAuth2JWTResponseTokenResponseField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchWorkspaceWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PlatformLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StoredUsagePlatformLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PrivateKeyJWTResponseAlgorithm), TypeInfoPropertyName = "PrivateKeyJWTResponseAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResourceMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride), TypeInfoPropertyName = "ResourceMetadataResponseModelAnonymousAccessLevelOverride2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ShareOptionResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ShareOptionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ScimGroupResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ShareOptionResponseModelType), TypeInfoPropertyName = "ShareOptionResponseModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateBasicAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateBearerAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateOAuth2ClientCredsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateOAuth2JWTRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm), TypeInfoPropertyName = "UpdateOAuth2JWTRequestAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField), TypeInfoPropertyName = "UpdateOAuth2JWTRequestTokenResponseField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateWorkspaceMemberResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookAuthMethodType), TypeInfoPropertyName = "WebhookAuthMethodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookUsageType), TypeInfoPropertyName = "WebhookUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceApiKeyListResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceApiKeyResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceApiKeyResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceAuditLogEntryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceAuditLogsPageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAuditLogEntryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceCreateApiKeyResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceCreateServiceAccountResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceCreateWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceGroupByNameResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceGroupPermission), TypeInfoPropertyName = "WorkspaceGroupPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, string, object>), TypeInfoPropertyName = "AnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceMemberResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceServiceAccountListResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceServiceAccountResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceServiceAccountResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceWebhookListResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceWebhookUsageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateOAuth2ClientCredsRequest, global::ElevenLabs.UpdateBasicAuthRequest, global::ElevenLabs.UpdateBearerAuthRequest, global::ElevenLabs.UpdateOAuth2JWTRequest>), TypeInfoPropertyName = "AnyOfUpdateOAuth2ClientCredsRequestUpdateBasicAuthRequestUpdateBearerAuthRequestUpdateOAuth2JWTRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionResponse), TypeInfoPropertyName = "CreateAuthConnectionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType), TypeInfoPropertyName = "CreateAuthConnectionResponseDiscriminatorAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAuthConnectionResponse), TypeInfoPropertyName = "UpdateAuthConnectionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAuthConnectionResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType), TypeInfoPropertyName = "UpdateAuthConnectionResponseDiscriminatorAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkspaceGroupResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupByNameResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceMemberResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator?), TypeInfoPropertyName = "NullableApiIntegrationOAuth2AuthCodeResponseScopeSeparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionStatus?), TypeInfoPropertyName = "NullableAuthConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator?), TypeInfoPropertyName = "NullableApiIntegrationOAuth2CustomAppResponseScopeSeparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem?), TypeInfoPropertyName = "NullableToolsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType?), TypeInfoPropertyName = "NullableAuthConnectionDependenciesToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.McpServersItem?), TypeInfoPropertyName = "NullableMcpServersItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType?), TypeInfoPropertyName = "NullableAuthConnectionDependenciesMcpServerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SeatType?), TypeInfoPropertyName = "NullableSeatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole?), TypeInfoPropertyName = "NullableBodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceResourceType?), TypeInfoPropertyName = "NullableWorkspaceResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceWebhookEventType?), TypeInfoPropertyName = "NullableWorkspaceWebhookEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>?), TypeInfoPropertyName = "NullableAnyOfIListPermissionTypeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PermissionType?), TypeInfoPropertyName = "NullablePermissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<bool?, string>?), TypeInfoPropertyName = "NullableAnyOfBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?), TypeInfoPropertyName = "NullableBodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?), TypeInfoPropertyName = "NullableBodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>?), TypeInfoPropertyName = "NullableAnyOfIListStringBodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?), TypeInfoPropertyName = "NullableBodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed?), TypeInfoPropertyName = "NullableBodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit?), TypeInfoPropertyName = "NullableBodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit?), TypeInfoPropertyName = "NullableBodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit?), TypeInfoPropertyName = "NullableBodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem2?), TypeInfoPropertyName = "NullableToolsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.McpServersItem2?), TypeInfoPropertyName = "NullableMcpServersItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm?), TypeInfoPropertyName = "NullableCreateOAuth2JWTRequestAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField?), TypeInfoPropertyName = "NullableCreateOAuth2JWTRequestTokenResponseField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm?), TypeInfoPropertyName = "NullableCreatePrivateKeyJWTRequestAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel?), TypeInfoPropertyName = "NullableDefaultSharingGroupConfigPermissionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel?), TypeInfoPropertyName = "NullableDefaultSharingGroupResponseModelPermissionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel?), TypeInfoPropertyName = "NullableDependentAvailableMCPServerIdentifierAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel?), TypeInfoPropertyName = "NullableDependentAvailableToolIdentifierAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependenciesVariant1Item?), TypeInfoPropertyName = "NullableDependenciesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionsItem?), TypeInfoPropertyName = "NullableAuthConnectionsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType?), TypeInfoPropertyName = "NullableListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LockReason?), TypeInfoPropertyName = "NullableLockReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2JWTResponseAlgorithm?), TypeInfoPropertyName = "NullableOAuth2JWTResponseAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2JWTResponseTokenResponseField?), TypeInfoPropertyName = "NullableOAuth2JWTResponseTokenResponseField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PrivateKeyJWTResponseAlgorithm?), TypeInfoPropertyName = "NullablePrivateKeyJWTResponseAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride?), TypeInfoPropertyName = "NullableResourceMetadataResponseModelAnonymousAccessLevelOverride2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ShareOptionResponseModelType?), TypeInfoPropertyName = "NullableShareOptionResponseModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm?), TypeInfoPropertyName = "NullableUpdateOAuth2JWTRequestAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField?), TypeInfoPropertyName = "NullableUpdateOAuth2JWTRequestTokenResponseField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookAuthMethodType?), TypeInfoPropertyName = "NullableWebhookAuthMethodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookUsageType?), TypeInfoPropertyName = "NullableWebhookUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceGroupPermission?), TypeInfoPropertyName = "NullableWorkspaceGroupPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, string, object>?), TypeInfoPropertyName = "NullableAnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateOAuth2ClientCredsRequest, global::ElevenLabs.UpdateBasicAuthRequest, global::ElevenLabs.UpdateBearerAuthRequest, global::ElevenLabs.UpdateOAuth2JWTRequest>?), TypeInfoPropertyName = "NullableAnyOfUpdateOAuth2ClientCredsRequestUpdateBasicAuthRequestUpdateBearerAuthRequestUpdateOAuth2JWTRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionResponse?), TypeInfoPropertyName = "NullableCreateAuthConnectionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType?), TypeInfoPropertyName = "NullableCreateAuthConnectionResponseDiscriminatorAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAuthConnectionResponse?), TypeInfoPropertyName = "NullableUpdateAuthConnectionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType?), TypeInfoPropertyName = "NullableUpdateAuthConnectionResponseDiscriminatorAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.McpServersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependentIntegrationConnectionIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AuthConnectionsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ShareOptionResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceApiKeyResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAuditLogEntryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceServiceAccountResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupByNameResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceMemberResponseModel>))]
    internal sealed partial class WorkspaceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkspaceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WorkspaceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WorkspaceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.McpServersItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolsItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.McpServersItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependenciesVariant1ItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AuthConnectionsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdateAuthConnectionResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<object>, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, bool?, double?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.DateTime?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateBearerAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.UpdateOAuth2ClientCredsRequest, global::ElevenLabs.UpdateBasicAuthRequest, global::ElevenLabs.UpdateBearerAuthRequest, global::ElevenLabs.UpdateOAuth2JWTRequest>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator)

                    || typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator?)

                    || typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator)

                    || typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator?)

                    || typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.AuthConnectionStatus)

                    || typeToConvert == typeof(global::ElevenLabs.AuthConnectionStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole)

                    || typeToConvert == typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit?)

                    || typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm)

                    || typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm?)

                    || typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField)

                    || typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField?)

                    || typeToConvert == typeof(global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm)

                    || typeToConvert == typeof(global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm?)

                    || typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel)

                    || typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel?)

                    || typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel)

                    || typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel?)

                    || typeToConvert == typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel)

                    || typeToConvert == typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel?)

                    || typeToConvert == typeof(global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel)

                    || typeToConvert == typeof(global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel?)

                    || typeToConvert == typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType)

                    || typeToConvert == typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType?)

                    || typeToConvert == typeof(global::ElevenLabs.LockReason)

                    || typeToConvert == typeof(global::ElevenLabs.LockReason?)

                    || typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseAlgorithm)

                    || typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseAlgorithm?)

                    || typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseTokenResponseField)

                    || typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseTokenResponseField?)

                    || typeToConvert == typeof(global::ElevenLabs.PermissionType)

                    || typeToConvert == typeof(global::ElevenLabs.PermissionType?)

                    || typeToConvert == typeof(global::ElevenLabs.PrivateKeyJWTResponseAlgorithm)

                    || typeToConvert == typeof(global::ElevenLabs.PrivateKeyJWTResponseAlgorithm?)

                    || typeToConvert == typeof(global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride)

                    || typeToConvert == typeof(global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride?)

                    || typeToConvert == typeof(global::ElevenLabs.SeatType)

                    || typeToConvert == typeof(global::ElevenLabs.SeatType?)

                    || typeToConvert == typeof(global::ElevenLabs.ShareOptionResponseModelType)

                    || typeToConvert == typeof(global::ElevenLabs.ShareOptionResponseModelType?)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm?)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField?)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookAuthMethodType)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookAuthMethodType?)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookUsageType)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookUsageType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceGroupPermission)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceGroupPermission?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceResourceType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceResourceType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceWebhookEventType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceWebhookEventType?)

                    || typeToConvert == typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType)

                    || typeToConvert == typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType?)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator))
                {
                    return new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator?))
                {
                    return new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator))
                {
                    return new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator?))
                {
                    return new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthConnectionStatus))
                {
                    return new global::ElevenLabs.JsonConverters.AuthConnectionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthConnectionStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.AuthConnectionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole))
                {
                    return new global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissionsJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowedJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm))
                {
                    return new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm?))
                {
                    return new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField))
                {
                    return new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField?))
                {
                    return new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm))
                {
                    return new global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm?))
                {
                    return new global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel))
                {
                    return new global::ElevenLabs.JsonConverters.DefaultSharingGroupConfigPermissionLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel?))
                {
                    return new global::ElevenLabs.JsonConverters.DefaultSharingGroupConfigPermissionLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel))
                {
                    return new global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel?))
                {
                    return new global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel))
                {
                    return new global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel?))
                {
                    return new global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel))
                {
                    return new global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel?))
                {
                    return new global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType))
                {
                    return new global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType?))
                {
                    return new global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LockReason))
                {
                    return new global::ElevenLabs.JsonConverters.LockReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LockReason?))
                {
                    return new global::ElevenLabs.JsonConverters.LockReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseAlgorithm))
                {
                    return new global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseAlgorithm?))
                {
                    return new global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseTokenResponseField))
                {
                    return new global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseTokenResponseField?))
                {
                    return new global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PermissionType))
                {
                    return new global::ElevenLabs.JsonConverters.PermissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PermissionType?))
                {
                    return new global::ElevenLabs.JsonConverters.PermissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PrivateKeyJWTResponseAlgorithm))
                {
                    return new global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PrivateKeyJWTResponseAlgorithm?))
                {
                    return new global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride))
                {
                    return new global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverrideJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride?))
                {
                    return new global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverrideNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SeatType))
                {
                    return new global::ElevenLabs.JsonConverters.SeatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SeatType?))
                {
                    return new global::ElevenLabs.JsonConverters.SeatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ShareOptionResponseModelType))
                {
                    return new global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ShareOptionResponseModelType?))
                {
                    return new global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateOAuth2JWTRequestAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm?))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateOAuth2JWTRequestAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateOAuth2JWTRequestTokenResponseFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField?))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateOAuth2JWTRequestTokenResponseFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookAuthMethodType))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookAuthMethodType?))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookUsageType))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookUsageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookUsageType?))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookUsageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceGroupPermission))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceGroupPermission?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceResourceType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceResourceType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceWebhookEventType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceWebhookEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceWebhookEventType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceWebhookEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType))
                {
                    return new global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType?))
                {
                    return new global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateAuthConnectionResponseDiscriminatorAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType?))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateAuthConnectionResponseDiscriminatorAuthTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new WorkspaceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}