
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Lifecycle status: 'queued' (waiting on the project), 'processing', 'completed', 'stale' (source/transcript changed), or 'failed'.
    /// </summary>
    public enum LanguageResponseStatus
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
    public static class LanguageResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageResponseStatus value)
        {
            return value switch
            {
                LanguageResponseStatus.Completed => "completed",
                LanguageResponseStatus.Failed => "failed",
                LanguageResponseStatus.Processing => "processing",
                LanguageResponseStatus.Queued => "queued",
                LanguageResponseStatus.Stale => "stale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => LanguageResponseStatus.Completed,
                "failed" => LanguageResponseStatus.Failed,
                "processing" => LanguageResponseStatus.Processing,
                "queued" => LanguageResponseStatus.Queued,
                "stale" => LanguageResponseStatus.Stale,
                _ => null,
            };
        }
    }
}