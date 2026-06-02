
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunwayGen4AlephParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::ElevenLabs.ReferenceImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceVideo Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayGen4AlephParameters" /> class.
        /// </summary>
        /// <param name="video"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="image"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwayGen4AlephParameters(
            global::ElevenLabs.ReferenceVideo video,
            string? aspectRatio,
            global::ElevenLabs.ReferenceImage? image)
        {
            this.AspectRatio = aspectRatio;
            this.Image = image;
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayGen4AlephParameters" /> class.
        /// </summary>
        public RunwayGen4AlephParameters()
        {
        }

    }
}