
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum LoadMemoryEntryToolErrorStatus
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
    public static class LoadMemoryEntryToolErrorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoadMemoryEntryToolErrorStatus value)
        {
            return value switch
            {
                LoadMemoryEntryToolErrorStatus.InvalidId => "invalid_id",
                LoadMemoryEntryToolErrorStatus.NotFound => "not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoadMemoryEntryToolErrorStatus? ToEnum(string value)
        {
            return value switch
            {
                "invalid_id" => LoadMemoryEntryToolErrorStatus.InvalidId,
                "not_found" => LoadMemoryEntryToolErrorStatus.NotFound,
                _ => null,
            };
        }
    }
}