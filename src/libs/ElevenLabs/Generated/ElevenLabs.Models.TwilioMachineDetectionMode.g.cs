
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Which Twilio answering-machine-detection (AMD) mode to request for a call.<br/>
    /// `enable` returns a verdict as soon as Twilio can tell a human from a machine.<br/>
    /// `detect_message_end` additionally waits for the greeting to finish, which is what<br/>
    /// distinguishes the `machine_end_*` verdicts, at the cost of a later result.<br/>
    /// Default Value: enable
    /// </summary>
    public enum TwilioMachineDetectionMode
    {
        /// <summary>
        ///
        /// </summary>
        DetectMessageEnd,
        /// <summary>
        ///
        /// </summary>
        Enable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioMachineDetectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioMachineDetectionMode value)
        {
            return value switch
            {
                TwilioMachineDetectionMode.DetectMessageEnd => "detect_message_end",
                TwilioMachineDetectionMode.Enable => "enable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioMachineDetectionMode? ToEnum(string value)
        {
            return value switch
            {
                "detect_message_end" => TwilioMachineDetectionMode.DetectMessageEnd,
                "enable" => TwilioMachineDetectionMode.Enable,
                _ => null,
            };
        }
    }
}