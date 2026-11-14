
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TransferRuleOutputProviderConfigDiscriminatorType
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
    public static class TransferRuleOutputProviderConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferRuleOutputProviderConfigDiscriminatorType value)
        {
            return value switch
            {
                TransferRuleOutputProviderConfigDiscriminatorType.Exotel => "exotel",
                TransferRuleOutputProviderConfigDiscriminatorType.SipTrunk => "sip_trunk",
                TransferRuleOutputProviderConfigDiscriminatorType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferRuleOutputProviderConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "exotel" => TransferRuleOutputProviderConfigDiscriminatorType.Exotel,
                "sip_trunk" => TransferRuleOutputProviderConfigDiscriminatorType.SipTrunk,
                "twilio" => TransferRuleOutputProviderConfigDiscriminatorType.Twilio,
                _ => null,
            };
        }
    }
}