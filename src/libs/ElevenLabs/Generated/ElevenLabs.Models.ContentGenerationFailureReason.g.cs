
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentGenerationFailureReason
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
        ModelError,
        /// <summary>
        /// 
        /// </summary>
        Moderated,
        /// <summary>
        /// 
        /// </summary>
        NoImageReturned,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
        /// <summary>
        /// 
        /// </summary>
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentGenerationFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentGenerationFailureReason value)
        {
            return value switch
            {
                ContentGenerationFailureReason.ChargingFailed => "charging_failed",
                ContentGenerationFailureReason.DependencyFailed => "dependency_failed",
                ContentGenerationFailureReason.InternalError => "internal_error",
                ContentGenerationFailureReason.ModelError => "model_error",
                ContentGenerationFailureReason.Moderated => "moderated",
                ContentGenerationFailureReason.NoImageReturned => "no_image_returned",
                ContentGenerationFailureReason.Timeout => "timeout",
                ContentGenerationFailureReason.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentGenerationFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "charging_failed" => ContentGenerationFailureReason.ChargingFailed,
                "dependency_failed" => ContentGenerationFailureReason.DependencyFailed,
                "internal_error" => ContentGenerationFailureReason.InternalError,
                "model_error" => ContentGenerationFailureReason.ModelError,
                "moderated" => ContentGenerationFailureReason.Moderated,
                "no_image_returned" => ContentGenerationFailureReason.NoImageReturned,
                "timeout" => ContentGenerationFailureReason.Timeout,
                "validation_error" => ContentGenerationFailureReason.ValidationError,
                _ => null,
            };
        }
    }
}