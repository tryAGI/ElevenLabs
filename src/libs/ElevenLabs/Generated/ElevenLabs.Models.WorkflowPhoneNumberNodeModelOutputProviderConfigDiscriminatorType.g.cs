
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType
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
    public static class WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType value)
        {
            return value switch
            {
                WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType.Exotel => "exotel",
                WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType.SipTrunk => "sip_trunk",
                WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "exotel" => WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType.Exotel,
                "sip_trunk" => WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType.SipTrunk,
                "twilio" => WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType.Twilio,
                _ => null,
            };
        }
    }
}