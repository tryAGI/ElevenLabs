
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum VoiceMailDetectionResultSuccessModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceMailDetectionResultSuccessModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceMailDetectionResultSuccessModelStatus value)
        {
            return value switch
            {
                VoiceMailDetectionResultSuccessModelStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceMailDetectionResultSuccessModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => VoiceMailDetectionResultSuccessModelStatus.Success,
                _ => null,
            };
        }
    }
}