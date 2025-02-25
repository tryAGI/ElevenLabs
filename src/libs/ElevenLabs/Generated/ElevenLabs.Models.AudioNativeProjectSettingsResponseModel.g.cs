
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioNativeProjectSettingsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("small")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Small { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sessionization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioNativeProjectSettingsResponseModel" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="image"></param>
        /// <param name="author"></param>
        /// <param name="small"></param>
        /// <param name="textColor"></param>
        /// <param name="backgroundColor"></param>
        /// <param name="sessionization"></param>
        /// <param name="audioPath"></param>
        /// <param name="audioUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioNativeProjectSettingsResponseModel(
            string title,
            string image,
            string author,
            bool small,
            string textColor,
            string backgroundColor,
            int sessionization,
            string audioPath,
            string audioUrl)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Small = small;
            this.TextColor = textColor ?? throw new global::System.ArgumentNullException(nameof(textColor));
            this.BackgroundColor = backgroundColor ?? throw new global::System.ArgumentNullException(nameof(backgroundColor));
            this.Sessionization = sessionization;
            this.AudioPath = audioPath ?? throw new global::System.ArgumentNullException(nameof(audioPath));
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioNativeProjectSettingsResponseModel" /> class.
        /// </summary>
        public AudioNativeProjectSettingsResponseModel()
        {
        }
    }
}