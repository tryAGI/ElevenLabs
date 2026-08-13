
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMusicFinetuneRequestModel
    {
        /// <summary>
        /// Updated name for the finetune.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Replacement set of tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Updated primary musical genre.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_genre")]
        public string? PrimaryGenre { get; set; }

        /// <summary>
        /// Finetune visibility. Only 'private' and 'workspace' can be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public global::ElevenLabs.UpdateMusicFinetuneRequestModelVisibility2? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMusicFinetuneRequestModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated name for the finetune.
        /// </param>
        /// <param name="tags">
        /// Replacement set of tags.
        /// </param>
        /// <param name="primaryGenre">
        /// Updated primary musical genre.
        /// </param>
        /// <param name="visibility">
        /// Finetune visibility. Only 'private' and 'workspace' can be set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMusicFinetuneRequestModel(
            string? name,
            global::System.Collections.Generic.IList<string>? tags,
            string? primaryGenre,
            global::ElevenLabs.UpdateMusicFinetuneRequestModelVisibility2? visibility)
        {
            this.Name = name;
            this.Tags = tags;
            this.PrimaryGenre = primaryGenre;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMusicFinetuneRequestModel" /> class.
        /// </summary>
        public UpdateMusicFinetuneRequestModel()
        {
        }

    }
}