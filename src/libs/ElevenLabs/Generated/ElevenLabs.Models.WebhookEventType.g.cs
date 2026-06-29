
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        CallInitiationFailure,
        /// <summary>
        /// 
        /// </summary>
        Transcript,
        /// <summary>
        /// 
        /// </summary>
        UnredactedAudio,
        /// <summary>
        /// 
        /// </summary>
        UnredactedTranscript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEventType value)
        {
            return value switch
            {
                WebhookEventType.Audio => "audio",
                WebhookEventType.CallInitiationFailure => "call_initiation_failure",
                WebhookEventType.Transcript => "transcript",
                WebhookEventType.UnredactedAudio => "unredacted_audio",
                WebhookEventType.UnredactedTranscript => "unredacted_transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEventType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => WebhookEventType.Audio,
                "call_initiation_failure" => WebhookEventType.CallInitiationFailure,
                "transcript" => WebhookEventType.Transcript,
                "unredacted_audio" => WebhookEventType.UnredactedAudio,
                "unredacted_transcript" => WebhookEventType.UnredactedTranscript,
                _ => null,
            };
        }
    }
}