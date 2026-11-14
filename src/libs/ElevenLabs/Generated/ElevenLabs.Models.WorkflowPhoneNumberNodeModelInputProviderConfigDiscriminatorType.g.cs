
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType
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
    public static class WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType value)
        {
            return value switch
            {
                WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType.Exotel => "exotel",
                WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType.SipTrunk => "sip_trunk",
                WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "exotel" => WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType.Exotel,
                "sip_trunk" => WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType.SipTrunk,
                "twilio" => WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType.Twilio,
                _ => null,
            };
        }
    }
}