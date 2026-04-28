
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Token field to extract from the token endpoint response.<br/>
    /// Default Value: access_token
    /// </summary>
    public enum OAuth2JWTResponseTokenResponseField
    {
        /// <summary>
        /// 
        /// </summary>
        AccessToken,
        /// <summary>
        /// 
        /// </summary>
        IdToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuth2JWTResponseTokenResponseFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuth2JWTResponseTokenResponseField value)
        {
            return value switch
            {
                OAuth2JWTResponseTokenResponseField.AccessToken => "access_token",
                OAuth2JWTResponseTokenResponseField.IdToken => "id_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuth2JWTResponseTokenResponseField? ToEnum(string value)
        {
            return value switch
            {
                "access_token" => OAuth2JWTResponseTokenResponseField.AccessToken,
                "id_token" => OAuth2JWTResponseTokenResponseField.IdToken,
                _ => null,
            };
        }
    }
}