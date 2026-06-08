
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum InteractionBudget
    {
        /// <summary>
        /// 
        /// </summary>
        x10Minutes,
        /// <summary>
        /// 
        /// </summary>
        x1Hour,
        /// <summary>
        /// 
        /// </summary>
        x5Minutes,
        /// <summary>
        /// 
        /// </summary>
        Realtime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InteractionBudgetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InteractionBudget value)
        {
            return value switch
            {
                InteractionBudget.x10Minutes => "10_minutes",
                InteractionBudget.x1Hour => "1_hour",
                InteractionBudget.x5Minutes => "5_minutes",
                InteractionBudget.Realtime => "realtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InteractionBudget? ToEnum(string value)
        {
            return value switch
            {
                "10_minutes" => InteractionBudget.x10Minutes,
                "1_hour" => InteractionBudget.x1Hour,
                "5_minutes" => InteractionBudget.x5Minutes,
                "realtime" => InteractionBudget.Realtime,
                _ => null,
            };
        }
    }
}