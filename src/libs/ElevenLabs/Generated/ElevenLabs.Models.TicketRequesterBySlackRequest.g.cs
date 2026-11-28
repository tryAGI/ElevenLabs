
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketRequesterBySlackRequest
    {
        /// <summary>
        /// Default Value: slack
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketRequesterBySlackRequest" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="type">
        /// Default Value: slack
        /// </param>
        /// <param name="fullName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketRequesterBySlackRequest(
            string teamId,
            string userId,
            string? type,
            string? fullName)
        {
            this.Type = type;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.FullName = fullName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketRequesterBySlackRequest" /> class.
        /// </summary>
        public TicketRequesterBySlackRequest()
        {
        }

    }
}