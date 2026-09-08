
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateOAuth2JWTRequestTokenResponseField
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
    public static class UpdateOAuth2JWTRequestTokenResponseFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateOAuth2JWTRequestTokenResponseField value)
        {
            return value switch
            {
                UpdateOAuth2JWTRequestTokenResponseField.AccessToken => "access_token",
                UpdateOAuth2JWTRequestTokenResponseField.IdToken => "id_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateOAuth2JWTRequestTokenResponseField? ToEnum(string value)
        {
            return value switch
            {
                "access_token" => UpdateOAuth2JWTRequestTokenResponseField.AccessToken,
                "id_token" => UpdateOAuth2JWTRequestTokenResponseField.IdToken,
                _ => null,
            };
        }
    }
}