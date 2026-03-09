
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The safety controls of the voice.
    /// </summary>
    public enum VoiceResponseModelSafetyControl
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Ban,
        /// <summary>
        /// 
        /// </summary>
        Captcha,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseBan,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseCaptcha,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceResponseModelSafetyControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResponseModelSafetyControl value)
        {
            return value switch
            {
                VoiceResponseModelSafetyControl.None => "NONE",
                VoiceResponseModelSafetyControl.Ban => "BAN",
                VoiceResponseModelSafetyControl.Captcha => "CAPTCHA",
                VoiceResponseModelSafetyControl.EnterpriseBan => "ENTERPRISE_BAN",
                VoiceResponseModelSafetyControl.EnterpriseCaptcha => "ENTERPRISE_CAPTCHA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResponseModelSafetyControl? ToEnum(string value)
        {
            return value switch
            {
                "NONE" => VoiceResponseModelSafetyControl.None,
                "BAN" => VoiceResponseModelSafetyControl.Ban,
                "CAPTCHA" => VoiceResponseModelSafetyControl.Captcha,
                "ENTERPRISE_BAN" => VoiceResponseModelSafetyControl.EnterpriseBan,
                "ENTERPRISE_CAPTCHA" => VoiceResponseModelSafetyControl.EnterpriseCaptcha,
                _ => null,
            };
        }
    }
}