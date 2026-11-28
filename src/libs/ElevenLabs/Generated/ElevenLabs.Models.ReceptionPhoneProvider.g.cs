
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How calls to the number reach ElevenLabs: through Twilio or a SIP trunk.<br/>
    /// Default Value: twilio
    /// </summary>
    public enum ReceptionPhoneProvider
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
    public static class ReceptionPhoneProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionPhoneProvider value)
        {
            return value switch
            {
                ReceptionPhoneProvider.SipTrunk => "sip_trunk",
                ReceptionPhoneProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionPhoneProvider? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => ReceptionPhoneProvider.SipTrunk,
                "twilio" => ReceptionPhoneProvider.Twilio,
                _ => null,
            };
        }
    }
}