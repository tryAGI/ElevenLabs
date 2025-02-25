
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ReviewState
    {
        /// <summary>
        /// 
        /// </summary>
        Unclaimed,
        /// <summary>
        /// 
        /// </summary>
        Claimed,
        /// <summary>
        /// 
        /// </summary>
        Submitted,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewState value)
        {
            return value switch
            {
                ReviewState.Unclaimed => "unclaimed",
                ReviewState.Claimed => "claimed",
                ReviewState.Submitted => "submitted",
                ReviewState.Done => "done",
                ReviewState.Rejected => "rejected",
                ReviewState.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewState? ToEnum(string value)
        {
            return value switch
            {
                "unclaimed" => ReviewState.Unclaimed,
                "claimed" => ReviewState.Claimed,
                "submitted" => ReviewState.Submitted,
                "done" => ReviewState.Done,
                "rejected" => ReviewState.Rejected,
                "in_progress" => ReviewState.InProgress,
                _ => null,
            };
        }
    }
}