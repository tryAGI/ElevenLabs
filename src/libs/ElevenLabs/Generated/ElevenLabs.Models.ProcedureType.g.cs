
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: free_form
    /// </summary>
    public enum ProcedureType
    {
        /// <summary>
        /// 
        /// </summary>
        Deterministic,
        /// <summary>
        /// 
        /// </summary>
        FreeForm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcedureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcedureType value)
        {
            return value switch
            {
                ProcedureType.Deterministic => "deterministic",
                ProcedureType.FreeForm => "free_form",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcedureType? ToEnum(string value)
        {
            return value switch
            {
                "deterministic" => ProcedureType.Deterministic,
                "free_form" => ProcedureType.FreeForm,
                _ => null,
            };
        }
    }
}