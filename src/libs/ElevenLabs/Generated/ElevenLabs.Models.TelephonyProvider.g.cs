
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum TelephonyProvider
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
    public static class TelephonyProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TelephonyProvider value)
        {
            return value switch
            {
                TelephonyProvider.Exotel => "exotel",
                TelephonyProvider.SipTrunk => "sip_trunk",
                TelephonyProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TelephonyProvider? ToEnum(string value)
        {
            return value switch
            {
                "exotel" => TelephonyProvider.Exotel,
                "sip_trunk" => TelephonyProvider.SipTrunk,
                "twilio" => TelephonyProvider.Twilio,
                _ => null,
            };
        }
    }
}