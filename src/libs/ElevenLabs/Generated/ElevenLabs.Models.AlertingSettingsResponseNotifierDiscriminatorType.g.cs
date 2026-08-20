
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertingSettingsResponseNotifierDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertingSettingsResponseNotifierDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertingSettingsResponseNotifierDiscriminatorType value)
        {
            return value switch
            {
                AlertingSettingsResponseNotifierDiscriminatorType.Integration => "integration",
                AlertingSettingsResponseNotifierDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertingSettingsResponseNotifierDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "integration" => AlertingSettingsResponseNotifierDiscriminatorType.Integration,
                "webhook" => AlertingSettingsResponseNotifierDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}