
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationSentimentAnalysisOverallLabel
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
    public static class ConversationSentimentAnalysisOverallLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationSentimentAnalysisOverallLabel value)
        {
            return value switch
            {
                ConversationSentimentAnalysisOverallLabel.Negative => "negative",
                ConversationSentimentAnalysisOverallLabel.Neutral => "neutral",
                ConversationSentimentAnalysisOverallLabel.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationSentimentAnalysisOverallLabel? ToEnum(string value)
        {
            return value switch
            {
                "negative" => ConversationSentimentAnalysisOverallLabel.Negative,
                "neutral" => ConversationSentimentAnalysisOverallLabel.Neutral,
                "positive" => ConversationSentimentAnalysisOverallLabel.Positive,
                _ => null,
            };
        }
    }
}