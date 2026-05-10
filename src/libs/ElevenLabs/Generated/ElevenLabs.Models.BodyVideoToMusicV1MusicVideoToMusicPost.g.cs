
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyVideoToMusicV1MusicVideoToMusicPost
    {
        /// <summary>
        ///             One or more video files sent via FormData array (multipart/form-data). They will be combined into one codec in order.<br/>
        ///             A maximum of 10 videos is allowed, where the total size of the combined video is limited to 200MB.<br/>
        ///             In total, the video can be up to 600 seconds long. Note that combining multiple videos may increase the request duration significantly. If possible, combine the videos beforehand.<br/>
        ///             
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Videos { get; set; }

        /// <summary>
        /// Optional text description of the music you want. A maximum of 1000 characters is allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Optional list of style tags (e.g. ['upbeat', 'cinematic']). A maximum of 10 tags is allowed.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Whether to sign the generated song with C2PA. Applicable only for mp3 files.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sign_with_c2pa")]
        public bool? SignWithC2pa { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyVideoToMusicV1MusicVideoToMusicPost" /> class.
        /// </summary>
        /// <param name="videos">
        ///             One or more video files sent via FormData array (multipart/form-data). They will be combined into one codec in order.<br/>
        ///             A maximum of 10 videos is allowed, where the total size of the combined video is limited to 200MB.<br/>
        ///             In total, the video can be up to 600 seconds long. Note that combining multiple videos may increase the request duration significantly. If possible, combine the videos beforehand.<br/>
        ///             
        /// </param>
        /// <param name="description">
        /// Optional text description of the music you want. A maximum of 1000 characters is allowed.
        /// </param>
        /// <param name="tags">
        /// Optional list of style tags (e.g. ['upbeat', 'cinematic']). A maximum of 10 tags is allowed.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="signWithC2pa">
        /// Whether to sign the generated song with C2PA. Applicable only for mp3 files.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyVideoToMusicV1MusicVideoToMusicPost(
            global::System.Collections.Generic.IList<byte[]> videos,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            bool? signWithC2pa)
        {
            this.Videos = videos ?? throw new global::System.ArgumentNullException(nameof(videos));
            this.Description = description;
            this.Tags = tags;
            this.SignWithC2pa = signWithC2pa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyVideoToMusicV1MusicVideoToMusicPost" /> class.
        /// </summary>
        public BodyVideoToMusicV1MusicVideoToMusicPost()
        {
        }

    }
}