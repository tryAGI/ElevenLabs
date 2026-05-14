
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateOAuth2JWTRequestTokenResponseField2
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
    public static class UpdateOAuth2JWTRequestTokenResponseField2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateOAuth2JWTRequestTokenResponseField2 value)
        {
            return value switch
            {
                UpdateOAuth2JWTRequestTokenResponseField2.AccessToken => "access_token",
                UpdateOAuth2JWTRequestTokenResponseField2.IdToken => "id_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateOAuth2JWTRequestTokenResponseField2? ToEnum(string value)
        {
            return value switch
            {
                "access_token" => UpdateOAuth2JWTRequestTokenResponseField2.AccessToken,
                "id_token" => UpdateOAuth2JWTRequestTokenResponseField2.IdToken,
                _ => null,
            };
        }
    }
}