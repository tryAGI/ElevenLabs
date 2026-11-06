
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How the JWT is used at the token endpoint. 'authorization_grant' sends it as a jwt-bearer grant. 'client_authentication' sends it as a client_assertion on a client_credentials request, with the subject as client_id and scopes in the request body.<br/>
    /// Default Value: authorization_grant
    /// </summary>
    public enum OAuth2JWTResponseJwtUsage
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
    public static class OAuth2JWTResponseJwtUsageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuth2JWTResponseJwtUsage value)
        {
            return value switch
            {
                OAuth2JWTResponseJwtUsage.AuthorizationGrant => "authorization_grant",
                OAuth2JWTResponseJwtUsage.ClientAuthentication => "client_authentication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuth2JWTResponseJwtUsage? ToEnum(string value)
        {
            return value switch
            {
                "authorization_grant" => OAuth2JWTResponseJwtUsage.AuthorizationGrant,
                "client_authentication" => OAuth2JWTResponseJwtUsage.ClientAuthentication,
                _ => null,
            };
        }
    }
}