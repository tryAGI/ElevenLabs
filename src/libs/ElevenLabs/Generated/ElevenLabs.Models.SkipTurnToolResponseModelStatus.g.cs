
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum SkipTurnToolResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkipTurnToolResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkipTurnToolResponseModelStatus value)
        {
            return value switch
            {
                SkipTurnToolResponseModelStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkipTurnToolResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => SkipTurnToolResponseModelStatus.Success,
                _ => null,
            };
        }
    }
}