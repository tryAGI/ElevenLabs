
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Token field to extract from the token endpoint response.<br/>
    /// Default Value: access_token
    /// </summary>
    public enum CreateOAuth2JWTRequestTokenResponseField
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
    public static class CreateOAuth2JWTRequestTokenResponseFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOAuth2JWTRequestTokenResponseField value)
        {
            return value switch
            {
                CreateOAuth2JWTRequestTokenResponseField.AccessToken => "access_token",
                CreateOAuth2JWTRequestTokenResponseField.IdToken => "id_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOAuth2JWTRequestTokenResponseField? ToEnum(string value)
        {
            return value switch
            {
                "access_token" => CreateOAuth2JWTRequestTokenResponseField.AccessToken,
                "id_token" => CreateOAuth2JWTRequestTokenResponseField.IdToken,
                _ => null,
            };
        }
    }
}