
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SIPColdReferTransferConfigOutputCustomSipHeaderDiscriminatorType
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
    public static class SIPColdReferTransferConfigOutputCustomSipHeaderDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPColdReferTransferConfigOutputCustomSipHeaderDiscriminatorType value)
        {
            return value switch
            {
                SIPColdReferTransferConfigOutputCustomSipHeaderDiscriminatorType.Dynamic => "dynamic",
                SIPColdReferTransferConfigOutputCustomSipHeaderDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPColdReferTransferConfigOutputCustomSipHeaderDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => SIPColdReferTransferConfigOutputCustomSipHeaderDiscriminatorType.Dynamic,
                "static" => SIPColdReferTransferConfigOutputCustomSipHeaderDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}