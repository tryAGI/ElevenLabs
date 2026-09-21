
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TemplateAudioOutputFailureReason
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
    public static class TemplateAudioOutputFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateAudioOutputFailureReason value)
        {
            return value switch
            {
                TemplateAudioOutputFailureReason.ChargingFailed => "charging_failed",
                TemplateAudioOutputFailureReason.DependencyFailed => "dependency_failed",
                TemplateAudioOutputFailureReason.InternalError => "internal_error",
                TemplateAudioOutputFailureReason.InvalidParameters => "invalid_parameters",
                TemplateAudioOutputFailureReason.ModelError => "model_error",
                TemplateAudioOutputFailureReason.Moderated => "moderated",
                TemplateAudioOutputFailureReason.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateAudioOutputFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "charging_failed" => TemplateAudioOutputFailureReason.ChargingFailed,
                "dependency_failed" => TemplateAudioOutputFailureReason.DependencyFailed,
                "internal_error" => TemplateAudioOutputFailureReason.InternalError,
                "invalid_parameters" => TemplateAudioOutputFailureReason.InvalidParameters,
                "model_error" => TemplateAudioOutputFailureReason.ModelError,
                "moderated" => TemplateAudioOutputFailureReason.Moderated,
                "timeout" => TemplateAudioOutputFailureReason.Timeout,
                _ => null,
            };
        }
    }
}