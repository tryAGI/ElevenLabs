
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Controls the response shape when use_multi_channel is enabled. 'separate' (default) returns one transcript per channel under 'transcripts'. 'combined' merges all channels into a single transcript whose words are sorted by start time, each carrying a 'channel_index' - matching the single-channel response shape. 'combined' requires timestamps (timestamps_granularity must not be 'none') and does not support entity detection or redaction.<br/>
    /// Default Value: separate
    /// </summary>
    public enum BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Combined,
        /// <summary>
        /// 
        /// </summary>
        Separate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle value)
        {
            return value switch
            {
                BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle.Combined => "combined",
                BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle.Separate => "separate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle? ToEnum(string value)
        {
            return value switch
            {
                "combined" => BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle.Combined,
                "separate" => BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle.Separate,
                _ => null,
            };
        }
    }
}