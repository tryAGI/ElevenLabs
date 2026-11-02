
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeConversationGroupsResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.RealtimeConversationGroupResponseModel> ConversationGroups { get; set; }

        /// <summary>
        /// Cursor to pass to the next request to fetch the following page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether more conversation groups are available beyond this page.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationGroupsResponseModel" /> class.
        /// </summary>
        /// <param name="conversationGroups"></param>
        /// <param name="nextCursor">
        /// Cursor to pass to the next request to fetch the following page.
        /// </param>
        /// <param name="hasMore">
        /// Whether more conversation groups are available beyond this page.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationGroupsResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.RealtimeConversationGroupResponseModel> conversationGroups,
            string? nextCursor,
            bool? hasMore)
        {
            this.ConversationGroups = conversationGroups ?? throw new global::System.ArgumentNullException(nameof(conversationGroups));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationGroupsResponseModel" /> class.
        /// </summary>
        public RealtimeConversationGroupsResponseModel()
        {
        }

    }
}