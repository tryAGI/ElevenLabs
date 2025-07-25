
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: play_dtmf_success
    /// </summary>
    public enum PlayDTMFResultSuccessModelResultType
    {
        /// <summary>
        /// 
        /// </summary>
        PlayDtmfSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlayDTMFResultSuccessModelResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayDTMFResultSuccessModelResultType value)
        {
            return value switch
            {
                PlayDTMFResultSuccessModelResultType.PlayDtmfSuccess => "play_dtmf_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayDTMFResultSuccessModelResultType? ToEnum(string value)
        {
            return value switch
            {
                "play_dtmf_success" => PlayDTMFResultSuccessModelResultType.PlayDtmfSuccess,
                _ => null,
            };
        }
    }
}