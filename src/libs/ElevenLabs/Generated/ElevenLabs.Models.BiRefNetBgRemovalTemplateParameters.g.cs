
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BiRefNetBgRemovalTemplateParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::ElevenLabs.ReferenceImage? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BiRefNetBgRemovalTemplateParameters" /> class.
        /// </summary>
        /// <param name="image"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BiRefNetBgRemovalTemplateParameters(
            global::ElevenLabs.ReferenceImage? image)
        {
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BiRefNetBgRemovalTemplateParameters" /> class.
        /// </summary>
        public BiRefNetBgRemovalTemplateParameters()
        {
        }
    }
}