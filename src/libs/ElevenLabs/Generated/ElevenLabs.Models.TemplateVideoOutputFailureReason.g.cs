
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TemplateVideoOutputFailureReason
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
    public static class TemplateVideoOutputFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateVideoOutputFailureReason value)
        {
            return value switch
            {
                TemplateVideoOutputFailureReason.ChargingFailed => "charging_failed",
                TemplateVideoOutputFailureReason.DependencyFailed => "dependency_failed",
                TemplateVideoOutputFailureReason.InternalError => "internal_error",
                TemplateVideoOutputFailureReason.InvalidParameters => "invalid_parameters",
                TemplateVideoOutputFailureReason.ModelError => "model_error",
                TemplateVideoOutputFailureReason.Moderated => "moderated",
                TemplateVideoOutputFailureReason.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateVideoOutputFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "charging_failed" => TemplateVideoOutputFailureReason.ChargingFailed,
                "dependency_failed" => TemplateVideoOutputFailureReason.DependencyFailed,
                "internal_error" => TemplateVideoOutputFailureReason.InternalError,
                "invalid_parameters" => TemplateVideoOutputFailureReason.InvalidParameters,
                "model_error" => TemplateVideoOutputFailureReason.ModelError,
                "moderated" => TemplateVideoOutputFailureReason.Moderated,
                "timeout" => TemplateVideoOutputFailureReason.Timeout,
                _ => null,
            };
        }
    }
}