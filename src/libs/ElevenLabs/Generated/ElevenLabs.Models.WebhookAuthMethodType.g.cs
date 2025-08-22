
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookAuthMethodType
    {
        /// <summary>
        /// 
        /// </summary>
        Hmac,
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
        /// <summary>
        /// 
        /// </summary>
        Mtls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAuthMethodTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAuthMethodType value)
        {
            return value switch
            {
                WebhookAuthMethodType.Hmac => "hmac",
                WebhookAuthMethodType.Oauth2 => "oauth2",
                WebhookAuthMethodType.Mtls => "mtls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAuthMethodType? ToEnum(string value)
        {
            return value switch
            {
                "hmac" => WebhookAuthMethodType.Hmac,
                "oauth2" => WebhookAuthMethodType.Oauth2,
                "mtls" => WebhookAuthMethodType.Mtls,
                _ => null,
            };
        }
    }
}