
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConversationSummaryResponseModelStatus
    {
        /// <summary>
        ///
        /// </summary>
        Done,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Initiated,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConversationSummaryResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConversationSummaryResponseModelStatus value)
        {
            return value switch
            {
                GetConversationSummaryResponseModelStatus.Done => "done",
                GetConversationSummaryResponseModelStatus.Failed => "failed",
                GetConversationSummaryResponseModelStatus.InProgress => "in-progress",
                GetConversationSummaryResponseModelStatus.Initiated => "initiated",
                GetConversationSummaryResponseModelStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConversationSummaryResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => GetConversationSummaryResponseModelStatus.Done,
                "failed" => GetConversationSummaryResponseModelStatus.Failed,
                "in-progress" => GetConversationSummaryResponseModelStatus.InProgress,
                "initiated" => GetConversationSummaryResponseModelStatus.Initiated,
                "processing" => GetConversationSummaryResponseModelStatus.Processing,
                _ => null,
            };
        }
    }
}