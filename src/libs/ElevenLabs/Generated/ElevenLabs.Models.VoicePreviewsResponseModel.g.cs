
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicePreviewsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previews")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.VoicePreviewResponseModel> Previews { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePreviewsResponseModel" /> class.
        /// </summary>
        /// <param name="previews"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public VoicePreviewsResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.VoicePreviewResponseModel> previews)
        {
            this.Previews = previews ?? throw new global::System.ArgumentNullException(nameof(previews));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePreviewsResponseModel" /> class.
        /// </summary>
        public VoicePreviewsResponseModel()
        {
        }
    }
}