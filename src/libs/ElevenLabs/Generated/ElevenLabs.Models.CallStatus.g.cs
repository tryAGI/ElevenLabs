
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CallStatus
    {
        /// <summary>
        ///
        /// </summary>
        Attention,
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Submitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallStatus value)
        {
            return value switch
            {
                CallStatus.Attention => "attention",
                CallStatus.Cancelled => "cancelled",
                CallStatus.Completed => "completed",
                CallStatus.Queued => "queued",
                CallStatus.Submitted => "submitted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallStatus? ToEnum(string value)
        {
            return value switch
            {
                "attention" => CallStatus.Attention,
                "cancelled" => CallStatus.Cancelled,
                "completed" => CallStatus.Completed,
                "queued" => CallStatus.Queued,
                "submitted" => CallStatus.Submitted,
                _ => null,
            };
        }
    }
}