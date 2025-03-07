
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The status of the snapshot upload.
    /// </summary>
    public enum ProjectSnapshotUploadResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        InQueue,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSnapshotUploadResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSnapshotUploadResponseModelStatus value)
        {
            return value switch
            {
                ProjectSnapshotUploadResponseModelStatus.Success => "success",
                ProjectSnapshotUploadResponseModelStatus.InQueue => "in_queue",
                ProjectSnapshotUploadResponseModelStatus.Pending => "pending",
                ProjectSnapshotUploadResponseModelStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSnapshotUploadResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => ProjectSnapshotUploadResponseModelStatus.Success,
                "in_queue" => ProjectSnapshotUploadResponseModelStatus.InQueue,
                "pending" => ProjectSnapshotUploadResponseModelStatus.Pending,
                "failed" => ProjectSnapshotUploadResponseModelStatus.Failed,
                _ => null,
            };
        }
    }
}