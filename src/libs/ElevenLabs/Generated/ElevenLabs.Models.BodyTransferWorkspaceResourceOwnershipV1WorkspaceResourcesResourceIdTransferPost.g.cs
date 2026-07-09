
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyTransferWorkspaceResourceOwnershipV1WorkspaceResourcesResourceIdTransferPost
    {
        /// <summary>
        /// Resource type of the target resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.WorkspaceResourceType ResourceType { get; set; }

        /// <summary>
        /// The ID of the user the resource should be transferred to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTransferWorkspaceResourceOwnershipV1WorkspaceResourcesResourceIdTransferPost" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// Resource type of the target resource.
        /// </param>
        /// <param name="targetUserId">
        /// The ID of the user the resource should be transferred to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyTransferWorkspaceResourceOwnershipV1WorkspaceResourcesResourceIdTransferPost(
            global::ElevenLabs.WorkspaceResourceType resourceType,
            string targetUserId)
        {
            this.ResourceType = resourceType;
            this.TargetUserId = targetUserId ?? throw new global::System.ArgumentNullException(nameof(targetUserId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTransferWorkspaceResourceOwnershipV1WorkspaceResourcesResourceIdTransferPost" /> class.
        /// </summary>
        public BodyTransferWorkspaceResourceOwnershipV1WorkspaceResourcesResourceIdTransferPost()
        {
        }

    }
}