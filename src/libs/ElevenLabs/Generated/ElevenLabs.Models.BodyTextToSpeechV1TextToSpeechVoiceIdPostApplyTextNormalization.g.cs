
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. Cannot be turned on for 'eleven_turbo_v2_5' model.<br/>
    /// Default Value: auto
    /// </summary>
    public enum BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization
    {
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. Cannot be turned on for 'eleven_turbo_v2_5' model.
        /// </summary>
        Auto,
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. Cannot be turned on for 'eleven_turbo_v2_5' model.
        /// </summary>
        On,
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. Cannot be turned on for 'eleven_turbo_v2_5' model.
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization value)
        {
            return value switch
            {
                BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization.Auto => "auto",
                BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization.On => "on",
                BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization.Auto,
                "on" => BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization.On,
                "off" => BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization.Off,
                _ => null,
            };
        }
    }
}