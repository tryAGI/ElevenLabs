
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AlertingIntegrationNotifierResponseDiscriminatorIntegrationType
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
    public static class AlertingIntegrationNotifierResponseDiscriminatorIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertingIntegrationNotifierResponseDiscriminatorIntegrationType value)
        {
            return value switch
            {
                AlertingIntegrationNotifierResponseDiscriminatorIntegrationType.Pagerduty => "pagerduty",
                AlertingIntegrationNotifierResponseDiscriminatorIntegrationType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertingIntegrationNotifierResponseDiscriminatorIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "pagerduty" => AlertingIntegrationNotifierResponseDiscriminatorIntegrationType.Pagerduty,
                "slack" => AlertingIntegrationNotifierResponseDiscriminatorIntegrationType.Slack,
                _ => null,
            };
        }
    }
}