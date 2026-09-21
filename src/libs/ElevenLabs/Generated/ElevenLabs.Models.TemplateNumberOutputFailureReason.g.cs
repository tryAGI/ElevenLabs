
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TemplateNumberOutputFailureReason
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
    public static class TemplateNumberOutputFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateNumberOutputFailureReason value)
        {
            return value switch
            {
                TemplateNumberOutputFailureReason.ChargingFailed => "charging_failed",
                TemplateNumberOutputFailureReason.DependencyFailed => "dependency_failed",
                TemplateNumberOutputFailureReason.InternalError => "internal_error",
                TemplateNumberOutputFailureReason.InvalidParameters => "invalid_parameters",
                TemplateNumberOutputFailureReason.ModelError => "model_error",
                TemplateNumberOutputFailureReason.Moderated => "moderated",
                TemplateNumberOutputFailureReason.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateNumberOutputFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "charging_failed" => TemplateNumberOutputFailureReason.ChargingFailed,
                "dependency_failed" => TemplateNumberOutputFailureReason.DependencyFailed,
                "internal_error" => TemplateNumberOutputFailureReason.InternalError,
                "invalid_parameters" => TemplateNumberOutputFailureReason.InvalidParameters,
                "model_error" => TemplateNumberOutputFailureReason.ModelError,
                "moderated" => TemplateNumberOutputFailureReason.Moderated,
                "timeout" => TemplateNumberOutputFailureReason.Timeout,
                _ => null,
            };
        }
    }
}