
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Phone,
        /// <summary>
        ///
        /// </summary>
        PhoneDynamicVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminatorType value)
        {
            return value switch
            {
                TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminatorType.Phone => "phone",
                TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminatorType.Phone,
                "phone_dynamic_variable" => TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable,
                _ => null,
            };
        }
    }
}