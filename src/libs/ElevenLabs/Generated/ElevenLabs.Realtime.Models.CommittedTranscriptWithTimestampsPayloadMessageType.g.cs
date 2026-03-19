
#nullable enable

namespace ElevenLabs.Realtime
{
    /// <summary>
    /// Must be 'committed_transcript_with_timestamps'.
    /// </summary>
    public enum CommittedTranscriptWithTimestampsPayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        CommittedTranscriptWithTimestamps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommittedTranscriptWithTimestampsPayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommittedTranscriptWithTimestampsPayloadMessageType value)
        {
            return value switch
            {
                CommittedTranscriptWithTimestampsPayloadMessageType.CommittedTranscriptWithTimestamps => "committed_transcript_with_timestamps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommittedTranscriptWithTimestampsPayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "committed_transcript_with_timestamps" => CommittedTranscriptWithTimestampsPayloadMessageType.CommittedTranscriptWithTimestamps,
                _ => null,
            };
        }
    }
}