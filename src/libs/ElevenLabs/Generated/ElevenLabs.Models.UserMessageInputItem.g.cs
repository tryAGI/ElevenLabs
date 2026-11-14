
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserMessageInputItem
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"user_message"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_message";

        /// <summary>
        /// The parts of the message: at most one text part and up to 5 file parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ContentItem> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageInputItem" /> class.
        /// </summary>
        /// <param name="content">
        /// The parts of the message: at most one text part and up to 5 file parts.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMessageInputItem(
            global::System.Collections.Generic.IList<global::ElevenLabs.ContentItem> content,
            string type = "user_message")
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageInputItem" /> class.
        /// </summary>
        public UserMessageInputItem()
        {
        }

    }
}