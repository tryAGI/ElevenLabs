
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LeadDeliveryView
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BatchCallRecipientStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.BatchCallRecipientStatus Status { get; set; }

        /// <summary>
        /// The furthest the message got, or `failed` if sending it failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.LeadDeliveryViewStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.LeadDeliveryViewStage Stage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sent_at_unix")]
        public int? SentAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivered_at_unix")]
        public int? DeliveredAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_at_unix")]
        public int? ReadAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replied_at_unix")]
        public int? RepliedAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at_unix")]
        public int? FailedAtUnix { get; set; }

        /// <summary>
        /// Why the message failed to reach the contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadDeliveryView" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="stage">
        /// The furthest the message got, or `failed` if sending it failed.
        /// </param>
        /// <param name="sentAtUnix"></param>
        /// <param name="deliveredAtUnix"></param>
        /// <param name="readAtUnix"></param>
        /// <param name="repliedAtUnix"></param>
        /// <param name="failedAtUnix"></param>
        /// <param name="errorMessage">
        /// Why the message failed to reach the contact.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LeadDeliveryView(
            global::ElevenLabs.BatchCallRecipientStatus status,
            global::ElevenLabs.LeadDeliveryViewStage stage,
            int? sentAtUnix,
            int? deliveredAtUnix,
            int? readAtUnix,
            int? repliedAtUnix,
            int? failedAtUnix,
            string? errorMessage)
        {
            this.Status = status;
            this.Stage = stage;
            this.SentAtUnix = sentAtUnix;
            this.DeliveredAtUnix = deliveredAtUnix;
            this.ReadAtUnix = readAtUnix;
            this.RepliedAtUnix = repliedAtUnix;
            this.FailedAtUnix = failedAtUnix;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadDeliveryView" /> class.
        /// </summary>
        public LeadDeliveryView()
        {
        }

    }
}