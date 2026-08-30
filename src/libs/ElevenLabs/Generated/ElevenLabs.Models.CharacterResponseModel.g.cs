
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CharacterResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CharacterId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::ElevenLabs.CharacterMetadataResponseModel? Metadata { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommended_voice_ids")]
        public global::System.Collections.Generic.IList<string>? RecommendedVoiceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterResponseModel" /> class.
        /// </summary>
        /// <param name="characterId"></param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="recommendedVoiceIds">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CharacterResponseModel(
            string characterId,
            string name,
            global::ElevenLabs.CharacterMetadataResponseModel? metadata,
            global::System.Collections.Generic.IList<string>? recommendedVoiceIds)
        {
            this.CharacterId = characterId ?? throw new global::System.ArgumentNullException(nameof(characterId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata;
            this.RecommendedVoiceIds = recommendedVoiceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterResponseModel" /> class.
        /// </summary>
        public CharacterResponseModel()
        {
        }

    }
}