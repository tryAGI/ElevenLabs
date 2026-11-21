
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How quickly the receptionist decides the caller has finished speaking.<br/>
    /// Default Value: eager
    /// </summary>
    public enum ReceptionTurnEagerness
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
    public static class ReceptionTurnEagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionTurnEagerness value)
        {
            return value switch
            {
                ReceptionTurnEagerness.Eager => "eager",
                ReceptionTurnEagerness.Normal => "normal",
                ReceptionTurnEagerness.Patient => "patient",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionTurnEagerness? ToEnum(string value)
        {
            return value switch
            {
                "eager" => ReceptionTurnEagerness.Eager,
                "normal" => ReceptionTurnEagerness.Normal,
                "patient" => ReceptionTurnEagerness.Patient,
                _ => null,
            };
        }
    }
}