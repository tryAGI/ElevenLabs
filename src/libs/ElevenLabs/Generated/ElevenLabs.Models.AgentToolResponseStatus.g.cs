
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentToolResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolResponseStatus value)
        {
            return value switch
            {
                AgentToolResponseStatus.Blocked => "blocked",
                AgentToolResponseStatus.Error => "error",
                AgentToolResponseStatus.Skipped => "skipped",
                AgentToolResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => AgentToolResponseStatus.Blocked,
                "error" => AgentToolResponseStatus.Error,
                "skipped" => AgentToolResponseStatus.Skipped,
                "success" => AgentToolResponseStatus.Success,
                _ => null,
            };
        }
    }
}