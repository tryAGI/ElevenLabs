
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VeedLipSyncTemplateParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::ElevenLabs.ReferenceAudio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::ElevenLabs.ReferenceVideo? Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VeedLipSyncTemplateParameters" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="video"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VeedLipSyncTemplateParameters(
            global::ElevenLabs.ReferenceAudio? audio,
            global::ElevenLabs.ReferenceVideo? video)
        {
            this.Audio = audio;
            this.Video = video;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VeedLipSyncTemplateParameters" /> class.
        /// </summary>
        public VeedLipSyncTemplateParameters()
        {
        }
    }
}