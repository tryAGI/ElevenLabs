
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SyncLipSyncV3Parameters
    {
        /// <summary>
        /// Default Value: cut_off
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SyncLipSyncV3ParametersSyncModeJsonConverter))]
        public global::ElevenLabs.SyncLipSyncV3ParametersSyncMode? SyncMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceAudio Audio { get; set; }

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
        /// Initializes a new instance of the <see cref="SyncLipSyncV3Parameters" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="video"></param>
        /// <param name="syncMode">
        /// Default Value: cut_off
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SyncLipSyncV3Parameters(
            global::ElevenLabs.ReferenceAudio audio,
            global::ElevenLabs.ReferenceVideo video,
            global::ElevenLabs.SyncLipSyncV3ParametersSyncMode? syncMode)
        {
            this.SyncMode = syncMode;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncLipSyncV3Parameters" /> class.
        /// </summary>
        public SyncLipSyncV3Parameters()
        {
        }

    }
}