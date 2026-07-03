
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Lifecycle status of the project: 'preparing'/'processing' while it transcribes, 'ready' once transcription is done, or 'failed'.
    /// </summary>
    public enum ProjectResponseStatus
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
    public static class ProjectResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseStatus value)
        {
            return value switch
            {
                ProjectResponseStatus.Failed => "failed",
                ProjectResponseStatus.Preparing => "preparing",
                ProjectResponseStatus.Processing => "processing",
                ProjectResponseStatus.Queued => "queued",
                ProjectResponseStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ProjectResponseStatus.Failed,
                "preparing" => ProjectResponseStatus.Preparing,
                "processing" => ProjectResponseStatus.Processing,
                "queued" => ProjectResponseStatus.Queued,
                "ready" => ProjectResponseStatus.Ready,
                _ => null,
            };
        }
    }
}