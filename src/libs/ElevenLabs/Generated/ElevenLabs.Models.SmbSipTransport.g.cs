
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Signalling transport for outbound SIP INVITEs.<br/>
    /// Values match the Agents platform ``SIPTrunkTransportEnum`` so the SMB adapter<br/>
    /// maps by value. ``AUTO`` is omitted: the Agents UI hides it too, since it can<br/>
    /// pick UDP, which is known to misbehave (CAI-299). Reception defaults to TLS.
    /// </summary>
    public enum SmbSipTransport
    {
        /// <summary>
        ///
        /// </summary>
        Tcp,
        /// <summary>
        ///
        /// </summary>
        Tls,
        /// <summary>
        ///
        /// </summary>
        Udp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmbSipTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmbSipTransport value)
        {
            return value switch
            {
                SmbSipTransport.Tcp => "tcp",
                SmbSipTransport.Tls => "tls",
                SmbSipTransport.Udp => "udp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmbSipTransport? ToEnum(string value)
        {
            return value switch
            {
                "tcp" => SmbSipTransport.Tcp,
                "tls" => SmbSipTransport.Tls,
                "udp" => SmbSipTransport.Udp,
                _ => null,
            };
        }
    }
}