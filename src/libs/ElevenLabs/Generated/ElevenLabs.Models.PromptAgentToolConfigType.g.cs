
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAgentToolConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptAgentToolConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAgentToolConfigType value)
        {
            return value switch
            {
                PromptAgentToolConfigType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAgentToolConfigType? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => PromptAgentToolConfigType.Webhook,
                _ => null,
            };
        }
    }
}