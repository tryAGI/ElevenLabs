
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SMBTeamInviteResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Seat types for workspace members.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SeatTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SeatType SeatType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviting_user_email")]
        public string? InvitingUserEmail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        public int? CreatedAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBTeamInviteResponse" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="seatType">
        /// Seat types for workspace members.
        /// </param>
        /// <param name="invitingUserEmail"></param>
        /// <param name="createdAtUnix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBTeamInviteResponse(
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
        /// Initializes a new instance of the <see cref="SMBTeamInviteResponse" /> class.
        /// </summary>
        public SMBTeamInviteResponse()
        {
        }

    }
}