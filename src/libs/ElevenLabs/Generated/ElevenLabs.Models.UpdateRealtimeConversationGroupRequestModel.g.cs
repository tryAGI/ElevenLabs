
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Only fields present in the request are applied; `description=None` clears it.
    /// </summary>
    public sealed partial class UpdateRealtimeConversationGroupRequestModel
    {
        /// <summary>
        /// Name of the conversation group. Names are unique per workspace, ignoring case and extra whitespace, and at most 64 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// New description of the conversation group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRealtimeConversationGroupRequestModel" /> class.
        /// </summary>
        /// <param name="title">
        /// Name of the conversation group. Names are unique per workspace, ignoring case and extra whitespace, and at most 64 characters.
        /// </param>
        /// <param name="description">
        /// New description of the conversation group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRealtimeConversationGroupRequestModel(
            string? title,
            string? description)
        {
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRealtimeConversationGroupRequestModel" /> class.
        /// </summary>
        public UpdateRealtimeConversationGroupRequestModel()
        {
        }

    }
}