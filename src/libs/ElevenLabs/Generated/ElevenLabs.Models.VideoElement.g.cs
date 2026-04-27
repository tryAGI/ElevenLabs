
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoElement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frontal_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceImage FrontalImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage> ReferenceImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoElement" /> class.
        /// </summary>
        /// <param name="frontalImage"></param>
        /// <param name="referenceImages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoElement(
            global::ElevenLabs.ReferenceImage frontalImage,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage> referenceImages)
        {
            this.FrontalImage = frontalImage ?? throw new global::System.ArgumentNullException(nameof(frontalImage));
            this.ReferenceImages = referenceImages ?? throw new global::System.ArgumentNullException(nameof(referenceImages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoElement" /> class.
        /// </summary>
        public VideoElement()
        {
        }
    }
}