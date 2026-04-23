
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingExternalAudiosMetadataModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_global_offset_ms")]
        public int? TargetGlobalOffsetMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_audio_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExternalAudioIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingExternalAudiosMetadataModel" /> class.
        /// </summary>
        /// <param name="externalAudioIds"></param>
        /// <param name="targetGlobalOffsetMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PendingExternalAudiosMetadataModel(
            global::System.Collections.Generic.IList<string> externalAudioIds,
            int? targetGlobalOffsetMs)
        {
            this.TargetGlobalOffsetMs = targetGlobalOffsetMs;
            this.ExternalAudioIds = externalAudioIds ?? throw new global::System.ArgumentNullException(nameof(externalAudioIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingExternalAudiosMetadataModel" /> class.
        /// </summary>
        public PendingExternalAudiosMetadataModel()
        {
        }
    }
}