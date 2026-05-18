
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response format. Defaults to 'json'. Set to 'opentelemetry' for an OTLP-compatible trace payload using the same structure as the post-call webhook.<br/>
    /// Default Value: json
    /// </summary>
    public enum GetConversationHistoryRouteFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Opentelemetry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConversationHistoryRouteFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConversationHistoryRouteFormat value)
        {
            return value switch
            {
                GetConversationHistoryRouteFormat.Json => "json",
                GetConversationHistoryRouteFormat.Opentelemetry => "opentelemetry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConversationHistoryRouteFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetConversationHistoryRouteFormat.Json,
                "opentelemetry" => GetConversationHistoryRouteFormat.Opentelemetry,
                _ => null,
            };
        }
    }
}