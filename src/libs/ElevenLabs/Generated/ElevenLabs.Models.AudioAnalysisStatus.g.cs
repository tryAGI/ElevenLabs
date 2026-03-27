
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioAnalysisStatus
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
    public static class AudioAnalysisStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioAnalysisStatus value)
        {
            return value switch
            {
                AudioAnalysisStatus.Completed => "completed",
                AudioAnalysisStatus.Failed => "failed",
                AudioAnalysisStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioAnalysisStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AudioAnalysisStatus.Completed,
                "failed" => AudioAnalysisStatus.Failed,
                "processing" => AudioAnalysisStatus.Processing,
                _ => null,
            };
        }
    }
}