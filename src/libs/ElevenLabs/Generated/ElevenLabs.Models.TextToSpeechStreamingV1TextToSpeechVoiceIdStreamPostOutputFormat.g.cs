
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
    /// Default Value: mp3_44100_128
    /// </summary>
    public enum TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat
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
    public static class TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat value)
        {
            return value switch
            {
                TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Mp32205032 => "mp3_22050_32",
                TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Mp34410032 => "mp3_44100_32",
                TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Mp34410064 => "mp3_44100_64",
                TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Mp34410096 => "mp3_44100_96",
                TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Mp344100128 => "mp3_44100_128",
                TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Mp344100192 => "mp3_44100_192",
                TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Pcm8000 => "pcm_8000",
                TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Pcm16000 => "pcm_16000",
                TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Pcm22050 => "pcm_22050",
                TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Pcm24000 => "pcm_24000",
                TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Pcm44100 => "pcm_44100",
                TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Ulaw8000 => "ulaw_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3_22050_32" => TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Mp32205032,
                "mp3_44100_32" => TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Mp34410032,
                "mp3_44100_64" => TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Mp34410064,
                "mp3_44100_96" => TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Mp34410096,
                "mp3_44100_128" => TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Mp344100128,
                "mp3_44100_192" => TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Mp344100192,
                "pcm_8000" => TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Pcm8000,
                "pcm_16000" => TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Pcm16000,
                "pcm_22050" => TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Pcm22050,
                "pcm_24000" => TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Pcm24000,
                "pcm_44100" => TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Pcm44100,
                "ulaw_8000" => TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.Ulaw8000,
                _ => null,
            };
        }
    }
}