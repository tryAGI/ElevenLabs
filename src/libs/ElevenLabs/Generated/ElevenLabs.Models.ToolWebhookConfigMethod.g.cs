
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: GET
    /// </summary>
    public enum ToolWebhookConfigMethod
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
    public static class ToolWebhookConfigMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolWebhookConfigMethod value)
        {
            return value switch
            {
                ToolWebhookConfigMethod.GET => "GET",
                ToolWebhookConfigMethod.POST => "POST",
                ToolWebhookConfigMethod.PATCH => "PATCH",
                ToolWebhookConfigMethod.DELETE => "DELETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolWebhookConfigMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => ToolWebhookConfigMethod.GET,
                "POST" => ToolWebhookConfigMethod.POST,
                "PATCH" => ToolWebhookConfigMethod.PATCH,
                "DELETE" => ToolWebhookConfigMethod.DELETE,
                _ => null,
            };
        }
    }
}