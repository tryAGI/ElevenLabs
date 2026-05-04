
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageAnalysisStatus
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
    public static class ImageAnalysisStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageAnalysisStatus value)
        {
            return value switch
            {
                ImageAnalysisStatus.Completed => "completed",
                ImageAnalysisStatus.Failed => "failed",
                ImageAnalysisStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageAnalysisStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ImageAnalysisStatus.Completed,
                "failed" => ImageAnalysisStatus.Failed,
                "processing" => ImageAnalysisStatus.Processing,
                _ => null,
            };
        }
    }
}