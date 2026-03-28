
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource
    {
        /// <summary>
        /// 
        /// </summary>
        Constant,
        /// <summary>
        /// 
        /// </summary>
        DynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource value)
        {
            return value switch
            {
                ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource.Constant => "constant",
                ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource.DynamicVariable => "dynamic_variable",
                ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "constant" => ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource.Constant,
                "dynamic_variable" => ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource.DynamicVariable,
                "llm" => ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource.Llm,
                _ => null,
            };
        }
    }
}