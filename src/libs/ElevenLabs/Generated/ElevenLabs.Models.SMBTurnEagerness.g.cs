
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How quickly the receptionist decides the caller has finished speaking.<br/>
    /// Default Value: eager
    /// </summary>
    public enum SMBTurnEagerness
    {
        /// <summary>
        ///
        /// </summary>
        Eager,
        /// <summary>
        ///
        /// </summary>
        Normal,
        /// <summary>
        ///
        /// </summary>
        Patient,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SMBTurnEagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBTurnEagerness value)
        {
            return value switch
            {
                SMBTurnEagerness.Eager => "eager",
                SMBTurnEagerness.Normal => "normal",
                SMBTurnEagerness.Patient => "patient",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBTurnEagerness? ToEnum(string value)
        {
            return value switch
            {
                "eager" => SMBTurnEagerness.Eager,
                "normal" => SMBTurnEagerness.Normal,
                "patient" => SMBTurnEagerness.Patient,
                _ => null,
            };
        }
    }
}