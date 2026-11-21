
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AttentionStatus
    {
        /// <summary>
        ///
        /// </summary>
        Open,
        /// <summary>
        ///
        /// </summary>
        Resolved,
        /// <summary>
        ///
        /// </summary>
        Retrying,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AttentionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AttentionStatus value)
        {
            return value switch
            {
                AttentionStatus.Open => "open",
                AttentionStatus.Resolved => "resolved",
                AttentionStatus.Retrying => "retrying",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AttentionStatus? ToEnum(string value)
        {
            return value switch
            {
                "open" => AttentionStatus.Open,
                "resolved" => AttentionStatus.Resolved,
                "retrying" => AttentionStatus.Retrying,
                _ => null,
            };
        }
    }
}