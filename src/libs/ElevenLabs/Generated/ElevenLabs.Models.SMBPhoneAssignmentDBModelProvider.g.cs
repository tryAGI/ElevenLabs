
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Telephony provider for this phone number. Defaults to twilio for backwards compatibility with existing documents.<br/>
    /// Default Value: twilio
    /// </summary>
    public enum SMBPhoneAssignmentDBModelProvider
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
    public static class SMBPhoneAssignmentDBModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBPhoneAssignmentDBModelProvider value)
        {
            return value switch
            {
                SMBPhoneAssignmentDBModelProvider.SipTrunk => "sip_trunk",
                SMBPhoneAssignmentDBModelProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBPhoneAssignmentDBModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => SMBPhoneAssignmentDBModelProvider.SipTrunk,
                "twilio" => SMBPhoneAssignmentDBModelProvider.Twilio,
                _ => null,
            };
        }
    }
}