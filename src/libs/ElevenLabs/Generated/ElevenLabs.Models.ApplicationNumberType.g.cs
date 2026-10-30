
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Which kind of regulated number a request or an issued number is for.<br/>
    /// Lives here rather than next to the application model because a phone<br/>
    /// assignment records it too, and the assignment model cannot import from<br/>
    /// ``telephony.models`` without a cycle back into this module.
    /// </summary>
    public enum ApplicationNumberType
    {
        /// <summary>
        ///
        /// </summary>
        Local,
        /// <summary>
        ///
        /// </summary>
        Mobile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplicationNumberTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplicationNumberType value)
        {
            return value switch
            {
                ApplicationNumberType.Local => "local",
                ApplicationNumberType.Mobile => "mobile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplicationNumberType? ToEnum(string value)
        {
            return value switch
            {
                "local" => ApplicationNumberType.Local,
                "mobile" => ApplicationNumberType.Mobile,
                _ => null,
            };
        }
    }
}