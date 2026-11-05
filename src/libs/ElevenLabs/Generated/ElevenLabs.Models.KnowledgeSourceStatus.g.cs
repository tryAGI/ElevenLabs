
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Processing status for knowledge sources.<br/>
    /// - `processing`: the file or site is being read.<br/>
    /// - `ready`: done; the results are available.<br/>
    /// - `error`: it failed and can be retried.<br/>
    /// See `progress` for detail.<br/>
    /// Default Value: processing
    /// </summary>
    public enum KnowledgeSourceStatus
    {
        /// <summary>
        /// it failed and can be retried.
        /// </summary>
        Error,
        /// <summary>
        /// the file or site is being read.
        /// </summary>
        Processing,
        /// <summary>
        /// done; the results are available.
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