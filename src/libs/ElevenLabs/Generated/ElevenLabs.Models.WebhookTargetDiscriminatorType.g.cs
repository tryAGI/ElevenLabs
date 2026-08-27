
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookTargetDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Ids,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookTargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTargetDiscriminatorType value)
        {
            return value switch
            {
                WebhookTargetDiscriminatorType.All => "all",
                WebhookTargetDiscriminatorType.Ids => "ids",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all" => WebhookTargetDiscriminatorType.All,
                "ids" => WebhookTargetDiscriminatorType.Ids,
                _ => null,
            };
        }
    }
}