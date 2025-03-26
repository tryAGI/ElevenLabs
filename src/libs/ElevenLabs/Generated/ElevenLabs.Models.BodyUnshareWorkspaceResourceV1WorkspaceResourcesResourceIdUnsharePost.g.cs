
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost
    {
        /// <summary>
        /// Resource types that can be shared in the workspace. The name always need to match the collection names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.WorkspaceResourceType ResourceType { get; set; }

        /// <summary>
        /// The email of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// The ID of the target group. To target the permissions principals have by default on this resource, use the value 'default'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// The ID of the target workspace API key. This isn't the same as the key itself that would you pass in the header for authentication. Workspace admins can find this in the workspace settings UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_api_key_id")]
        public string? WorkspaceApiKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// Resource types that can be shared in the workspace. The name always need to match the collection names
        /// </param>
        /// <param name="userEmail">
        /// The email of the user
        /// </param>
        /// <param name="groupId">
        /// The ID of the target group. To target the permissions principals have by default on this resource, use the value 'default'.
        /// </param>
        /// <param name="workspaceApiKeyId">
        /// The ID of the target workspace API key. This isn't the same as the key itself that would you pass in the header for authentication. Workspace admins can find this in the workspace settings UI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost(
            global::ElevenLabs.WorkspaceResourceType resourceType,
            string? userEmail,
            string? groupId,
            string? workspaceApiKeyId)
        {
            this.ResourceType = resourceType;
            this.UserEmail = userEmail;
            this.GroupId = groupId;
            this.WorkspaceApiKeyId = workspaceApiKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost" /> class.
        /// </summary>
        public BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost()
        {
        }
    }
}