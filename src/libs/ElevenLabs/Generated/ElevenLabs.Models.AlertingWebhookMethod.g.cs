
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: POST
    /// </summary>
    public enum AlertingWebhookMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertingWebhookMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertingWebhookMethod value)
        {
            return value switch
            {
                AlertingWebhookMethod.Post => "POST",
                AlertingWebhookMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertingWebhookMethod? ToEnum(string value)
        {
            return value switch
            {
                "POST" => AlertingWebhookMethod.Post,
                "PUT" => AlertingWebhookMethod.Put,
                _ => null,
            };
        }
    }
}