
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListPhoneNumbersRouteResponseItemDiscriminatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        SipTrunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPhoneNumbersRouteResponseItemDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPhoneNumbersRouteResponseItemDiscriminatorProvider value)
        {
            return value switch
            {
                ListPhoneNumbersRouteResponseItemDiscriminatorProvider.Twilio => "twilio",
                ListPhoneNumbersRouteResponseItemDiscriminatorProvider.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPhoneNumbersRouteResponseItemDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => ListPhoneNumbersRouteResponseItemDiscriminatorProvider.Twilio,
                "sip_trunk" => ListPhoneNumbersRouteResponseItemDiscriminatorProvider.SipTrunk,
                _ => null,
            };
        }
    }
}