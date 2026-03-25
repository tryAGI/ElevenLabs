
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: active
    /// </summary>
    public enum OAuthConnectionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        RefreshFailed,
        /// <summary>
        /// 
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthConnectionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthConnectionStatus value)
        {
            return value switch
            {
                OAuthConnectionStatus.Active => "active",
                OAuthConnectionStatus.RefreshFailed => "refresh_failed",
                OAuthConnectionStatus.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthConnectionStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => OAuthConnectionStatus.Active,
                "refresh_failed" => OAuthConnectionStatus.RefreshFailed,
                "revoked" => OAuthConnectionStatus.Revoked,
                _ => null,
            };
        }
    }
}