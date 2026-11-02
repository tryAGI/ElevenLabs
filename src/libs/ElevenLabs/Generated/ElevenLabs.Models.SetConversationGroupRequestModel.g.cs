
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SetConversationGroupRequestModel
    {
        /// <summary>
        /// The conversation group to place the conversation in. A conversation belongs to at most one group, so this moves it out of any current group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetConversationGroupRequestModel" /> class.
        /// </summary>
        /// <param name="conversationGroupId">
        /// The conversation group to place the conversation in. A conversation belongs to at most one group, so this moves it out of any current group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetConversationGroupRequestModel(
            string conversationGroupId)
        {
            this.ConversationGroupId = conversationGroupId ?? throw new global::System.ArgumentNullException(nameof(conversationGroupId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetConversationGroupRequestModel" /> class.
        /// </summary>
        public SetConversationGroupRequestModel()
        {
        }

    }
}