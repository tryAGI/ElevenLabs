
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Output format of the generated audio. Must be one of:<br/>
    /// mp3_22050_32 - output format, mp3 with 22.05kHz sample rate at 32kbps.<br/>
    /// mp3_44100_32 - output format, mp3 with 44.1kHz sample rate at 32kbps.<br/>
    /// mp3_44100_64 - output format, mp3 with 44.1kHz sample rate at 64kbps.<br/>
    /// mp3_44100_96 - output format, mp3 with 44.1kHz sample rate at 96kbps.<br/>
    /// mp3_44100_128 - default output format, mp3 with 44.1kHz sample rate at 128kbps.<br/>
    /// mp3_44100_192 - output format, mp3 with 44.1kHz sample rate at 192kbps. Requires you to be subscribed to Creator tier or above.<br/>
    /// pcm_16000 - PCM format (S16LE) with 16kHz sample rate.<br/>
    /// pcm_22050 - PCM format (S16LE) with 22.05kHz sample rate.<br/>
    /// pcm_24000 - PCM format (S16LE) with 24kHz sample rate.<br/>
    /// pcm_44100 - PCM format (S16LE) with 44.1kHz sample rate. Requires you to be subscribed to Pro tier or above.<br/>
    /// ulaw_8000 - μ-law format (sometimes written mu-law, often approximated as u-law) with 8kHz sample rate. Note that this format is commonly used for Twilio audio inputs.<br/>
    /// Default Value: mp3_44100_192
    /// </summary>
    public enum GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat
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
    public static class GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat value)
        {
            return value switch
            {
                GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Mp32205032 => "mp3_22050_32",
                GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Mp34410032 => "mp3_44100_32",
                GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Mp34410064 => "mp3_44100_64",
                GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Mp34410096 => "mp3_44100_96",
                GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Mp344100128 => "mp3_44100_128",
                GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Mp344100192 => "mp3_44100_192",
                GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Pcm16000 => "pcm_16000",
                GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Pcm22050 => "pcm_22050",
                GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Pcm24000 => "pcm_24000",
                GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Pcm44100 => "pcm_44100",
                GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Ulaw8000 => "ulaw_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3_22050_32" => GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Mp32205032,
                "mp3_44100_32" => GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Mp34410032,
                "mp3_44100_64" => GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Mp34410064,
                "mp3_44100_96" => GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Mp34410096,
                "mp3_44100_128" => GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Mp344100128,
                "mp3_44100_192" => GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Mp344100192,
                "pcm_16000" => GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Pcm16000,
                "pcm_22050" => GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Pcm22050,
                "pcm_24000" => GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Pcm24000,
                "pcm_44100" => GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Pcm44100,
                "ulaw_8000" => GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.Ulaw8000,
                _ => null,
            };
        }
    }
}