
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookOutcome
    {
        /// <summary>
        ///
        /// </summary>
        Delivered,
        /// <summary>
        ///
        /// </summary>
        DroppedPayloadTooLarge,
        /// <summary>
        ///
        /// </summary>
        DroppedQueueFull,
        /// <summary>
        ///
        /// </summary>
        FailedExhausted,
        /// <summary>
        ///
        /// </summary>
        FailedNoRetry,
        /// <summary>
        ///
        /// </summary>
        FailedRetryError,
        /// <summary>
        ///
        /// </summary>
        FailedRetryScheduled,
        /// <summary>
        ///
        /// </summary>
        NotSentConfiguration,
        /// <summary>
        ///
        /// </summary>
        SkippedDisabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookOutcome value)
        {
            return value switch
            {
                WebhookOutcome.Delivered => "delivered",
                WebhookOutcome.DroppedPayloadTooLarge => "dropped_payload_too_large",
                WebhookOutcome.DroppedQueueFull => "dropped_queue_full",
                WebhookOutcome.FailedExhausted => "failed_exhausted",
                WebhookOutcome.FailedNoRetry => "failed_no_retry",
                WebhookOutcome.FailedRetryError => "failed_retry_error",
                WebhookOutcome.FailedRetryScheduled => "failed_retry_scheduled",
                WebhookOutcome.NotSentConfiguration => "not_sent_configuration",
                WebhookOutcome.SkippedDisabled => "skipped_disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookOutcome? ToEnum(string value)
        {
            return value switch
            {
                "delivered" => WebhookOutcome.Delivered,
                "dropped_payload_too_large" => WebhookOutcome.DroppedPayloadTooLarge,
                "dropped_queue_full" => WebhookOutcome.DroppedQueueFull,
                "failed_exhausted" => WebhookOutcome.FailedExhausted,
                "failed_no_retry" => WebhookOutcome.FailedNoRetry,
                "failed_retry_error" => WebhookOutcome.FailedRetryError,
                "failed_retry_scheduled" => WebhookOutcome.FailedRetryScheduled,
                "not_sent_configuration" => WebhookOutcome.NotSentConfiguration,
                "skipped_disabled" => WebhookOutcome.SkippedDisabled,
                _ => null,
            };
        }
    }
}