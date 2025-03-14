
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTwilioPhoneCallModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTwilioPhoneCallModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTwilioPhoneCallModelType value)
        {
            return value switch
            {
                ConversationHistoryTwilioPhoneCallModelType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTwilioPhoneCallModelType? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => ConversationHistoryTwilioPhoneCallModelType.Twilio,
                _ => null,
            };
        }
    }
}