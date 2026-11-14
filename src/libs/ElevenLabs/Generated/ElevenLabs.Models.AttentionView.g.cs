
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AttentionView
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attention_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AttentionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CampaignId { get; set; }

        /// <summary>
        /// The cause, such as `agent_unavailable` or `phone_number_unavailable`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// What went wrong and how to fix it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AttentionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AttentionStatus Status { get; set; }

        /// <summary>
        /// Whether a retry places the calls the item holds back. Items that can't be retried are closed by resolving them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Retryable { get; set; }

        /// <summary>
        /// The note recorded on resolving the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttentionView" /> class.
        /// </summary>
        /// <param name="attentionId"></param>
        /// <param name="campaignId"></param>
        /// <param name="reason">
        /// The cause, such as `agent_unavailable` or `phone_number_unavailable`.
        /// </param>
        /// <param name="detail">
        /// What went wrong and how to fix it.
        /// </param>
        /// <param name="status"></param>
        /// <param name="retryable">
        /// Whether a retry places the calls the item holds back. Items that can't be retried are closed by resolving them.
        /// </param>
        /// <param name="createdAtUnix"></param>
        /// <param name="updatedAtUnix"></param>
        /// <param name="resolution">
        /// The note recorded on resolving the item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttentionView(
            string attentionId,
            string campaignId,
            string reason,
            string detail,
            global::ElevenLabs.AttentionStatus status,
            bool retryable,
            int createdAtUnix,
            int updatedAtUnix,
            string? resolution)
        {
            this.AttentionId = attentionId ?? throw new global::System.ArgumentNullException(nameof(attentionId));
            this.CampaignId = campaignId ?? throw new global::System.ArgumentNullException(nameof(campaignId));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.Status = status;
            this.Retryable = retryable;
            this.Resolution = resolution;
            this.CreatedAtUnix = createdAtUnix;
            this.UpdatedAtUnix = updatedAtUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttentionView" /> class.
        /// </summary>
        public AttentionView()
        {
        }

    }
}