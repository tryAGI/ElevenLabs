
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: error
    /// </summary>
    public enum PlayDTMFResultErrorModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlayDTMFResultErrorModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayDTMFResultErrorModelStatus value)
        {
            return value switch
            {
                PlayDTMFResultErrorModelStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayDTMFResultErrorModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PlayDTMFResultErrorModelStatus.Error,
                _ => null,
            };
        }
    }
}