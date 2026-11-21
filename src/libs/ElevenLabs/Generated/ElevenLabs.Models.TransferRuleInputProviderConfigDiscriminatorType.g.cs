
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TransferRuleInputProviderConfigDiscriminatorType
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
    public static class TransferRuleInputProviderConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferRuleInputProviderConfigDiscriminatorType value)
        {
            return value switch
            {
                TransferRuleInputProviderConfigDiscriminatorType.Exotel => "exotel",
                TransferRuleInputProviderConfigDiscriminatorType.SipTrunk => "sip_trunk",
                TransferRuleInputProviderConfigDiscriminatorType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferRuleInputProviderConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "exotel" => TransferRuleInputProviderConfigDiscriminatorType.Exotel,
                "sip_trunk" => TransferRuleInputProviderConfigDiscriminatorType.SipTrunk,
                "twilio" => TransferRuleInputProviderConfigDiscriminatorType.Twilio,
                _ => null,
            };
        }
    }
}