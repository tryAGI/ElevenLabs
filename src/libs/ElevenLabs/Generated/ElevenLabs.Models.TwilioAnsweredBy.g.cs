
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Carrier-level AMD verdict reported by Twilio via `AnsweredBy`.
    /// </summary>
    public enum TwilioAnsweredBy
    {
        /// <summary>
        ///
        /// </summary>
        Fax,
        /// <summary>
        ///
        /// </summary>
        Human,
        /// <summary>
        ///
        /// </summary>
        MachineEndBeep,
        /// <summary>
        ///
        /// </summary>
        MachineEndOther,
        /// <summary>
        ///
        /// </summary>
        MachineEndSilence,
        /// <summary>
        ///
        /// </summary>
        MachineStart,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioAnsweredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioAnsweredBy value)
        {
            return value switch
            {
                TwilioAnsweredBy.Fax => "fax",
                TwilioAnsweredBy.Human => "human",
                TwilioAnsweredBy.MachineEndBeep => "machine_end_beep",
                TwilioAnsweredBy.MachineEndOther => "machine_end_other",
                TwilioAnsweredBy.MachineEndSilence => "machine_end_silence",
                TwilioAnsweredBy.MachineStart => "machine_start",
                TwilioAnsweredBy.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioAnsweredBy? ToEnum(string value)
        {
            return value switch
            {
                "fax" => TwilioAnsweredBy.Fax,
                "human" => TwilioAnsweredBy.Human,
                "machine_end_beep" => TwilioAnsweredBy.MachineEndBeep,
                "machine_end_other" => TwilioAnsweredBy.MachineEndOther,
                "machine_end_silence" => TwilioAnsweredBy.MachineEndSilence,
                "machine_start" => TwilioAnsweredBy.MachineStart,
                "unknown" => TwilioAnsweredBy.Unknown,
                _ => null,
            };
        }
    }
}