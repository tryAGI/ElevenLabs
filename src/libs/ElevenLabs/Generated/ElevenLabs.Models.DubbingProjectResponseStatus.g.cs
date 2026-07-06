
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Lifecycle status of the project: 'preparing'/'processing' while it transcribes, 'ready' once transcription is done, or 'failed'.
    /// </summary>
    public enum DubbingProjectResponseStatus
    {
        /// <summary>
        /// 'preparing'/'processing' while it transcribes, 'ready' once transcription is done, or 'failed'.
        /// </summary>
        Failed,
        /// <summary>
        /// 'preparing'/'processing' while it transcribes, 'ready' once transcription is done, or 'failed'.
        /// </summary>
        Preparing,
        /// <summary>
        /// 'preparing'/'processing' while it transcribes, 'ready' once transcription is done, or 'failed'.
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 'preparing'/'processing' while it transcribes, 'ready' once transcription is done, or 'failed'.
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DubbingProjectResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbingProjectResponseStatus value)
        {
            return value switch
            {
                DubbingProjectResponseStatus.Failed => "failed",
                DubbingProjectResponseStatus.Preparing => "preparing",
                DubbingProjectResponseStatus.Processing => "processing",
                DubbingProjectResponseStatus.Queued => "queued",
                DubbingProjectResponseStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbingProjectResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => DubbingProjectResponseStatus.Failed,
                "preparing" => DubbingProjectResponseStatus.Preparing,
                "processing" => DubbingProjectResponseStatus.Processing,
                "queued" => DubbingProjectResponseStatus.Queued,
                "ready" => DubbingProjectResponseStatus.Ready,
                _ => null,
            };
        }
    }
}