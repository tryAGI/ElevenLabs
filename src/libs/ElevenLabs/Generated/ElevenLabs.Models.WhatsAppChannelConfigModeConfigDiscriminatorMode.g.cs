
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum WhatsAppChannelConfigModeConfigDiscriminatorMode
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
    public static class WhatsAppChannelConfigModeConfigDiscriminatorModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhatsAppChannelConfigModeConfigDiscriminatorMode value)
        {
            return value switch
            {
                WhatsAppChannelConfigModeConfigDiscriminatorMode.Message => "message",
                WhatsAppChannelConfigModeConfigDiscriminatorMode.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhatsAppChannelConfigModeConfigDiscriminatorMode? ToEnum(string value)
        {
            return value switch
            {
                "message" => WhatsAppChannelConfigModeConfigDiscriminatorMode.Message,
                "voice" => WhatsAppChannelConfigModeConfigDiscriminatorMode.Voice,
                _ => null,
            };
        }
    }
}