
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReceptionTeamMemberResponse
    {
        /// <summary>
        /// The member's user ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The member's email address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// The member's first name, if set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Whether the member owns the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOwner { get; set; }

        /// <summary>
        /// Whether the member is a workspace admin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_admin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAdmin { get; set; }

        /// <summary>
        /// URL of the member's profile picture, if set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture_url")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// Whether the member's access to the workspace is suspended.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_suspended")]
        public bool? IsSuspended { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionTeamMemberResponse" /> class.
        /// </summary>
        /// <param name="userId">
        /// The member's user ID.
        /// </param>
        /// <param name="email">
        /// The member's email address.
        /// </param>
        /// <param name="isOwner">
        /// Whether the member owns the workspace.
        /// </param>
        /// <param name="isAdmin">
        /// Whether the member is a workspace admin.
        /// </param>
        /// <param name="firstName">
        /// The member's first name, if set.
        /// </param>
        /// <param name="pictureUrl">
        /// URL of the member's profile picture, if set.
        /// </param>
        /// <param name="isSuspended">
        /// Whether the member's access to the workspace is suspended.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionTeamMemberResponse(
            string userId,
            string email,
            bool isOwner,
            bool isAdmin,
            string? firstName,
            string? pictureUrl,
            bool? isSuspended)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FirstName = firstName;
            this.IsOwner = isOwner;
            this.IsAdmin = isAdmin;
            this.PictureUrl = pictureUrl;
            this.IsSuspended = isSuspended;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionTeamMemberResponse" /> class.
        /// </summary>
        public ReceptionTeamMemberResponse()
        {
        }

    }
}