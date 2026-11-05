
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookHttpMethod
    {
        /// <summary>
        ///
        /// </summary>
        Delete,
        /// <summary>
        ///
        /// </summary>
        Get,
        /// <summary>
        ///
        /// </summary>
        Patch,
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
    public static class WebhookHttpMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookHttpMethod value)
        {
            return value switch
            {
                WebhookHttpMethod.Delete => "DELETE",
                WebhookHttpMethod.Get => "GET",
                WebhookHttpMethod.Patch => "PATCH",
                WebhookHttpMethod.Post => "POST",
                WebhookHttpMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookHttpMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => WebhookHttpMethod.Delete,
                "GET" => WebhookHttpMethod.Get,
                "PATCH" => WebhookHttpMethod.Patch,
                "POST" => WebhookHttpMethod.Post,
                "PUT" => WebhookHttpMethod.Put,
                _ => null,
            };
        }
    }
}