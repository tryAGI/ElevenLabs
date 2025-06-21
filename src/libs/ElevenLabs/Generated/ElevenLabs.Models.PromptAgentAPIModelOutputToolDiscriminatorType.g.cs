
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAgentAPIModelOutputToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptAgentAPIModelOutputToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAgentAPIModelOutputToolDiscriminatorType value)
        {
            return value switch
            {
                PromptAgentAPIModelOutputToolDiscriminatorType.Client => "client",
                PromptAgentAPIModelOutputToolDiscriminatorType.Mcp => "mcp",
                PromptAgentAPIModelOutputToolDiscriminatorType.System => "system",
                PromptAgentAPIModelOutputToolDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAgentAPIModelOutputToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => PromptAgentAPIModelOutputToolDiscriminatorType.Client,
                "mcp" => PromptAgentAPIModelOutputToolDiscriminatorType.Mcp,
                "system" => PromptAgentAPIModelOutputToolDiscriminatorType.System,
                "webhook" => PromptAgentAPIModelOutputToolDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}