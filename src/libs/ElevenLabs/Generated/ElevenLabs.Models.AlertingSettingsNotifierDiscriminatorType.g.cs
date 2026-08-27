
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AlertingSettingsNotifierDiscriminatorType
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
    public static class AlertingSettingsNotifierDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertingSettingsNotifierDiscriminatorType value)
        {
            return value switch
            {
                AlertingSettingsNotifierDiscriminatorType.Integration => "integration",
                AlertingSettingsNotifierDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertingSettingsNotifierDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "integration" => AlertingSettingsNotifierDiscriminatorType.Integration,
                "webhook" => AlertingSettingsNotifierDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}