
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum FrustratedConversationRefOverallLabel
    {
        /// <summary>
        /// 
        /// </summary>
        Negative,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Positive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FrustratedConversationRefOverallLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FrustratedConversationRefOverallLabel value)
        {
            return value switch
            {
                FrustratedConversationRefOverallLabel.Negative => "negative",
                FrustratedConversationRefOverallLabel.Neutral => "neutral",
                FrustratedConversationRefOverallLabel.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FrustratedConversationRefOverallLabel? ToEnum(string value)
        {
            return value switch
            {
                "negative" => FrustratedConversationRefOverallLabel.Negative,
                "neutral" => FrustratedConversationRefOverallLabel.Neutral,
                "positive" => FrustratedConversationRefOverallLabel.Positive,
                _ => null,
            };
        }
    }
}