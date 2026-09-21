
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TemplateImageOutputFailureReason
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
    public static class TemplateImageOutputFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateImageOutputFailureReason value)
        {
            return value switch
            {
                TemplateImageOutputFailureReason.ChargingFailed => "charging_failed",
                TemplateImageOutputFailureReason.DependencyFailed => "dependency_failed",
                TemplateImageOutputFailureReason.InternalError => "internal_error",
                TemplateImageOutputFailureReason.InvalidParameters => "invalid_parameters",
                TemplateImageOutputFailureReason.ModelError => "model_error",
                TemplateImageOutputFailureReason.Moderated => "moderated",
                TemplateImageOutputFailureReason.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateImageOutputFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "charging_failed" => TemplateImageOutputFailureReason.ChargingFailed,
                "dependency_failed" => TemplateImageOutputFailureReason.DependencyFailed,
                "internal_error" => TemplateImageOutputFailureReason.InternalError,
                "invalid_parameters" => TemplateImageOutputFailureReason.InvalidParameters,
                "model_error" => TemplateImageOutputFailureReason.ModelError,
                "moderated" => TemplateImageOutputFailureReason.Moderated,
                "timeout" => TemplateImageOutputFailureReason.Timeout,
                _ => null,
            };
        }
    }
}