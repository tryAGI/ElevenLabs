
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum PlayDTMFResultSuccessModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlayDTMFResultSuccessModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayDTMFResultSuccessModelStatus value)
        {
            return value switch
            {
                PlayDTMFResultSuccessModelStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayDTMFResultSuccessModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => PlayDTMFResultSuccessModelStatus.Success,
                _ => null,
            };
        }
    }
}