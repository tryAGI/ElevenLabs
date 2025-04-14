
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyForcedAlignmentV1ForcedAlignmentPost
    {
        /// <summary>
        /// The file to align. All major audio and video formats are supported. The file size must be less than 1GB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The file to align. All major audio and video formats are supported. The file size must be less than 1GB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The text to align with the audio or video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyForcedAlignmentV1ForcedAlignmentPost" /> class.
        /// </summary>
        /// <param name="file">
        /// The file to align. All major audio and video formats are supported. The file size must be less than 1GB.
        /// </param>
        /// <param name="filename">
        /// The file to align. All major audio and video formats are supported. The file size must be less than 1GB.
        /// </param>
        /// <param name="text">
        /// The text to align with the audio or video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyForcedAlignmentV1ForcedAlignmentPost(
            byte[] file,
            string filename,
            string text)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyForcedAlignmentV1ForcedAlignmentPost" /> class.
        /// </summary>
        public BodyForcedAlignmentV1ForcedAlignmentPost()
        {
        }
    }
}