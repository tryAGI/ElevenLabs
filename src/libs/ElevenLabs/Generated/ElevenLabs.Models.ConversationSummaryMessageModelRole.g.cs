
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ConversationSummaryMessageModelRole
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationSummaryMessageModelRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationSummaryMessageModelRole value)
        {
            return value switch
            {
                ConversationSummaryMessageModelRole.Agent => "agent",
                ConversationSummaryMessageModelRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationSummaryMessageModelRole? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ConversationSummaryMessageModelRole.Agent,
                "user" => ConversationSummaryMessageModelRole.User,
                _ => null,
            };
        }
    }
}