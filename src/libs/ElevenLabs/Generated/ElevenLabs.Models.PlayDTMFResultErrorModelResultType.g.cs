
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: play_dtmf_error
    /// </summary>
    public enum PlayDTMFResultErrorModelResultType
    {
        /// <summary>
        /// 
        /// </summary>
        PlayDtmfError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlayDTMFResultErrorModelResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayDTMFResultErrorModelResultType value)
        {
            return value switch
            {
                PlayDTMFResultErrorModelResultType.PlayDtmfError => "play_dtmf_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayDTMFResultErrorModelResultType? ToEnum(string value)
        {
            return value switch
            {
                "play_dtmf_error" => PlayDTMFResultErrorModelResultType.PlayDtmfError,
                _ => null,
            };
        }
    }
}