
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiIntegrationWebhook,
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
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType value)
        {
            return value switch
            {
                ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType.ApiIntegrationWebhook => "api_integration_webhook",
                ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType.Client => "client",
                ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType.Mcp => "mcp",
                ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_integration_webhook" => ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType.ApiIntegrationWebhook,
                "client" => ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType.Client,
                "mcp" => ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType.Mcp,
                "webhook" => ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}