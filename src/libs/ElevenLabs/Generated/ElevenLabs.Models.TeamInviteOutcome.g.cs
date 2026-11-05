
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamInviteOutcome
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Invited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamInviteOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamInviteOutcome value)
        {
            return value switch
            {
                TeamInviteOutcome.Failed => "failed",
                TeamInviteOutcome.Invited => "invited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamInviteOutcome? ToEnum(string value)
        {
            return value switch
            {
                "failed" => TeamInviteOutcome.Failed,
                "invited" => TeamInviteOutcome.Invited,
                _ => null,
            };
        }
    }
}