
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TranscriptPlatformEvent
    {
        /// <summary>
        ///
        /// </summary>
        SkipTurnWaitElapsed,
        /// <summary>
        ///
        /// </summary>
        UserTurnTimeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptPlatformEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptPlatformEvent value)
        {
            return value switch
            {
                TranscriptPlatformEvent.SkipTurnWaitElapsed => "skip_turn_wait_elapsed",
                TranscriptPlatformEvent.UserTurnTimeout => "user_turn_timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptPlatformEvent? ToEnum(string value)
        {
            return value switch
            {
                "skip_turn_wait_elapsed" => TranscriptPlatformEvent.SkipTurnWaitElapsed,
                "user_turn_timeout" => TranscriptPlatformEvent.UserTurnTimeout,
                _ => null,
            };
        }
    }
}