
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum LoadProcedureToolErrorStatus
    {
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
    public static class LoadProcedureToolErrorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoadProcedureToolErrorStatus value)
        {
            return value switch
            {
                LoadProcedureToolErrorStatus.InvalidName => "invalid_name",
                LoadProcedureToolErrorStatus.NotFound => "not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoadProcedureToolErrorStatus? ToEnum(string value)
        {
            return value switch
            {
                "invalid_name" => LoadProcedureToolErrorStatus.InvalidName,
                "not_found" => LoadProcedureToolErrorStatus.NotFound,
                _ => null,
            };
        }
    }
}