
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum MusicFinetuneStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MusicFinetuneStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MusicFinetuneStatus value)
        {
            return value switch
            {
                MusicFinetuneStatus.Blocked => "blocked",
                MusicFinetuneStatus.Completed => "completed",
                MusicFinetuneStatus.Failed => "failed",
                MusicFinetuneStatus.InProgress => "in_progress",
                MusicFinetuneStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MusicFinetuneStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => MusicFinetuneStatus.Blocked,
                "completed" => MusicFinetuneStatus.Completed,
                "failed" => MusicFinetuneStatus.Failed,
                "in_progress" => MusicFinetuneStatus.InProgress,
                "pending" => MusicFinetuneStatus.Pending,
                _ => null,
            };
        }
    }
}