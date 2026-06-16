
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndProcedureToolErrorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidId,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndProcedureToolErrorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndProcedureToolErrorStatus value)
        {
            return value switch
            {
                EndProcedureToolErrorStatus.InvalidId => "invalid_id",
                EndProcedureToolErrorStatus.NotFound => "not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndProcedureToolErrorStatus? ToEnum(string value)
        {
            return value switch
            {
                "invalid_id" => EndProcedureToolErrorStatus.InvalidId,
                "not_found" => EndProcedureToolErrorStatus.NotFound,
                _ => null,
            };
        }
    }
}