
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. For 'eleven_turbo_v2_5' and 'eleven_flash_v2_5' models, text normalization can only be enabled with Enterprise plans.<br/>
    /// Default Value: auto<br/>
    /// Example: true
    /// </summary>
    public enum BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalization
    {
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. For 'eleven_turbo_v2_5' and 'eleven_flash_v2_5' models, text normalization can only be enabled with Enterprise plans.
        /// </summary>
        Auto,
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. For 'eleven_turbo_v2_5' and 'eleven_flash_v2_5' models, text normalization can only be enabled with Enterprise plans.
        /// </summary>
        On,
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. For 'eleven_turbo_v2_5' and 'eleven_flash_v2_5' models, text normalization can only be enabled with Enterprise plans.
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalization value)
        {
            return value switch
            {
                BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalization.Auto => "auto",
                BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalization.On => "on",
                BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalization.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalization.Auto,
                "on" => BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalization.On,
                "off" => BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalization.Off,
                _ => null,
            };
        }
    }
}