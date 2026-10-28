
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Media (SRTP) encryption policy for a SIP trunk.<br/>
    /// Values match the Agents platform ``SIPMediaEncryptionEnum`` so the SMB<br/>
    /// adapter maps by value.
    /// </summary>
    public enum SmbSipMediaEncryption
    {
        /// <summary>
        ///
        /// </summary>
        Allowed,
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmbSipMediaEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmbSipMediaEncryption value)
        {
            return value switch
            {
                SmbSipMediaEncryption.Allowed => "allowed",
                SmbSipMediaEncryption.Disabled => "disabled",
                SmbSipMediaEncryption.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmbSipMediaEncryption? ToEnum(string value)
        {
            return value switch
            {
                "allowed" => SmbSipMediaEncryption.Allowed,
                "disabled" => SmbSipMediaEncryption.Disabled,
                "required" => SmbSipMediaEncryption.Required,
                _ => null,
            };
        }
    }
}