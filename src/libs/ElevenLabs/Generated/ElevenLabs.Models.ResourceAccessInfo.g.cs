
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"access_source":"creator","creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
    /// </summary>
    public sealed partial class ResourceAccessInfo
    {
        /// <summary>
        /// Whether the user making the request is the creator of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCreator { get; set; }

        /// <summary>
        /// Name of the agent's creator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatorName { get; set; }

        /// <summary>
        /// Email of the agent's creator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatorEmail { get; set; }

        /// <summary>
        /// The role of the user making the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ResourceAccessInfoRole Role { get; set; }

        /// <summary>
        /// The access level for anonymous users. If None, the resource is not shared publicly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anonymous_access_level_override")]
        public global::ElevenLabs.ResourceAccessInfoAnonymousAccessLevelOverride2? AnonymousAccessLevelOverride { get; set; }

        /// <summary>
        /// Why the requesting user has access to this resource. 'creator' = caller is the owner. 'explicit' = caller (or one of their workspace groups) is listed in role_to_group_ids beyond the workspace-wide everyone group. 'workspace_default' = the workspace-wide everyone group is listed in role_to_group_ids (every non-anon workspace member, including admins, sees this resource). 'workspace_admin' = caller is a workspace admin and the admin seat is the *only* path to access; reserved for docs nobody else can see. Lets the UI disclose why an admin-bypass viewer sees a doc that wasn't explicitly shared with them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_source")]
        public global::ElevenLabs.ResourceAccessInfoAccessSource2? AccessSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAccessInfo" /> class.
        /// </summary>
        /// <param name="isCreator">
        /// Whether the user making the request is the creator of the agent
        /// </param>
        /// <param name="creatorName">
        /// Name of the agent's creator
        /// </param>
        /// <param name="creatorEmail">
        /// Email of the agent's creator
        /// </param>
        /// <param name="role">
        /// The role of the user making the request
        /// </param>
        /// <param name="anonymousAccessLevelOverride">
        /// The access level for anonymous users. If None, the resource is not shared publicly.
        /// </param>
        /// <param name="accessSource">
        /// Why the requesting user has access to this resource. 'creator' = caller is the owner. 'explicit' = caller (or one of their workspace groups) is listed in role_to_group_ids beyond the workspace-wide everyone group. 'workspace_default' = the workspace-wide everyone group is listed in role_to_group_ids (every non-anon workspace member, including admins, sees this resource). 'workspace_admin' = caller is a workspace admin and the admin seat is the *only* path to access; reserved for docs nobody else can see. Lets the UI disclose why an admin-bypass viewer sees a doc that wasn't explicitly shared with them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceAccessInfo(
            bool isCreator,
            string creatorName,
            string creatorEmail,
            global::ElevenLabs.ResourceAccessInfoRole role,
            global::ElevenLabs.ResourceAccessInfoAnonymousAccessLevelOverride2? anonymousAccessLevelOverride,
            global::ElevenLabs.ResourceAccessInfoAccessSource2? accessSource)
        {
            this.IsCreator = isCreator;
            this.CreatorName = creatorName ?? throw new global::System.ArgumentNullException(nameof(creatorName));
            this.CreatorEmail = creatorEmail ?? throw new global::System.ArgumentNullException(nameof(creatorEmail));
            this.Role = role;
            this.AnonymousAccessLevelOverride = anonymousAccessLevelOverride;
            this.AccessSource = accessSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAccessInfo" /> class.
        /// </summary>
        public ResourceAccessInfo()
        {
        }

    }
}