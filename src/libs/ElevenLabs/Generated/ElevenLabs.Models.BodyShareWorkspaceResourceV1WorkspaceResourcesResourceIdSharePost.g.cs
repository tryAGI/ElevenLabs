
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost
    {
        /// <summary>
        /// Role to grant to the target: one of 'admin', 'editor', 'commenter', or 'viewer'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole Role { get; set; }

        /// <summary>
        /// Resource type of the target resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.WorkspaceResourceType ResourceType { get; set; }

        /// <summary>
        /// The email of the user or service account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// The ID of the target group. Use 'default' to set the resource's baseline role — every workspace member receives this role unless they hold a higher one through a direct user grant, group membership, or workspace (service account) API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// The ID of the target workspace (service account) API key. This is not the API key string itself that you pass in the header for authentication — it is the key's ID, which workspace admins can find under Developers → Service Accounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_api_key_id")]
        public string? WorkspaceApiKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost" /> class.
        /// </summary>
        /// <param name="role">
        /// Role to grant to the target: one of 'admin', 'editor', 'commenter', or 'viewer'.
        /// </param>
        /// <param name="resourceType">
        /// Resource type of the target resource.
        /// </param>
        /// <param name="userEmail">
        /// The email of the user or service account.
        /// </param>
        /// <param name="groupId">
        /// The ID of the target group. Use 'default' to set the resource's baseline role — every workspace member receives this role unless they hold a higher one through a direct user grant, group membership, or workspace (service account) API key.
        /// </param>
        /// <param name="workspaceApiKeyId">
        /// The ID of the target workspace (service account) API key. This is not the API key string itself that you pass in the header for authentication — it is the key's ID, which workspace admins can find under Developers → Service Accounts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost(
            global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole role,
            global::ElevenLabs.WorkspaceResourceType resourceType,
            string? userEmail,
            string? groupId,
            string? workspaceApiKeyId)
        {
            this.Role = role;
            this.ResourceType = resourceType;
            this.UserEmail = userEmail;
            this.GroupId = groupId;
            this.WorkspaceApiKeyId = workspaceApiKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost" /> class.
        /// </summary>
        public BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost()
        {
        }

    }
}