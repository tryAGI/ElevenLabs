
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSortBy
    {
        /// <summary>
        ///
        /// </summary>
        CallCount7d,
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSortBy value)
        {
            return value switch
            {
                AgentSortBy.CallCount7d => "call_count_7d",
                AgentSortBy.CreatedAt => "created_at",
                AgentSortBy.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSortBy? ToEnum(string value)
        {
            return value switch
            {
                "call_count_7d" => AgentSortBy.CallCount7d,
                "created_at" => AgentSortBy.CreatedAt,
                "name" => AgentSortBy.Name,
                _ => null,
            };
        }
    }
}