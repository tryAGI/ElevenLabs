
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum Monitor
    {
        /// <summary>
        /// 
        /// </summary>
        ElevatedConversationFailureRate,
        /// <summary>
        /// 
        /// </summary>
        ElevatedToolFailureRate,
        /// <summary>
        /// 
        /// </summary>
        WebhookErrorSpike,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MonitorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Monitor value)
        {
            return value switch
            {
                Monitor.ElevatedConversationFailureRate => "elevated_conversation_failure_rate",
                Monitor.ElevatedToolFailureRate => "elevated_tool_failure_rate",
                Monitor.WebhookErrorSpike => "webhook_error_spike",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Monitor? ToEnum(string value)
        {
            return value switch
            {
                "elevated_conversation_failure_rate" => Monitor.ElevatedConversationFailureRate,
                "elevated_tool_failure_rate" => Monitor.ElevatedToolFailureRate,
                "webhook_error_spike" => Monitor.WebhookErrorSpike,
                _ => null,
            };
        }
    }
}