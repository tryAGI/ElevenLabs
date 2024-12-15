
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAgentToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptAgentToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAgentToolDiscriminatorType value)
        {
            return value switch
            {
                PromptAgentToolDiscriminatorType.Webhook => "webhook",
                PromptAgentToolDiscriminatorType.Client => "client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAgentToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => PromptAgentToolDiscriminatorType.Webhook,
                "client" => PromptAgentToolDiscriminatorType.Client,
                _ => null,
            };
        }
    }
}