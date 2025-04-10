
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost
    {
        /// <summary>
        /// The email of the target workspace member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost" /> class.
        /// </summary>
        /// <param name="email">
        /// The email of the target workspace member.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost(
            string email)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost" /> class.
        /// </summary>
        public BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost()
        {
        }
    }
}