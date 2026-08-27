
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The category of failure.
    /// </summary>
    public enum MediaGenerationFailedResponseFailureReason
    {
        /// <summary>
        ///
        /// </summary>
        ChargingFailed,
        /// <summary>
        ///
        /// </summary>
        DependencyFailed,
        /// <summary>
        ///
        /// </summary>
        InternalError,
        /// <summary>
        ///
        /// </summary>
        InvalidParameters,
        /// <summary>
        ///
        /// </summary>
        ModelError,
        /// <summary>
        ///
        /// </summary>
        Moderated,
        /// <summary>
        ///
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MediaGenerationFailedResponseFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MediaGenerationFailedResponseFailureReason value)
        {
            return value switch
            {
                MediaGenerationFailedResponseFailureReason.ChargingFailed => "charging_failed",
                MediaGenerationFailedResponseFailureReason.DependencyFailed => "dependency_failed",
                MediaGenerationFailedResponseFailureReason.InternalError => "internal_error",
                MediaGenerationFailedResponseFailureReason.InvalidParameters => "invalid_parameters",
                MediaGenerationFailedResponseFailureReason.ModelError => "model_error",
                MediaGenerationFailedResponseFailureReason.Moderated => "moderated",
                MediaGenerationFailedResponseFailureReason.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MediaGenerationFailedResponseFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "charging_failed" => MediaGenerationFailedResponseFailureReason.ChargingFailed,
                "dependency_failed" => MediaGenerationFailedResponseFailureReason.DependencyFailed,
                "internal_error" => MediaGenerationFailedResponseFailureReason.InternalError,
                "invalid_parameters" => MediaGenerationFailedResponseFailureReason.InvalidParameters,
                "model_error" => MediaGenerationFailedResponseFailureReason.ModelError,
                "moderated" => MediaGenerationFailedResponseFailureReason.Moderated,
                "timeout" => MediaGenerationFailedResponseFailureReason.Timeout,
                _ => null,
            };
        }
    }
}