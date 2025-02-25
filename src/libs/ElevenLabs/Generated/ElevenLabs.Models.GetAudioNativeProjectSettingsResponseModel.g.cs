
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAudioNativeProjectSettingsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AudioNativeProjectSettingsResponseModel Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAudioNativeProjectSettingsResponseModel" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="snapshotId"></param>
        /// <param name="settings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAudioNativeProjectSettingsResponseModel(
            bool enabled,
            string snapshotId,
            global::ElevenLabs.AudioNativeProjectSettingsResponseModel settings)
        {
            this.Enabled = enabled;
            this.SnapshotId = snapshotId ?? throw new global::System.ArgumentNullException(nameof(snapshotId));
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAudioNativeProjectSettingsResponseModel" /> class.
        /// </summary>
        public GetAudioNativeProjectSettingsResponseModel()
        {
        }
    }
}