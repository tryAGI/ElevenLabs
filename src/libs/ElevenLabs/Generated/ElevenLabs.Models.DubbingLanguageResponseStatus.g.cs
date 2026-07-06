
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Lifecycle status: 'queued' (waiting on the project), 'processing', 'completed', 'stale' (source/transcript changed), or 'failed'.
    /// </summary>
    public enum DubbingLanguageResponseStatus
    {
        /// <summary>
        /// 'queued' (waiting on the project), 'processing', 'completed', 'stale' (source/transcript changed), or 'failed'.
        /// </summary>
        Completed,
        /// <summary>
        /// 'queued' (waiting on the project), 'processing', 'completed', 'stale' (source/transcript changed), or 'failed'.
        /// </summary>
        Failed,
        /// <summary>
        /// 'queued' (waiting on the project), 'processing', 'completed', 'stale' (source/transcript changed), or 'failed'.
        /// </summary>
        Processing,
        /// <summary>
        /// 'queued' (waiting on the project), 'processing', 'completed', 'stale' (source/transcript changed), or 'failed'.
        /// </summary>
        Queued,
        /// <summary>
        /// 'queued' (waiting on the project), 'processing', 'completed', 'stale' (source/transcript changed), or 'failed'.
        /// </summary>
        Stale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DubbingLanguageResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbingLanguageResponseStatus value)
        {
            return value switch
            {
                DubbingLanguageResponseStatus.Completed => "completed",
                DubbingLanguageResponseStatus.Failed => "failed",
                DubbingLanguageResponseStatus.Processing => "processing",
                DubbingLanguageResponseStatus.Queued => "queued",
                DubbingLanguageResponseStatus.Stale => "stale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbingLanguageResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DubbingLanguageResponseStatus.Completed,
                "failed" => DubbingLanguageResponseStatus.Failed,
                "processing" => DubbingLanguageResponseStatus.Processing,
                "queued" => DubbingLanguageResponseStatus.Queued,
                "stale" => DubbingLanguageResponseStatus.Stale,
                _ => null,
            };
        }
    }
}