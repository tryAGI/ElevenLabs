
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: skills
    /// </summary>
    public enum ProcedureCompilerMode
    {
        /// <summary>
        /// 
        /// </summary>
        Append,
        /// <summary>
        /// 
        /// </summary>
        Skills,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcedureCompilerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcedureCompilerMode value)
        {
            return value switch
            {
                ProcedureCompilerMode.Append => "append",
                ProcedureCompilerMode.Skills => "skills",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcedureCompilerMode? ToEnum(string value)
        {
            return value switch
            {
                "append" => ProcedureCompilerMode.Append,
                "skills" => ProcedureCompilerMode.Skills,
                _ => null,
            };
        }
    }
}