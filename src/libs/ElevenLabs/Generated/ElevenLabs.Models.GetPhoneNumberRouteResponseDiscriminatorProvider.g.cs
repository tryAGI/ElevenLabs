
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPhoneNumberRouteResponseDiscriminatorProvider
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
    public static class GetPhoneNumberRouteResponseDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPhoneNumberRouteResponseDiscriminatorProvider value)
        {
            return value switch
            {
                GetPhoneNumberRouteResponseDiscriminatorProvider.Exotel => "exotel",
                GetPhoneNumberRouteResponseDiscriminatorProvider.SipTrunk => "sip_trunk",
                GetPhoneNumberRouteResponseDiscriminatorProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPhoneNumberRouteResponseDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "exotel" => GetPhoneNumberRouteResponseDiscriminatorProvider.Exotel,
                "sip_trunk" => GetPhoneNumberRouteResponseDiscriminatorProvider.SipTrunk,
                "twilio" => GetPhoneNumberRouteResponseDiscriminatorProvider.Twilio,
                _ => null,
            };
        }
    }
}