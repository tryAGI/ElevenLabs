
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
        Async,
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
                InteractionBudget.Async => "async",
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
                "async" => InteractionBudget.Async,
                "realtime" => InteractionBudget.Realtime,
                _ => null,
            };
        }
    }
}