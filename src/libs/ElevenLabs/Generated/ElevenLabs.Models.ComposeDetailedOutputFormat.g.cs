
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum ComposeDetailedOutputFormat
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
    public static class ComposeDetailedOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComposeDetailedOutputFormat value)
        {
            return value switch
            {
                ComposeDetailedOutputFormat.Alaw8000 => "alaw_8000",
                ComposeDetailedOutputFormat.Auto => "auto",
                ComposeDetailedOutputFormat.Mp32205032 => "mp3_22050_32",
                ComposeDetailedOutputFormat.Mp32400048 => "mp3_24000_48",
                ComposeDetailedOutputFormat.Mp344100128 => "mp3_44100_128",
                ComposeDetailedOutputFormat.Mp344100192 => "mp3_44100_192",
                ComposeDetailedOutputFormat.Mp34410032 => "mp3_44100_32",
                ComposeDetailedOutputFormat.Mp34410064 => "mp3_44100_64",
                ComposeDetailedOutputFormat.Mp34410096 => "mp3_44100_96",
                ComposeDetailedOutputFormat.Mp348000128 => "mp3_48000_128",
                ComposeDetailedOutputFormat.Mp348000192 => "mp3_48000_192",
                ComposeDetailedOutputFormat.Mp348000240 => "mp3_48000_240",
                ComposeDetailedOutputFormat.Mp348000320 => "mp3_48000_320",
                ComposeDetailedOutputFormat.Opus48000128 => "opus_48000_128",
                ComposeDetailedOutputFormat.Opus48000192 => "opus_48000_192",
                ComposeDetailedOutputFormat.Opus4800032 => "opus_48000_32",
                ComposeDetailedOutputFormat.Opus4800064 => "opus_48000_64",
                ComposeDetailedOutputFormat.Opus4800096 => "opus_48000_96",
                ComposeDetailedOutputFormat.Pcm16000 => "pcm_16000",
                ComposeDetailedOutputFormat.Pcm22050 => "pcm_22050",
                ComposeDetailedOutputFormat.Pcm24000 => "pcm_24000",
                ComposeDetailedOutputFormat.Pcm32000 => "pcm_32000",
                ComposeDetailedOutputFormat.Pcm44100 => "pcm_44100",
                ComposeDetailedOutputFormat.Pcm48000 => "pcm_48000",
                ComposeDetailedOutputFormat.Pcm8000 => "pcm_8000",
                ComposeDetailedOutputFormat.Ulaw8000 => "ulaw_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComposeDetailedOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "alaw_8000" => ComposeDetailedOutputFormat.Alaw8000,
                "auto" => ComposeDetailedOutputFormat.Auto,
                "mp3_22050_32" => ComposeDetailedOutputFormat.Mp32205032,
                "mp3_24000_48" => ComposeDetailedOutputFormat.Mp32400048,
                "mp3_44100_128" => ComposeDetailedOutputFormat.Mp344100128,
                "mp3_44100_192" => ComposeDetailedOutputFormat.Mp344100192,
                "mp3_44100_32" => ComposeDetailedOutputFormat.Mp34410032,
                "mp3_44100_64" => ComposeDetailedOutputFormat.Mp34410064,
                "mp3_44100_96" => ComposeDetailedOutputFormat.Mp34410096,
                "mp3_48000_128" => ComposeDetailedOutputFormat.Mp348000128,
                "mp3_48000_192" => ComposeDetailedOutputFormat.Mp348000192,
                "mp3_48000_240" => ComposeDetailedOutputFormat.Mp348000240,
                "mp3_48000_320" => ComposeDetailedOutputFormat.Mp348000320,
                "opus_48000_128" => ComposeDetailedOutputFormat.Opus48000128,
                "opus_48000_192" => ComposeDetailedOutputFormat.Opus48000192,
                "opus_48000_32" => ComposeDetailedOutputFormat.Opus4800032,
                "opus_48000_64" => ComposeDetailedOutputFormat.Opus4800064,
                "opus_48000_96" => ComposeDetailedOutputFormat.Opus4800096,
                "pcm_16000" => ComposeDetailedOutputFormat.Pcm16000,
                "pcm_22050" => ComposeDetailedOutputFormat.Pcm22050,
                "pcm_24000" => ComposeDetailedOutputFormat.Pcm24000,
                "pcm_32000" => ComposeDetailedOutputFormat.Pcm32000,
                "pcm_44100" => ComposeDetailedOutputFormat.Pcm44100,
                "pcm_48000" => ComposeDetailedOutputFormat.Pcm48000,
                "pcm_8000" => ComposeDetailedOutputFormat.Pcm8000,
                "ulaw_8000" => ComposeDetailedOutputFormat.Ulaw8000,
                _ => null,
            };
        }
    }
}