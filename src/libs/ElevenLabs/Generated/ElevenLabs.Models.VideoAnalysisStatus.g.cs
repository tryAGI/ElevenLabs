
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoAnalysisStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoAnalysisStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoAnalysisStatus value)
        {
            return value switch
            {
                VideoAnalysisStatus.Processing => "processing",
                VideoAnalysisStatus.Completed => "completed",
                VideoAnalysisStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoAnalysisStatus? ToEnum(string value)
        {
            return value switch
            {
                "processing" => VideoAnalysisStatus.Processing,
                "completed" => VideoAnalysisStatus.Completed,
                "failed" => VideoAnalysisStatus.Failed,
                _ => null,
            };
        }
    }
}