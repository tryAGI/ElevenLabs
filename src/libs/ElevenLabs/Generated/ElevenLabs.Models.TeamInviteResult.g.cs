
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamInviteResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TeamInviteOutcomeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TeamInviteOutcome Outcome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_status")]
        public string? ErrorStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamInviteResult" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="outcome"></param>
        /// <param name="errorStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamInviteResult(
            string email,
            global::ElevenLabs.TeamInviteOutcome outcome,
            string? errorStatus)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Outcome = outcome;
            this.ErrorStatus = errorStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamInviteResult" /> class.
        /// </summary>
        public TeamInviteResult()
        {
        }

    }
}