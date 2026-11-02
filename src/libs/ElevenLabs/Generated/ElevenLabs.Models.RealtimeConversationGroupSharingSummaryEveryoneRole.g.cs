
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeConversationGroupSharingSummaryEveryoneRole
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Commenter,
        /// <summary>
        ///
        /// </summary>
        Editor,
        /// <summary>
        ///
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationGroupSharingSummaryEveryoneRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationGroupSharingSummaryEveryoneRole value)
        {
            return value switch
            {
                RealtimeConversationGroupSharingSummaryEveryoneRole.Admin => "admin",
                RealtimeConversationGroupSharingSummaryEveryoneRole.Commenter => "commenter",
                RealtimeConversationGroupSharingSummaryEveryoneRole.Editor => "editor",
                RealtimeConversationGroupSharingSummaryEveryoneRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationGroupSharingSummaryEveryoneRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => RealtimeConversationGroupSharingSummaryEveryoneRole.Admin,
                "commenter" => RealtimeConversationGroupSharingSummaryEveryoneRole.Commenter,
                "editor" => RealtimeConversationGroupSharingSummaryEveryoneRole.Editor,
                "viewer" => RealtimeConversationGroupSharingSummaryEveryoneRole.Viewer,
                _ => null,
            };
        }
    }
}