
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Processing status for knowledge sources.<br/>
    /// Simple three-state machine:<br/>
    /// - PROCESSING: Any active work (uploading, crawling, extracting, etc.)<br/>
    /// - READY: Processing complete, results available<br/>
    /// - ERROR: Something went wrong (user can retry)<br/>
    /// Detailed progress is tracked via the `progress` field.<br/>
    /// Default Value: processing
    /// </summary>
    public enum KnowledgeSourceStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Processing,
        /// <summary>
        ///
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeSourceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeSourceStatus value)
        {
            return value switch
            {
                KnowledgeSourceStatus.Error => "error",
                KnowledgeSourceStatus.Processing => "processing",
                KnowledgeSourceStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeSourceStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => KnowledgeSourceStatus.Error,
                "processing" => KnowledgeSourceStatus.Processing,
                "ready" => KnowledgeSourceStatus.Ready,
                _ => null,
            };
        }
    }
}