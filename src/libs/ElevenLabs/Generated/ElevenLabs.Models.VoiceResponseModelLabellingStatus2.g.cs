
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceResponseModelLabellingStatus2
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
    public static class VoiceResponseModelLabellingStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResponseModelLabellingStatus2 value)
        {
            return value switch
            {
                VoiceResponseModelLabellingStatus2.InReview => "in_review",
                VoiceResponseModelLabellingStatus2.ReviewComplete => "review_complete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResponseModelLabellingStatus2? ToEnum(string value)
        {
            return value switch
            {
                "in_review" => VoiceResponseModelLabellingStatus2.InReview,
                "review_complete" => VoiceResponseModelLabellingStatus2.ReviewComplete,
                _ => null,
            };
        }
    }
}