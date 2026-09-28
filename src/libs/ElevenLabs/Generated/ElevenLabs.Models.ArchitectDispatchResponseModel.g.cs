
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ArchitectDispatchResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architect_chat_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArchitectChatId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dispatched_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DispatchedAtUnixSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectDispatchResponseModel" /> class.
        /// </summary>
        /// <param name="architectChatId"></param>
        /// <param name="userId"></param>
        /// <param name="dispatchedAtUnixSecs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArchitectDispatchResponseModel(
            string architectChatId,
            string userId,
            int dispatchedAtUnixSecs)
        {
            this.ArchitectChatId = architectChatId ?? throw new global::System.ArgumentNullException(nameof(architectChatId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.DispatchedAtUnixSecs = dispatchedAtUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectDispatchResponseModel" /> class.
        /// </summary>
        public ArchitectDispatchResponseModel()
        {
        }

    }
}