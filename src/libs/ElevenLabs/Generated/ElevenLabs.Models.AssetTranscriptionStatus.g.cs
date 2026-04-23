
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssetTranscriptionStatus
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
    public static class AssetTranscriptionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetTranscriptionStatus value)
        {
            return value switch
            {
                AssetTranscriptionStatus.Completed => "completed",
                AssetTranscriptionStatus.Failed => "failed",
                AssetTranscriptionStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetTranscriptionStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AssetTranscriptionStatus.Completed,
                "failed" => AssetTranscriptionStatus.Failed,
                "processing" => AssetTranscriptionStatus.Processing,
                _ => null,
            };
        }
    }
}