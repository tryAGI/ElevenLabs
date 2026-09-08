
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum VoiceResponseModelLabellingStatus
    {
        /// <summary>
        ///
        /// </summary>
        InReview,
        /// <summary>
        ///
        /// </summary>
        ReviewComplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceResponseModelLabellingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResponseModelLabellingStatus value)
        {
            return value switch
            {
                VoiceResponseModelLabellingStatus.InReview => "in_review",
                VoiceResponseModelLabellingStatus.ReviewComplete => "review_complete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResponseModelLabellingStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_review" => VoiceResponseModelLabellingStatus.InReview,
                "review_complete" => VoiceResponseModelLabellingStatus.ReviewComplete,
                _ => null,
            };
        }
    }
}