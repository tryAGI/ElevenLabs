
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A reference image guiding a Veo generation, with its role.
    /// </summary>
    public sealed partial class VeoImageReference
    {
        /// <summary>
        /// The reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ImageReferenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ImageReference Image { get; set; }

        /// <summary>
        /// How the model uses the image: `subject` places its subject or scene elements into the video; `style` transfers its visual style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.VeoImageReferenceRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.VeoImageReferenceRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VeoImageReference" /> class.
        /// </summary>
        /// <param name="image">
        /// The reference image.
        /// </param>
        /// <param name="role">
        /// How the model uses the image: `subject` places its subject or scene elements into the video; `style` transfers its visual style.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VeoImageReference(
            global::ElevenLabs.ImageReference image,
            global::ElevenLabs.VeoImageReferenceRole role)
        {
            this.Image = image;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VeoImageReference" /> class.
        /// </summary>
        public VeoImageReference()
        {
        }

    }
}