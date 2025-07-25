
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: voicemail_detection
    /// </summary>
    public enum VoicemailDetectionToolConfigSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        VoicemailDetection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicemailDetectionToolConfigSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicemailDetectionToolConfigSystemToolType value)
        {
            return value switch
            {
                VoicemailDetectionToolConfigSystemToolType.VoicemailDetection => "voicemail_detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicemailDetectionToolConfigSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "voicemail_detection" => VoicemailDetectionToolConfigSystemToolType.VoicemailDetection,
                _ => null,
            };
        }
    }
}