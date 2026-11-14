
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReceptionTeamInviteResponse
    {
        /// <summary>
        /// The invited email address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// The role the invitee joins with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SeatTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SeatType SeatType { get; set; }

        /// <summary>
        /// Email address of the member who sent the invite, if known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviting_user_email")]
        public string? InvitingUserEmail { get; set; }

        /// <summary>
        /// When the invite was sent, as a Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        public int? CreatedAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionTeamInviteResponse" /> class.
        /// </summary>
        /// <param name="email">
        /// The invited email address.
        /// </param>
        /// <param name="seatType">
        /// The role the invitee joins with.
        /// </param>
        /// <param name="invitingUserEmail">
        /// Email address of the member who sent the invite, if known.
        /// </param>
        /// <param name="createdAtUnix">
        /// When the invite was sent, as a Unix timestamp in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionTeamInviteResponse(
            string email,
            global::ElevenLabs.SeatType seatType,
            string? invitingUserEmail,
            int? createdAtUnix)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.SeatType = seatType;
            this.InvitingUserEmail = invitingUserEmail;
            this.CreatedAtUnix = createdAtUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionTeamInviteResponse" /> class.
        /// </summary>
        public ReceptionTeamInviteResponse()
        {
        }

    }
}