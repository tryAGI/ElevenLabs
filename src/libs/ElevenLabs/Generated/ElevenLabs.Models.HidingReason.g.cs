
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum HidingReason
    {
        /// <summary>
        ///
        /// </summary>
        SmbAssistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HidingReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HidingReason value)
        {
            return value switch
            {
                HidingReason.SmbAssistant => "smb_assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HidingReason? ToEnum(string value)
        {
            return value switch
            {
                "smb_assistant" => HidingReason.SmbAssistant,
                _ => null,
            };
        }
    }
}