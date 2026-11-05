
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SMBTeamMemberResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOwner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_admin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAdmin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture_url")]
        public string? PictureUrl { get; set; }

        /// <summary>
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
        /// Initializes a new instance of the <see cref="SMBTeamMemberResponse" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="email"></param>
        /// <param name="isOwner"></param>
        /// <param name="isAdmin"></param>
        /// <param name="firstName"></param>
        /// <param name="pictureUrl"></param>
        /// <param name="isSuspended">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBTeamMemberResponse(
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
        /// Initializes a new instance of the <see cref="SMBTeamMemberResponse" /> class.
        /// </summary>
        public SMBTeamMemberResponse()
        {
        }

    }
}