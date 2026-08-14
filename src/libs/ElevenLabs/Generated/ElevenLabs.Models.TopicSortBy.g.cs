
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum TopicSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Conversations,
        /// <summary>
        /// 
        /// </summary>
        Sentiment,
        /// <summary>
        /// 
        /// </summary>
        SuccessRate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicSortBy value)
        {
            return value switch
            {
                TopicSortBy.Conversations => "conversations",
                TopicSortBy.Sentiment => "sentiment",
                TopicSortBy.SuccessRate => "success_rate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicSortBy? ToEnum(string value)
        {
            return value switch
            {
                "conversations" => TopicSortBy.Conversations,
                "sentiment" => TopicSortBy.Sentiment,
                "success_rate" => TopicSortBy.SuccessRate,
                _ => null,
            };
        }
    }
}