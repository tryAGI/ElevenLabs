
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageReferencePromptPart
    {
        /// <summary>
        /// Default Value: image_reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceImage Reference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReferencePromptPart" /> class.
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="type">
        /// Default Value: image_reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageReferencePromptPart(
            global::ElevenLabs.ReferenceImage reference,
            string? type)
        {
            this.Type = type;
            this.Reference = reference ?? throw new global::System.ArgumentNullException(nameof(reference));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReferencePromptPart" /> class.
        /// </summary>
        public ImageReferencePromptPart()
        {
        }
    }
}