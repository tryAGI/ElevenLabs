
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignConversationTagsRequestModel
    {
        /// <summary>
        /// Tag IDs to add to the conversation. Re-assigning an existing tag is a no-op.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TagIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignConversationTagsRequestModel" /> class.
        /// </summary>
        /// <param name="tagIds">
        /// Tag IDs to add to the conversation. Re-assigning an existing tag is a no-op.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignConversationTagsRequestModel(
            global::System.Collections.Generic.IList<string> tagIds)
        {
            this.TagIds = tagIds ?? throw new global::System.ArgumentNullException(nameof(tagIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignConversationTagsRequestModel" /> class.
        /// </summary>
        public AssignConversationTagsRequestModel()
        {
        }
    }
}