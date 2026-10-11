
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteUserVoiceCollectionResponseModel
    {
        /// <summary>
        /// The ID of the deleted voice collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUserVoiceCollectionResponseModel" /> class.
        /// </summary>
        /// <param name="collectionId">
        /// The ID of the deleted voice collection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteUserVoiceCollectionResponseModel(
            string collectionId)
        {
            this.CollectionId = collectionId ?? throw new global::System.ArgumentNullException(nameof(collectionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUserVoiceCollectionResponseModel" /> class.
        /// </summary>
        public DeleteUserVoiceCollectionResponseModel()
        {
        }

    }
}