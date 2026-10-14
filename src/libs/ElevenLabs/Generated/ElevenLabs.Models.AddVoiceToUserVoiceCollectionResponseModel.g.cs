
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddVoiceToUserVoiceCollectionResponseModel
    {
        /// <summary>
        /// The ID of the voice collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionId { get; set; }

        /// <summary>
        /// The ID of the voice that was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceToUserVoiceCollectionResponseModel" /> class.
        /// </summary>
        /// <param name="collectionId">
        /// The ID of the voice collection.
        /// </param>
        /// <param name="voiceId">
        /// The ID of the voice that was added.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddVoiceToUserVoiceCollectionResponseModel(
            string collectionId,
            string voiceId)
        {
            this.CollectionId = collectionId ?? throw new global::System.ArgumentNullException(nameof(collectionId));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceToUserVoiceCollectionResponseModel" /> class.
        /// </summary>
        public AddVoiceToUserVoiceCollectionResponseModel()
        {
        }

    }
}