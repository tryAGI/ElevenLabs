
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyInviteUserV1WorkspaceInvitesAddPost
    {
        /// <summary>
        /// The email of the customer
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
        /// Initializes a new instance of the <see cref="BodyInviteUserV1WorkspaceInvitesAddPost" /> class.
        /// </summary>
        /// <param name="email">
        /// The email of the customer
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyInviteUserV1WorkspaceInvitesAddPost(
            string email)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyInviteUserV1WorkspaceInvitesAddPost" /> class.
        /// </summary>
        public BodyInviteUserV1WorkspaceInvitesAddPost()
        {
        }
    }
}