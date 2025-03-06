
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
    /// Default Value: mp3_44100_128
    /// </summary>
    public enum SoundGenerationV1SoundGenerationPostOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp32205032,
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
        Mp344100128,
        /// <summary>
        /// 
        /// </summary>
        Mp344100192,
        /// <summary>
        /// 
        /// </summary>
        Pcm8000,
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
        Pcm44100,
        /// <summary>
        /// 
        /// </summary>
        Ulaw8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SoundGenerationV1SoundGenerationPostOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SoundGenerationV1SoundGenerationPostOutputFormat value)
        {
            return value switch
            {
                SoundGenerationV1SoundGenerationPostOutputFormat.Mp32205032 => "mp3_22050_32",
                SoundGenerationV1SoundGenerationPostOutputFormat.Mp34410032 => "mp3_44100_32",
                SoundGenerationV1SoundGenerationPostOutputFormat.Mp34410064 => "mp3_44100_64",
                SoundGenerationV1SoundGenerationPostOutputFormat.Mp34410096 => "mp3_44100_96",
                SoundGenerationV1SoundGenerationPostOutputFormat.Mp344100128 => "mp3_44100_128",
                SoundGenerationV1SoundGenerationPostOutputFormat.Mp344100192 => "mp3_44100_192",
                SoundGenerationV1SoundGenerationPostOutputFormat.Pcm8000 => "pcm_8000",
                SoundGenerationV1SoundGenerationPostOutputFormat.Pcm16000 => "pcm_16000",
                SoundGenerationV1SoundGenerationPostOutputFormat.Pcm22050 => "pcm_22050",
                SoundGenerationV1SoundGenerationPostOutputFormat.Pcm24000 => "pcm_24000",
                SoundGenerationV1SoundGenerationPostOutputFormat.Pcm44100 => "pcm_44100",
                SoundGenerationV1SoundGenerationPostOutputFormat.Ulaw8000 => "ulaw_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SoundGenerationV1SoundGenerationPostOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3_22050_32" => SoundGenerationV1SoundGenerationPostOutputFormat.Mp32205032,
                "mp3_44100_32" => SoundGenerationV1SoundGenerationPostOutputFormat.Mp34410032,
                "mp3_44100_64" => SoundGenerationV1SoundGenerationPostOutputFormat.Mp34410064,
                "mp3_44100_96" => SoundGenerationV1SoundGenerationPostOutputFormat.Mp34410096,
                "mp3_44100_128" => SoundGenerationV1SoundGenerationPostOutputFormat.Mp344100128,
                "mp3_44100_192" => SoundGenerationV1SoundGenerationPostOutputFormat.Mp344100192,
                "pcm_8000" => SoundGenerationV1SoundGenerationPostOutputFormat.Pcm8000,
                "pcm_16000" => SoundGenerationV1SoundGenerationPostOutputFormat.Pcm16000,
                "pcm_22050" => SoundGenerationV1SoundGenerationPostOutputFormat.Pcm22050,
                "pcm_24000" => SoundGenerationV1SoundGenerationPostOutputFormat.Pcm24000,
                "pcm_44100" => SoundGenerationV1SoundGenerationPostOutputFormat.Pcm44100,
                "ulaw_8000" => SoundGenerationV1SoundGenerationPostOutputFormat.Ulaw8000,
                _ => null,
            };
        }
    }
}