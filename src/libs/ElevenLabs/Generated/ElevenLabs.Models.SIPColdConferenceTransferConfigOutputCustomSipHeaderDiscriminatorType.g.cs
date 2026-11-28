
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SIPColdConferenceTransferConfigOutputCustomSipHeaderDiscriminatorType
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
    public static class SIPColdConferenceTransferConfigOutputCustomSipHeaderDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPColdConferenceTransferConfigOutputCustomSipHeaderDiscriminatorType value)
        {
            return value switch
            {
                SIPColdConferenceTransferConfigOutputCustomSipHeaderDiscriminatorType.Dynamic => "dynamic",
                SIPColdConferenceTransferConfigOutputCustomSipHeaderDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPColdConferenceTransferConfigOutputCustomSipHeaderDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => SIPColdConferenceTransferConfigOutputCustomSipHeaderDiscriminatorType.Dynamic,
                "static" => SIPColdConferenceTransferConfigOutputCustomSipHeaderDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}