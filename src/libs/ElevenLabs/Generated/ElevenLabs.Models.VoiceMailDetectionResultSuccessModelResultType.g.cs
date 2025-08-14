
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: voicemail_detection_success
    /// </summary>
    public enum VoiceMailDetectionResultSuccessModelResultType
    {
        /// <summary>
        /// 
        /// </summary>
        VoicemailDetectionSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceMailDetectionResultSuccessModelResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceMailDetectionResultSuccessModelResultType value)
        {
            return value switch
            {
                VoiceMailDetectionResultSuccessModelResultType.VoicemailDetectionSuccess => "voicemail_detection_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceMailDetectionResultSuccessModelResultType? ToEnum(string value)
        {
            return value switch
            {
                "voicemail_detection_success" => VoiceMailDetectionResultSuccessModelResultType.VoicemailDetectionSuccess,
                _ => null,
            };
        }
    }
}