
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
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
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
                VideoAnalysisStatus.Completed => "completed",
                VideoAnalysisStatus.Failed => "failed",
                VideoAnalysisStatus.Processing => "processing",
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
                "completed" => VideoAnalysisStatus.Completed,
                "failed" => VideoAnalysisStatus.Failed,
                "processing" => VideoAnalysisStatus.Processing,
                _ => null,
            };
        }
    }
}