
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SubmitWhatsAppChannelConfigModeConfigDiscriminatorMode
    {
        /// <summary>
        ///
        /// </summary>
        Message,
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubmitWhatsAppChannelConfigModeConfigDiscriminatorModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitWhatsAppChannelConfigModeConfigDiscriminatorMode value)
        {
            return value switch
            {
                SubmitWhatsAppChannelConfigModeConfigDiscriminatorMode.Message => "message",
                SubmitWhatsAppChannelConfigModeConfigDiscriminatorMode.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitWhatsAppChannelConfigModeConfigDiscriminatorMode? ToEnum(string value)
        {
            return value switch
            {
                "message" => SubmitWhatsAppChannelConfigModeConfigDiscriminatorMode.Message,
                "voice" => SubmitWhatsAppChannelConfigModeConfigDiscriminatorMode.Voice,
                _ => null,
            };
        }
    }
}