
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind value)
        {
            return value switch
            {
                SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind.Error => "error",
                SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "error" => SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind.Error,
                "transcript" => SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind.Transcript,
                _ => null,
            };
        }
    }
}