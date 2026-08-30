
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The audio encoding of the output, as `codec_sampleRateHz_bitrateKbps`. `mp3_44100_192` requires the Creator tier or above.<br/>
    /// Default Value: mp3_44100_128
    /// </summary>
    public enum ElevenMultilingualV2RequestOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Mp32205032,
        /// <summary>
        ///
        /// </summary>
        Mp32400048,
        /// <summary>
        ///
        /// </summary>
        Mp344100128,
        /// <summary>
        ///
        /// </summary>
        Mp344100192,
        /// <summary>
        ///
        /// </summary>
        Mp34410032,
        /// <summary>
        ///
        /// </summary>
        Mp34410064,
        /// <summary>
        ///
        /// </summary>
        Mp34410096,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenMultilingualV2RequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenMultilingualV2RequestOutputFormat value)
        {
            return value switch
            {
                ElevenMultilingualV2RequestOutputFormat.Mp32205032 => "mp3_22050_32",
                ElevenMultilingualV2RequestOutputFormat.Mp32400048 => "mp3_24000_48",
                ElevenMultilingualV2RequestOutputFormat.Mp344100128 => "mp3_44100_128",
                ElevenMultilingualV2RequestOutputFormat.Mp344100192 => "mp3_44100_192",
                ElevenMultilingualV2RequestOutputFormat.Mp34410032 => "mp3_44100_32",
                ElevenMultilingualV2RequestOutputFormat.Mp34410064 => "mp3_44100_64",
                ElevenMultilingualV2RequestOutputFormat.Mp34410096 => "mp3_44100_96",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenMultilingualV2RequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3_22050_32" => ElevenMultilingualV2RequestOutputFormat.Mp32205032,
                "mp3_24000_48" => ElevenMultilingualV2RequestOutputFormat.Mp32400048,
                "mp3_44100_128" => ElevenMultilingualV2RequestOutputFormat.Mp344100128,
                "mp3_44100_192" => ElevenMultilingualV2RequestOutputFormat.Mp344100192,
                "mp3_44100_32" => ElevenMultilingualV2RequestOutputFormat.Mp34410032,
                "mp3_44100_64" => ElevenMultilingualV2RequestOutputFormat.Mp34410064,
                "mp3_44100_96" => ElevenMultilingualV2RequestOutputFormat.Mp34410096,
                _ => null,
            };
        }
    }
}