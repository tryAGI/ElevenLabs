
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectSnapshotUploadResponseModel
    {
        /// <summary>
        /// The status of the snapshot upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProjectSnapshotUploadResponseModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ProjectSnapshotUploadResponseModelStatus Status { get; set; }

        /// <summary>
        /// Whether volume normalization was applied to the snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acx_volume_normalization")]
        public bool? AcxVolumeNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotUploadResponseModel" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the snapshot upload.
        /// </param>
        /// <param name="acxVolumeNormalization">
        /// Whether volume normalization was applied to the snapshot.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSnapshotUploadResponseModel(
            global::ElevenLabs.ProjectSnapshotUploadResponseModelStatus status,
            bool? acxVolumeNormalization)
        {
            this.Status = status;
            this.AcxVolumeNormalization = acxVolumeNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotUploadResponseModel" /> class.
        /// </summary>
        public ProjectSnapshotUploadResponseModel()
        {
        }
    }
}