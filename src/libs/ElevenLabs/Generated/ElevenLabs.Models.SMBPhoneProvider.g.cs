
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How calls to the number reach ElevenLabs: through Twilio or a SIP trunk.<br/>
    /// Default Value: twilio
    /// </summary>
    public enum SMBPhoneProvider
    {
        /// <summary>
        ///
        /// </summary>
        SipTrunk,
        /// <summary>
        ///
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SMBPhoneProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBPhoneProvider value)
        {
            return value switch
            {
                SMBPhoneProvider.SipTrunk => "sip_trunk",
                SMBPhoneProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBPhoneProvider? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => SMBPhoneProvider.SipTrunk,
                "twilio" => SMBPhoneProvider.Twilio,
                _ => null,
            };
        }
    }
}