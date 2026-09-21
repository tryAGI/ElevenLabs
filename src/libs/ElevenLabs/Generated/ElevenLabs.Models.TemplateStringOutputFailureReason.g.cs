
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TemplateStringOutputFailureReason
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
    public static class TemplateStringOutputFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateStringOutputFailureReason value)
        {
            return value switch
            {
                TemplateStringOutputFailureReason.ChargingFailed => "charging_failed",
                TemplateStringOutputFailureReason.DependencyFailed => "dependency_failed",
                TemplateStringOutputFailureReason.InternalError => "internal_error",
                TemplateStringOutputFailureReason.InvalidParameters => "invalid_parameters",
                TemplateStringOutputFailureReason.ModelError => "model_error",
                TemplateStringOutputFailureReason.Moderated => "moderated",
                TemplateStringOutputFailureReason.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateStringOutputFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "charging_failed" => TemplateStringOutputFailureReason.ChargingFailed,
                "dependency_failed" => TemplateStringOutputFailureReason.DependencyFailed,
                "internal_error" => TemplateStringOutputFailureReason.InternalError,
                "invalid_parameters" => TemplateStringOutputFailureReason.InvalidParameters,
                "model_error" => TemplateStringOutputFailureReason.ModelError,
                "moderated" => TemplateStringOutputFailureReason.Moderated,
                "timeout" => TemplateStringOutputFailureReason.Timeout,
                _ => null,
            };
        }
    }
}