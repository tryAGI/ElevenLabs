
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketCommentResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Comment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_user_id")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketCommentResponseModel" /> class.
        /// </summary>
        /// <param name="comment"></param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="ownerUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketCommentResponseModel(
            string comment,
            int createdAtUnixSecs,
            string? ownerUserId)
        {
            this.Comment = comment ?? throw new global::System.ArgumentNullException(nameof(comment));
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.OwnerUserId = ownerUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketCommentResponseModel" /> class.
        /// </summary>
        public TicketCommentResponseModel()
        {
        }

    }
}