
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// JWT signing algorithm<br/>
    /// Default Value: HS256
    /// </summary>
    public enum OAuth2JWTResponseAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        Hs256,
        /// <summary>
        /// 
        /// </summary>
        Hs384,
        /// <summary>
        /// 
        /// </summary>
        Hs512,
        /// <summary>
        /// 
        /// </summary>
        Rs256,
        /// <summary>
        /// 
        /// </summary>
        Rs384,
        /// <summary>
        /// 
        /// </summary>
        Rs512,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuth2JWTResponseAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuth2JWTResponseAlgorithm value)
        {
            return value switch
            {
                OAuth2JWTResponseAlgorithm.Hs256 => "HS256",
                OAuth2JWTResponseAlgorithm.Hs384 => "HS384",
                OAuth2JWTResponseAlgorithm.Hs512 => "HS512",
                OAuth2JWTResponseAlgorithm.Rs256 => "RS256",
                OAuth2JWTResponseAlgorithm.Rs384 => "RS384",
                OAuth2JWTResponseAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuth2JWTResponseAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "HS256" => OAuth2JWTResponseAlgorithm.Hs256,
                "HS384" => OAuth2JWTResponseAlgorithm.Hs384,
                "HS512" => OAuth2JWTResponseAlgorithm.Hs512,
                "RS256" => OAuth2JWTResponseAlgorithm.Rs256,
                "RS384" => OAuth2JWTResponseAlgorithm.Rs384,
                "RS512" => OAuth2JWTResponseAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}