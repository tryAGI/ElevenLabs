
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SyncLipSyncParameters
    {
        /// <summary>
        /// Default Value: cut_off
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SyncLipSyncParametersSyncModeJsonConverter))]
        public global::ElevenLabs.SyncLipSyncParametersSyncMode? SyncMode { get; set; }

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
        /// Initializes a new instance of the <see cref="SyncLipSyncParameters" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="video"></param>
        /// <param name="syncMode">
        /// Default Value: cut_off
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SyncLipSyncParameters(
            global::ElevenLabs.ReferenceAudio audio,
            global::ElevenLabs.ReferenceVideo video,
            global::ElevenLabs.SyncLipSyncParametersSyncMode? syncMode)
        {
            this.SyncMode = syncMode;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncLipSyncParameters" /> class.
        /// </summary>
        public SyncLipSyncParameters()
        {
        }

    }
}