
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Whether to include transcript summaries in the response.<br/>
    /// Default Value: exclude
    /// </summary>
    public enum GetConversationsV1ConvaiConversationsGetSummaryMode
    {
        /// <summary>
        /// 
        /// </summary>
        Exclude,
        /// <summary>
        /// 
        /// </summary>
        Include,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConversationsV1ConvaiConversationsGetSummaryModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConversationsV1ConvaiConversationsGetSummaryMode value)
        {
            return value switch
            {
                GetConversationsV1ConvaiConversationsGetSummaryMode.Exclude => "exclude",
                GetConversationsV1ConvaiConversationsGetSummaryMode.Include => "include",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConversationsV1ConvaiConversationsGetSummaryMode? ToEnum(string value)
        {
            return value switch
            {
                "exclude" => GetConversationsV1ConvaiConversationsGetSummaryMode.Exclude,
                "include" => GetConversationsV1ConvaiConversationsGetSummaryMode.Include,
                _ => null,
            };
        }
    }
}