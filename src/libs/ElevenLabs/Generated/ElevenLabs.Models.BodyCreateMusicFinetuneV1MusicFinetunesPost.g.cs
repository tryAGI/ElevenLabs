
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateMusicFinetuneV1MusicFinetunesPost
    {
        /// <summary>
        /// Name for the finetune (5-200 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Primary musical genre of the finetune.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_genre")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrimaryGenre { get; set; }

        /// <summary>
        /// Audio files to train on.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<byte[]>? Files { get; set; }

        /// <summary>
        /// Tags to associate with the finetune.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Finetune visibility. Only 'private' and 'workspace' can be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility2? Visibility { get; set; }

        /// <summary>
        /// The model to create a finetune for.<br/>
        /// Default Value: music_v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BodyCreateMusicFinetuneV1MusicFinetunesPostModelIdJsonConverter))]
        public global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostModelId? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateMusicFinetuneV1MusicFinetunesPost" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the finetune (5-200 characters).
        /// </param>
        /// <param name="primaryGenre">
        /// Primary musical genre of the finetune.
        /// </param>
        /// <param name="files">
        /// Audio files to train on.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="tags">
        /// Tags to associate with the finetune.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="visibility">
        /// Finetune visibility. Only 'private' and 'workspace' can be set.
        /// </param>
        /// <param name="modelId">
        /// The model to create a finetune for.<br/>
        /// Default Value: music_v1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateMusicFinetuneV1MusicFinetunesPost(
            string name,
            string primaryGenre,
            global::System.Collections.Generic.IList<byte[]>? files,
            global::System.Collections.Generic.IList<string>? tags,
            global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility2? visibility,
            global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostModelId? modelId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PrimaryGenre = primaryGenre ?? throw new global::System.ArgumentNullException(nameof(primaryGenre));
            this.Files = files;
            this.Tags = tags;
            this.Visibility = visibility;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateMusicFinetuneV1MusicFinetunesPost" /> class.
        /// </summary>
        public BodyCreateMusicFinetuneV1MusicFinetunesPost()
        {
        }

    }
}