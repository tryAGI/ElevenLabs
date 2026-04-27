
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SyncLipSyncTemplateParameters
    {
        /// <summary>
        /// Default Value: cut_off
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SyncLipSyncTemplateParametersSyncModeJsonConverter))]
        public global::ElevenLabs.SyncLipSyncTemplateParametersSyncMode? SyncMode { get; set; }

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
        /// Initializes a new instance of the <see cref="SyncLipSyncTemplateParameters" /> class.
        /// </summary>
        /// <param name="syncMode">
        /// Default Value: cut_off
        /// </param>
        /// <param name="audio"></param>
        /// <param name="video"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SyncLipSyncTemplateParameters(
            global::ElevenLabs.SyncLipSyncTemplateParametersSyncMode? syncMode,
            global::ElevenLabs.ReferenceAudio? audio,
            global::ElevenLabs.ReferenceVideo? video)
        {
            this.SyncMode = syncMode;
            this.Audio = audio;
            this.Video = video;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncLipSyncTemplateParameters" /> class.
        /// </summary>
        public SyncLipSyncTemplateParameters()
        {
        }
    }
}