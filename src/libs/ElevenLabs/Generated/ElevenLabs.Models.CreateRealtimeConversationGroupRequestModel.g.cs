
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateRealtimeConversationGroupRequestModel
    {
        /// <summary>
        /// Name of the conversation group. Names are unique per workspace, ignoring case and extra whitespace, and at most 64 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Optional description of the conversation group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeConversationGroupRequestModel" /> class.
        /// </summary>
        /// <param name="title">
        /// Name of the conversation group. Names are unique per workspace, ignoring case and extra whitespace, and at most 64 characters.
        /// </param>
        /// <param name="description">
        /// Optional description of the conversation group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeConversationGroupRequestModel(
            string title,
            string? description)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeConversationGroupRequestModel" /> class.
        /// </summary>
        public CreateRealtimeConversationGroupRequestModel()
        {
        }

    }
}