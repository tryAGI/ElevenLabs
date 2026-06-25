
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Single status field shared by every auth type's stored credential.<br/>
    /// OAuth values (``REFRESH_FAILED``, ``REVOKED``) are written by the OAuth<br/>
    /// token-manager refresh path. ``CREDENTIAL_INVALID`` is written by the<br/>
    /// tool execution path when an upstream response matches a credential's<br/>
    /// ``failure_signatures`` entry (Bearer, Basic auth, etc.).<br/>
    /// Default Value: active
    /// </summary>
    public enum AuthConnectionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        CredentialInvalid,
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
    public static class AuthConnectionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthConnectionStatus value)
        {
            return value switch
            {
                AuthConnectionStatus.Active => "active",
                AuthConnectionStatus.CredentialInvalid => "credential_invalid",
                AuthConnectionStatus.RefreshFailed => "refresh_failed",
                AuthConnectionStatus.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthConnectionStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => AuthConnectionStatus.Active,
                "credential_invalid" => AuthConnectionStatus.CredentialInvalid,
                "refresh_failed" => AuthConnectionStatus.RefreshFailed,
                "revoked" => AuthConnectionStatus.Revoked,
                _ => null,
            };
        }
    }
}