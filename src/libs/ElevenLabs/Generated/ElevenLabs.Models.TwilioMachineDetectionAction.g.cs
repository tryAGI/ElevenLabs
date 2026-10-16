
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TwilioMachineDetectionAction
    {
        /// <summary>
        ///
        /// </summary>
        HangUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioMachineDetectionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioMachineDetectionAction value)
        {
            return value switch
            {
                TwilioMachineDetectionAction.HangUp => "hang_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioMachineDetectionAction? ToEnum(string value)
        {
            return value switch
            {
                "hang_up" => TwilioMachineDetectionAction.HangUp,
                _ => null,
            };
        }
    }
}