
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: json
    /// </summary>
    public enum WebhookTranscriptFormat
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
    public static class WebhookTranscriptFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTranscriptFormat value)
        {
            return value switch
            {
                WebhookTranscriptFormat.Json => "json",
                WebhookTranscriptFormat.Opentelemetry => "opentelemetry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTranscriptFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => WebhookTranscriptFormat.Json,
                "opentelemetry" => WebhookTranscriptFormat.Opentelemetry,
                _ => null,
            };
        }
    }
}