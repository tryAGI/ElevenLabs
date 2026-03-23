
#nullable enable

namespace ElevenLabs.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServerEventDiscriminatorMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        CommittedTranscript,
        /// <summary>
        /// 
        /// </summary>
        CommittedTranscriptWithTimestamps,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        PartialTranscript,
        /// <summary>
        /// 
        /// </summary>
        SessionStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerEventDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorMessageType value)
        {
            return value switch
            {
                ServerEventDiscriminatorMessageType.CommittedTranscript => "committed_transcript",
                ServerEventDiscriminatorMessageType.CommittedTranscriptWithTimestamps => "committed_transcript_with_timestamps",
                ServerEventDiscriminatorMessageType.Error => "error",
                ServerEventDiscriminatorMessageType.PartialTranscript => "partial_transcript",
                ServerEventDiscriminatorMessageType.SessionStarted => "session_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "committed_transcript" => ServerEventDiscriminatorMessageType.CommittedTranscript,
                "committed_transcript_with_timestamps" => ServerEventDiscriminatorMessageType.CommittedTranscriptWithTimestamps,
                "error" => ServerEventDiscriminatorMessageType.Error,
                "partial_transcript" => ServerEventDiscriminatorMessageType.PartialTranscript,
                "session_started" => ServerEventDiscriminatorMessageType.SessionStarted,
                _ => null,
            };
        }
    }
}