
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsersSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        LastContactUnixSecs,
        /// <summary>
        /// 
        /// </summary>
        ConversationCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsersSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersSortBy value)
        {
            return value switch
            {
                UsersSortBy.LastContactUnixSecs => "last_contact_unix_secs",
                UsersSortBy.ConversationCount => "conversation_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersSortBy? ToEnum(string value)
        {
            return value switch
            {
                "last_contact_unix_secs" => UsersSortBy.LastContactUnixSecs,
                "conversation_count" => UsersSortBy.ConversationCount,
                _ => null,
            };
        }
    }
}