
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminatorType
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
    public static class SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminatorType value)
        {
            return value switch
            {
                SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminatorType.Phone => "phone",
                SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminatorType.Phone,
                "phone_dynamic_variable" => SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable,
                _ => null,
            };
        }
    }
}