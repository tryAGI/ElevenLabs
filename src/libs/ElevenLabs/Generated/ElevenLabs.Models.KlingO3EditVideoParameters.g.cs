
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KlingO3EditVideoParameters
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_audio")]
        public bool? KeepAudio { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoElement>? Elements { get; set; }

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
        /// Initializes a new instance of the <see cref="KlingO3EditVideoParameters" /> class.
        /// </summary>
        /// <param name="video"></param>
        /// <param name="keepAudio">
        /// Default Value: true
        /// </param>
        /// <param name="referenceImages">
        /// Default Value: []
        /// </param>
        /// <param name="elements">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KlingO3EditVideoParameters(
            global::ElevenLabs.ReferenceVideo video,
            bool? keepAudio,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? referenceImages,
            global::System.Collections.Generic.IList<global::ElevenLabs.VideoElement>? elements)
        {
            this.KeepAudio = keepAudio;
            this.ReferenceImages = referenceImages;
            this.Elements = elements;
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KlingO3EditVideoParameters" /> class.
        /// </summary>
        public KlingO3EditVideoParameters()
        {
        }

    }
}