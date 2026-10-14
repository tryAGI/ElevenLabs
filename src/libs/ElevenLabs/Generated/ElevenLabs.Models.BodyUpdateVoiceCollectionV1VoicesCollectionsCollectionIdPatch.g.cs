
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyUpdateVoiceCollectionV1VoicesCollectionsCollectionIdPatch
    {
        /// <summary>
        /// Title of the collection to create/update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Icon of the collection to create/update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateVoiceCollectionV1VoicesCollectionsCollectionIdPatch" /> class.
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
        public BodyUpdateVoiceCollectionV1VoicesCollectionsCollectionIdPatch(
            string? title,
            string? icon)
        {
            this.Title = title;
            this.Icon = icon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateVoiceCollectionV1VoicesCollectionsCollectionIdPatch" /> class.
        /// </summary>
        public BodyUpdateVoiceCollectionV1VoicesCollectionsCollectionIdPatch()
        {
        }

    }
}