
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamInviteRequest
    {
        /// <summary>
        /// The email address to invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// The role the invitee joins with: 'workspace_admin' or 'workspace_member'.<br/>
        /// Default Value: workspace_member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TeamInviteRequestRoleJsonConverter))]
        public global::ElevenLabs.TeamInviteRequestRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamInviteRequest" /> class.
        /// </summary>
        /// <param name="email">
        /// The email address to invite.
        /// </param>
        /// <param name="role">
        /// The role the invitee joins with: 'workspace_admin' or 'workspace_member'.<br/>
        /// Default Value: workspace_member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamInviteRequest(
            string email,
            global::ElevenLabs.TeamInviteRequestRole? role)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamInviteRequest" /> class.
        /// </summary>
        public TeamInviteRequest()
        {
        }

    }
}