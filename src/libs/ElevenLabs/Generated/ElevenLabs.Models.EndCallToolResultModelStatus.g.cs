
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum EndCallToolResultModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndCallToolResultModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndCallToolResultModelStatus value)
        {
            return value switch
            {
                EndCallToolResultModelStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndCallToolResultModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => EndCallToolResultModelStatus.Success,
                _ => null,
            };
        }
    }
}