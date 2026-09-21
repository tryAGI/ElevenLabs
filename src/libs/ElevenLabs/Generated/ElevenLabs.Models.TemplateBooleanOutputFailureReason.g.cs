
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TemplateBooleanOutputFailureReason
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
    public static class TemplateBooleanOutputFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateBooleanOutputFailureReason value)
        {
            return value switch
            {
                TemplateBooleanOutputFailureReason.ChargingFailed => "charging_failed",
                TemplateBooleanOutputFailureReason.DependencyFailed => "dependency_failed",
                TemplateBooleanOutputFailureReason.InternalError => "internal_error",
                TemplateBooleanOutputFailureReason.InvalidParameters => "invalid_parameters",
                TemplateBooleanOutputFailureReason.ModelError => "model_error",
                TemplateBooleanOutputFailureReason.Moderated => "moderated",
                TemplateBooleanOutputFailureReason.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateBooleanOutputFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "charging_failed" => TemplateBooleanOutputFailureReason.ChargingFailed,
                "dependency_failed" => TemplateBooleanOutputFailureReason.DependencyFailed,
                "internal_error" => TemplateBooleanOutputFailureReason.InternalError,
                "invalid_parameters" => TemplateBooleanOutputFailureReason.InvalidParameters,
                "model_error" => TemplateBooleanOutputFailureReason.ModelError,
                "moderated" => TemplateBooleanOutputFailureReason.Moderated,
                "timeout" => TemplateBooleanOutputFailureReason.Timeout,
                _ => null,
            };
        }
    }
}