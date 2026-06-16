
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum StartProcedureToolErrorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        AlreadyActive,
        /// <summary>
        /// 
        /// </summary>
        InvalidName,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartProcedureToolErrorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartProcedureToolErrorStatus value)
        {
            return value switch
            {
                StartProcedureToolErrorStatus.AlreadyActive => "already_active",
                StartProcedureToolErrorStatus.InvalidName => "invalid_name",
                StartProcedureToolErrorStatus.NotFound => "not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartProcedureToolErrorStatus? ToEnum(string value)
        {
            return value switch
            {
                "already_active" => StartProcedureToolErrorStatus.AlreadyActive,
                "invalid_name" => StartProcedureToolErrorStatus.InvalidName,
                "not_found" => StartProcedureToolErrorStatus.NotFound,
                _ => null,
            };
        }
    }
}