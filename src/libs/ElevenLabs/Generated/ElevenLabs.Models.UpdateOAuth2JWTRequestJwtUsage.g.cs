
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateOAuth2JWTRequestJwtUsage
    {
        /// <summary>
        ///
        /// </summary>
        AuthorizationGrant,
        /// <summary>
        ///
        /// </summary>
        ClientAuthentication,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateOAuth2JWTRequestJwtUsageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateOAuth2JWTRequestJwtUsage value)
        {
            return value switch
            {
                UpdateOAuth2JWTRequestJwtUsage.AuthorizationGrant => "authorization_grant",
                UpdateOAuth2JWTRequestJwtUsage.ClientAuthentication => "client_authentication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateOAuth2JWTRequestJwtUsage? ToEnum(string value)
        {
            return value switch
            {
                "authorization_grant" => UpdateOAuth2JWTRequestJwtUsage.AuthorizationGrant,
                "client_authentication" => UpdateOAuth2JWTRequestJwtUsage.ClientAuthentication,
                _ => null,
            };
        }
    }
}