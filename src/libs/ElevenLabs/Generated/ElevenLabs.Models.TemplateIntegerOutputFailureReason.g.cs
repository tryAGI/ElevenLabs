
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TemplateIntegerOutputFailureReason
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
    public static class TemplateIntegerOutputFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateIntegerOutputFailureReason value)
        {
            return value switch
            {
                TemplateIntegerOutputFailureReason.ChargingFailed => "charging_failed",
                TemplateIntegerOutputFailureReason.DependencyFailed => "dependency_failed",
                TemplateIntegerOutputFailureReason.InternalError => "internal_error",
                TemplateIntegerOutputFailureReason.InvalidParameters => "invalid_parameters",
                TemplateIntegerOutputFailureReason.ModelError => "model_error",
                TemplateIntegerOutputFailureReason.Moderated => "moderated",
                TemplateIntegerOutputFailureReason.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateIntegerOutputFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "charging_failed" => TemplateIntegerOutputFailureReason.ChargingFailed,
                "dependency_failed" => TemplateIntegerOutputFailureReason.DependencyFailed,
                "internal_error" => TemplateIntegerOutputFailureReason.InternalError,
                "invalid_parameters" => TemplateIntegerOutputFailureReason.InvalidParameters,
                "model_error" => TemplateIntegerOutputFailureReason.ModelError,
                "moderated" => TemplateIntegerOutputFailureReason.Moderated,
                "timeout" => TemplateIntegerOutputFailureReason.Timeout,
                _ => null,
            };
        }
    }
}