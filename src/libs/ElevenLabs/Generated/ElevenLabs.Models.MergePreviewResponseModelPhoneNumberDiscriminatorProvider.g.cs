
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum MergePreviewResponseModelPhoneNumberDiscriminatorProvider
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
    public static class MergePreviewResponseModelPhoneNumberDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MergePreviewResponseModelPhoneNumberDiscriminatorProvider value)
        {
            return value switch
            {
                MergePreviewResponseModelPhoneNumberDiscriminatorProvider.Exotel => "exotel",
                MergePreviewResponseModelPhoneNumberDiscriminatorProvider.SipTrunk => "sip_trunk",
                MergePreviewResponseModelPhoneNumberDiscriminatorProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MergePreviewResponseModelPhoneNumberDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "exotel" => MergePreviewResponseModelPhoneNumberDiscriminatorProvider.Exotel,
                "sip_trunk" => MergePreviewResponseModelPhoneNumberDiscriminatorProvider.SipTrunk,
                "twilio" => MergePreviewResponseModelPhoneNumberDiscriminatorProvider.Twilio,
                _ => null,
            };
        }
    }
}