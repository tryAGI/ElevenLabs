
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CallResult
    {
        /// <summary>
        ///
        /// </summary>
        Answered,
        /// <summary>
        ///
        /// </summary>
        Busy,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        NoAnswer,
        /// <summary>
        ///
        /// </summary>
        Voicemail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallResult value)
        {
            return value switch
            {
                CallResult.Answered => "answered",
                CallResult.Busy => "busy",
                CallResult.Failed => "failed",
                CallResult.NoAnswer => "no_answer",
                CallResult.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallResult? ToEnum(string value)
        {
            return value switch
            {
                "answered" => CallResult.Answered,
                "busy" => CallResult.Busy,
                "failed" => CallResult.Failed,
                "no_answer" => CallResult.NoAnswer,
                "voicemail" => CallResult.Voicemail,
                _ => null,
            };
        }
    }
}