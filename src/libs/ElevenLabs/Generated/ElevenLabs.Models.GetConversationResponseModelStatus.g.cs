
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConversationResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Done,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConversationResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConversationResponseModelStatus value)
        {
            return value switch
            {
                GetConversationResponseModelStatus.Processing => "processing",
                GetConversationResponseModelStatus.Done => "done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConversationResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "processing" => GetConversationResponseModelStatus.Processing,
                "done" => GetConversationResponseModelStatus.Done,
                _ => null,
            };
        }
    }
}