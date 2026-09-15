
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AlertingIntegrationNotifierDiscriminatorIntegrationType
    {
        /// <summary>
        ///
        /// </summary>
        Pagerduty,
        /// <summary>
        ///
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertingIntegrationNotifierDiscriminatorIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertingIntegrationNotifierDiscriminatorIntegrationType value)
        {
            return value switch
            {
                AlertingIntegrationNotifierDiscriminatorIntegrationType.Pagerduty => "pagerduty",
                AlertingIntegrationNotifierDiscriminatorIntegrationType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertingIntegrationNotifierDiscriminatorIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "pagerduty" => AlertingIntegrationNotifierDiscriminatorIntegrationType.Pagerduty,
                "slack" => AlertingIntegrationNotifierDiscriminatorIntegrationType.Slack,
                _ => null,
            };
        }
    }
}