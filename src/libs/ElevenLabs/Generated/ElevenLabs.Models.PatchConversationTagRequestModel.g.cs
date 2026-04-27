
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchConversationTagRequestModel
    {
        /// <summary>
        /// If provided, replaces the tag title. Omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// If provided, replaces the tag description. Omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConversationTagRequestModel" /> class.
        /// </summary>
        /// <param name="title">
        /// If provided, replaces the tag title. Omit to leave unchanged.
        /// </param>
        /// <param name="description">
        /// If provided, replaces the tag description. Omit to leave unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConversationTagRequestModel(
            string? title,
            string? description)
        {
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConversationTagRequestModel" /> class.
        /// </summary>
        public PatchConversationTagRequestModel()
        {
        }
    }
}