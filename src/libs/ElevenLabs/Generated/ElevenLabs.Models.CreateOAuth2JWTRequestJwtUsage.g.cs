
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How the JWT is used at the token endpoint. 'authorization_grant' sends it as a jwt-bearer grant. 'client_authentication' sends it as a client_assertion on a client_credentials request, with the subject as client_id and scopes in the request body.<br/>
    /// Default Value: authorization_grant
    /// </summary>
    public enum CreateOAuth2JWTRequestJwtUsage
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
    public static class CreateOAuth2JWTRequestJwtUsageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOAuth2JWTRequestJwtUsage value)
        {
            return value switch
            {
                CreateOAuth2JWTRequestJwtUsage.AuthorizationGrant => "authorization_grant",
                CreateOAuth2JWTRequestJwtUsage.ClientAuthentication => "client_authentication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOAuth2JWTRequestJwtUsage? ToEnum(string value)
        {
            return value switch
            {
                "authorization_grant" => CreateOAuth2JWTRequestJwtUsage.AuthorizationGrant,
                "client_authentication" => CreateOAuth2JWTRequestJwtUsage.ClientAuthentication,
                _ => null,
            };
        }
    }
}