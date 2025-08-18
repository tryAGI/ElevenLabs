
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
    /// Default Value: mp3_44100_128
    /// </summary>
    public enum ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat
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
        Pcm48000,
        /// <summary>
        /// 
        /// </summary>
        Ulaw8000,
        /// <summary>
        /// 
        /// </summary>
        Alaw8000,
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
        Opus48000128,
        /// <summary>
        /// 
        /// </summary>
        Opus48000192,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat value)
        {
            return value switch
            {
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Mp32205032 => "mp3_22050_32",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Mp34410032 => "mp3_44100_32",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Mp34410064 => "mp3_44100_64",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Mp34410096 => "mp3_44100_96",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Mp344100128 => "mp3_44100_128",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Mp344100192 => "mp3_44100_192",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Pcm8000 => "pcm_8000",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Pcm16000 => "pcm_16000",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Pcm22050 => "pcm_22050",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Pcm24000 => "pcm_24000",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Pcm44100 => "pcm_44100",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Pcm48000 => "pcm_48000",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Ulaw8000 => "ulaw_8000",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Alaw8000 => "alaw_8000",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Opus4800032 => "opus_48000_32",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Opus4800064 => "opus_48000_64",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Opus4800096 => "opus_48000_96",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Opus48000128 => "opus_48000_128",
                ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Opus48000192 => "opus_48000_192",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3_22050_32" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Mp32205032,
                "mp3_44100_32" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Mp34410032,
                "mp3_44100_64" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Mp34410064,
                "mp3_44100_96" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Mp34410096,
                "mp3_44100_128" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Mp344100128,
                "mp3_44100_192" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Mp344100192,
                "pcm_8000" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Pcm8000,
                "pcm_16000" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Pcm16000,
                "pcm_22050" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Pcm22050,
                "pcm_24000" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Pcm24000,
                "pcm_44100" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Pcm44100,
                "pcm_48000" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Pcm48000,
                "ulaw_8000" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Ulaw8000,
                "alaw_8000" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Alaw8000,
                "opus_48000_32" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Opus4800032,
                "opus_48000_64" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Opus4800064,
                "opus_48000_96" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Opus4800096,
                "opus_48000_128" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Opus48000128,
                "opus_48000_192" => ComposeMusicWithADetailedResponseV1MusicDetailedPostOutputFormat.Opus48000192,
                _ => null,
            };
        }
    }
}