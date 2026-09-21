
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TemplateObjectOutputFailureReason
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
    public static class TemplateObjectOutputFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateObjectOutputFailureReason value)
        {
            return value switch
            {
                TemplateObjectOutputFailureReason.ChargingFailed => "charging_failed",
                TemplateObjectOutputFailureReason.DependencyFailed => "dependency_failed",
                TemplateObjectOutputFailureReason.InternalError => "internal_error",
                TemplateObjectOutputFailureReason.InvalidParameters => "invalid_parameters",
                TemplateObjectOutputFailureReason.ModelError => "model_error",
                TemplateObjectOutputFailureReason.Moderated => "moderated",
                TemplateObjectOutputFailureReason.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateObjectOutputFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "charging_failed" => TemplateObjectOutputFailureReason.ChargingFailed,
                "dependency_failed" => TemplateObjectOutputFailureReason.DependencyFailed,
                "internal_error" => TemplateObjectOutputFailureReason.InternalError,
                "invalid_parameters" => TemplateObjectOutputFailureReason.InvalidParameters,
                "model_error" => TemplateObjectOutputFailureReason.ModelError,
                "moderated" => TemplateObjectOutputFailureReason.Moderated,
                "timeout" => TemplateObjectOutputFailureReason.Timeout,
                _ => null,
            };
        }
    }
}