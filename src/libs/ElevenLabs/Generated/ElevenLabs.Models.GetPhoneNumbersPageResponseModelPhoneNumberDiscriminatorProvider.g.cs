
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider
    {
        /// <summary>
        ///
        /// </summary>
        Exotel,
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
    public static class GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider value)
        {
            return value switch
            {
                GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider.Exotel => "exotel",
                GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider.SipTrunk => "sip_trunk",
                GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "exotel" => GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider.Exotel,
                "sip_trunk" => GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider.SipTrunk,
                "twilio" => GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider.Twilio,
                _ => null,
            };
        }
    }
}