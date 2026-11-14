
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorType
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
    public static class SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorType value)
        {
            return value switch
            {
                SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorType.Phone => "phone",
                SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorType.Phone,
                "phone_dynamic_variable" => SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorType.PhoneDynamicVariable,
                _ => null,
            };
        }
    }
}