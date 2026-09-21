
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TemplateArrayOutputFailureReason
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
    public static class TemplateArrayOutputFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateArrayOutputFailureReason value)
        {
            return value switch
            {
                TemplateArrayOutputFailureReason.ChargingFailed => "charging_failed",
                TemplateArrayOutputFailureReason.DependencyFailed => "dependency_failed",
                TemplateArrayOutputFailureReason.InternalError => "internal_error",
                TemplateArrayOutputFailureReason.InvalidParameters => "invalid_parameters",
                TemplateArrayOutputFailureReason.ModelError => "model_error",
                TemplateArrayOutputFailureReason.Moderated => "moderated",
                TemplateArrayOutputFailureReason.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateArrayOutputFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "charging_failed" => TemplateArrayOutputFailureReason.ChargingFailed,
                "dependency_failed" => TemplateArrayOutputFailureReason.DependencyFailed,
                "internal_error" => TemplateArrayOutputFailureReason.InternalError,
                "invalid_parameters" => TemplateArrayOutputFailureReason.InvalidParameters,
                "model_error" => TemplateArrayOutputFailureReason.ModelError,
                "moderated" => TemplateArrayOutputFailureReason.Moderated,
                "timeout" => TemplateArrayOutputFailureReason.Timeout,
                _ => null,
            };
        }
    }
}