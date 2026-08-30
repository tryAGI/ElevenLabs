
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Public workspace member fields exposed via GET /v1/workspace/members.
    /// </summary>
    public sealed partial class WorkspaceMemberResponseModel
    {
        /// <summary>
        /// The user ID of the workspace member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The email address of the workspace member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// The first name of the workspace member, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// The seat type (role) of the workspace member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_type")]
        public global::ElevenLabs.SeatType? SeatType { get; set; }

        /// <summary>
        /// Whether the member is the workspace owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOwner { get; set; }

        /// <summary>
        /// Whether the member's account is locked in this workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_locked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLocked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMemberResponseModel" /> class.
        /// </summary>
        /// <param name="userId">
        /// The user ID of the workspace member.
        /// </param>
        /// <param name="email">
        /// The email address of the workspace member.
        /// </param>
        /// <param name="isOwner">
        /// Whether the member is the workspace owner.
        /// </param>
        /// <param name="isLocked">
        /// Whether the member's account is locked in this workspace.
        /// </param>
        /// <param name="firstName">
        /// The first name of the workspace member, if available.
        /// </param>
        /// <param name="seatType">
        /// The seat type (role) of the workspace member.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceMemberResponseModel(
            string userId,
            string email,
            bool isOwner,
            bool isLocked,
            string? firstName,
            global::ElevenLabs.SeatType? seatType)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FirstName = firstName;
            this.SeatType = seatType;
            this.IsOwner = isOwner;
            this.IsLocked = isLocked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMemberResponseModel" /> class.
        /// </summary>
        public WorkspaceMemberResponseModel()
        {
        }

    }
}