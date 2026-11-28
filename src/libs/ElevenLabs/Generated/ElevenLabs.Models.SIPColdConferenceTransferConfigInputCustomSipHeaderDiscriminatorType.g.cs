
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SIPColdConferenceTransferConfigInputCustomSipHeaderDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Dynamic,
        /// <summary>
        ///
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SIPColdConferenceTransferConfigInputCustomSipHeaderDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPColdConferenceTransferConfigInputCustomSipHeaderDiscriminatorType value)
        {
            return value switch
            {
                SIPColdConferenceTransferConfigInputCustomSipHeaderDiscriminatorType.Dynamic => "dynamic",
                SIPColdConferenceTransferConfigInputCustomSipHeaderDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPColdConferenceTransferConfigInputCustomSipHeaderDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => SIPColdConferenceTransferConfigInputCustomSipHeaderDiscriminatorType.Dynamic,
                "static" => SIPColdConferenceTransferConfigInputCustomSipHeaderDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}