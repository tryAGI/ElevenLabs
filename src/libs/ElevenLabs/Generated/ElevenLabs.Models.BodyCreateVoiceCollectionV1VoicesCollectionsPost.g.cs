
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyCreateVoiceCollectionV1VoicesCollectionsPost
    {
        /// <summary>
        /// Title of the collection to create/update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Icon of the collection to create/update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Icon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateVoiceCollectionV1VoicesCollectionsPost" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the collection to create/update.
        /// </param>
        /// <param name="icon">
        /// Icon of the collection to create/update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateVoiceCollectionV1VoicesCollectionsPost(
            string title,
            string icon)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Icon = icon ?? throw new global::System.ArgumentNullException(nameof(icon));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateVoiceCollectionV1VoicesCollectionsPost" /> class.
        /// </summary>
        public BodyCreateVoiceCollectionV1VoicesCollectionsPost()
        {
        }

    }
}