
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum StreamComposeOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Alaw8000,
        /// <summary>
        /// mp3_44100_128 for v1 models and mp3_48000_192 for v2 models.
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Mp32205032,
        /// <summary>
        /// 
        /// </summary>
        Mp32400048,
        /// <summary>
        /// mp3_44100_128 for v1 models and mp3_48000_192 for v2 models.
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
        /// <summary>
        /// 
        /// </summary>
        Mp348000128,
        /// <summary>
        /// mp3_44100_128 for v1 models and mp3_48000_192 for v2 models.
        /// </summary>
        Mp348000192,
        /// <summary>
        /// 
        /// </summary>
        Mp348000240,
        /// <summary>
        /// 
        /// </summary>
        Mp348000320,
        /// <summary>
        /// 
        /// </summary>
        Opus48000128,
        /// <summary>
        /// 
        /// </summary>
        Opus48000192,
        /// <summary>
        /// 
        /// </summary>
        Opus4800032,
        /// <summary>
        /// 
        /// </summary>
        Opus4800064,
        /// <summary>
        /// 
        /// </summary>
        Opus4800096,
        /// <summary>
        /// 
        /// </summary>
        Pcm16000,
        /// <summary>
        /// 
        /// </summary>
        Pcm22050,
        /// <summary>
        /// 
        /// </summary>
        Pcm24000,
        /// <summary>
        /// 
        /// </summary>
        Pcm32000,
        /// <summary>
        /// 
        /// </summary>
        Pcm44100,
        /// <summary>
        /// 
        /// </summary>
        Pcm48000,
        /// <summary>
        /// 
        /// </summary>
        Pcm8000,
        /// <summary>
        /// 
        /// </summary>
        Ulaw8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamComposeOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamComposeOutputFormat value)
        {
            return value switch
            {
                StreamComposeOutputFormat.Alaw8000 => "alaw_8000",
                StreamComposeOutputFormat.Auto => "auto",
                StreamComposeOutputFormat.Mp32205032 => "mp3_22050_32",
                StreamComposeOutputFormat.Mp32400048 => "mp3_24000_48",
                StreamComposeOutputFormat.Mp344100128 => "mp3_44100_128",
                StreamComposeOutputFormat.Mp344100192 => "mp3_44100_192",
                StreamComposeOutputFormat.Mp34410032 => "mp3_44100_32",
                StreamComposeOutputFormat.Mp34410064 => "mp3_44100_64",
                StreamComposeOutputFormat.Mp34410096 => "mp3_44100_96",
                StreamComposeOutputFormat.Mp348000128 => "mp3_48000_128",
                StreamComposeOutputFormat.Mp348000192 => "mp3_48000_192",
                StreamComposeOutputFormat.Mp348000240 => "mp3_48000_240",
                StreamComposeOutputFormat.Mp348000320 => "mp3_48000_320",
                StreamComposeOutputFormat.Opus48000128 => "opus_48000_128",
                StreamComposeOutputFormat.Opus48000192 => "opus_48000_192",
                StreamComposeOutputFormat.Opus4800032 => "opus_48000_32",
                StreamComposeOutputFormat.Opus4800064 => "opus_48000_64",
                StreamComposeOutputFormat.Opus4800096 => "opus_48000_96",
                StreamComposeOutputFormat.Pcm16000 => "pcm_16000",
                StreamComposeOutputFormat.Pcm22050 => "pcm_22050",
                StreamComposeOutputFormat.Pcm24000 => "pcm_24000",
                StreamComposeOutputFormat.Pcm32000 => "pcm_32000",
                StreamComposeOutputFormat.Pcm44100 => "pcm_44100",
                StreamComposeOutputFormat.Pcm48000 => "pcm_48000",
                StreamComposeOutputFormat.Pcm8000 => "pcm_8000",
                StreamComposeOutputFormat.Ulaw8000 => "ulaw_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamComposeOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "alaw_8000" => StreamComposeOutputFormat.Alaw8000,
                "auto" => StreamComposeOutputFormat.Auto,
                "mp3_22050_32" => StreamComposeOutputFormat.Mp32205032,
                "mp3_24000_48" => StreamComposeOutputFormat.Mp32400048,
                "mp3_44100_128" => StreamComposeOutputFormat.Mp344100128,
                "mp3_44100_192" => StreamComposeOutputFormat.Mp344100192,
                "mp3_44100_32" => StreamComposeOutputFormat.Mp34410032,
                "mp3_44100_64" => StreamComposeOutputFormat.Mp34410064,
                "mp3_44100_96" => StreamComposeOutputFormat.Mp34410096,
                "mp3_48000_128" => StreamComposeOutputFormat.Mp348000128,
                "mp3_48000_192" => StreamComposeOutputFormat.Mp348000192,
                "mp3_48000_240" => StreamComposeOutputFormat.Mp348000240,
                "mp3_48000_320" => StreamComposeOutputFormat.Mp348000320,
                "opus_48000_128" => StreamComposeOutputFormat.Opus48000128,
                "opus_48000_192" => StreamComposeOutputFormat.Opus48000192,
                "opus_48000_32" => StreamComposeOutputFormat.Opus4800032,
                "opus_48000_64" => StreamComposeOutputFormat.Opus4800064,
                "opus_48000_96" => StreamComposeOutputFormat.Opus4800096,
                "pcm_16000" => StreamComposeOutputFormat.Pcm16000,
                "pcm_22050" => StreamComposeOutputFormat.Pcm22050,
                "pcm_24000" => StreamComposeOutputFormat.Pcm24000,
                "pcm_32000" => StreamComposeOutputFormat.Pcm32000,
                "pcm_44100" => StreamComposeOutputFormat.Pcm44100,
                "pcm_48000" => StreamComposeOutputFormat.Pcm48000,
                "pcm_8000" => StreamComposeOutputFormat.Pcm8000,
                "ulaw_8000" => StreamComposeOutputFormat.Ulaw8000,
                _ => null,
            };
        }
    }
}