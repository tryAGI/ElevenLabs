
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SIPColdReferTransferConfigInputCustomSipHeaderDiscriminatorType
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
    public static class SIPColdReferTransferConfigInputCustomSipHeaderDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPColdReferTransferConfigInputCustomSipHeaderDiscriminatorType value)
        {
            return value switch
            {
                SIPColdReferTransferConfigInputCustomSipHeaderDiscriminatorType.Dynamic => "dynamic",
                SIPColdReferTransferConfigInputCustomSipHeaderDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPColdReferTransferConfigInputCustomSipHeaderDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => SIPColdReferTransferConfigInputCustomSipHeaderDiscriminatorType.Dynamic,
                "static" => SIPColdReferTransferConfigInputCustomSipHeaderDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}