
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VeoReferenceImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceImage ReferenceImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.VeoReferenceImageTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.VeoReferenceImageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VeoReferenceImage" /> class.
        /// </summary>
        /// <param name="referenceImage"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VeoReferenceImage(
            global::ElevenLabs.ReferenceImage referenceImage,
            global::ElevenLabs.VeoReferenceImageType type)
        {
            this.ReferenceImage = referenceImage ?? throw new global::System.ArgumentNullException(nameof(referenceImage));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VeoReferenceImage" /> class.
        /// </summary>
        public VeoReferenceImage()
        {
        }
    }
}