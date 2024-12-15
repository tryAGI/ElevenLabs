
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: GET
    /// </summary>
    public enum WebhookToolApiSchemaConfigMethod
    {
        /// <summary>
        /// 
        /// </summary>
        GET,
        /// <summary>
        /// 
        /// </summary>
        POST,
        /// <summary>
        /// 
        /// </summary>
        PATCH,
        /// <summary>
        /// 
        /// </summary>
        DELETE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookToolApiSchemaConfigMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookToolApiSchemaConfigMethod value)
        {
            return value switch
            {
                WebhookToolApiSchemaConfigMethod.GET => "GET",
                WebhookToolApiSchemaConfigMethod.POST => "POST",
                WebhookToolApiSchemaConfigMethod.PATCH => "PATCH",
                WebhookToolApiSchemaConfigMethod.DELETE => "DELETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookToolApiSchemaConfigMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => WebhookToolApiSchemaConfigMethod.GET,
                "POST" => WebhookToolApiSchemaConfigMethod.POST,
                "PATCH" => WebhookToolApiSchemaConfigMethod.PATCH,
                "DELETE" => WebhookToolApiSchemaConfigMethod.DELETE,
                _ => null,
            };
        }
    }
}