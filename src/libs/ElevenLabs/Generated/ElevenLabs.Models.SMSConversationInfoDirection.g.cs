
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum SMSConversationInfoDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SMSConversationInfoDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMSConversationInfoDirection value)
        {
            return value switch
            {
                SMSConversationInfoDirection.Inbound => "inbound",
                SMSConversationInfoDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMSConversationInfoDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => SMSConversationInfoDirection.Inbound,
                "outbound" => SMSConversationInfoDirection.Outbound,
                _ => null,
            };
        }
    }
}