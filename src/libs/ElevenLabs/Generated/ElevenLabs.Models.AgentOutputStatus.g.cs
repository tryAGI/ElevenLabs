
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentOutputStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        RequiresAction,
        /// <summary>
        ///
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentOutputStatus value)
        {
            return value switch
            {
                AgentOutputStatus.Completed => "completed",
                AgentOutputStatus.Failed => "failed",
                AgentOutputStatus.InProgress => "in_progress",
                AgentOutputStatus.RequiresAction => "requires_action",
                AgentOutputStatus.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AgentOutputStatus.Completed,
                "failed" => AgentOutputStatus.Failed,
                "in_progress" => AgentOutputStatus.InProgress,
                "requires_action" => AgentOutputStatus.RequiresAction,
                "timed_out" => AgentOutputStatus.TimedOut,
                _ => null,
            };
        }
    }
}