
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How to attach protocol_discriminator. 'prefix' prepends the octet to the hex payload (User-to-User=XX&lt;hex&gt;;encoding=hex). 'pd_parameter' sends it as a separate parameter (User-to-User=&lt;hex&gt;;pd=XX;encoding=hex). Ignored when protocol_discriminator is unset.<br/>
    /// Default Value: prefix
    /// </summary>
    public enum UUITransferConfigProtocolDiscriminatorMode
    {
        /// <summary>
        /// 
        /// </summary>
        PdParameter,
        /// <summary>
        /// 
        /// </summary>
        Prefix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UUITransferConfigProtocolDiscriminatorModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UUITransferConfigProtocolDiscriminatorMode value)
        {
            return value switch
            {
                UUITransferConfigProtocolDiscriminatorMode.PdParameter => "pd_parameter",
                UUITransferConfigProtocolDiscriminatorMode.Prefix => "prefix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UUITransferConfigProtocolDiscriminatorMode? ToEnum(string value)
        {
            return value switch
            {
                "pd_parameter" => UUITransferConfigProtocolDiscriminatorMode.PdParameter,
                "prefix" => UUITransferConfigProtocolDiscriminatorMode.Prefix,
                _ => null,
            };
        }
    }
}