
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// JWT signing algorithm<br/>
    /// Default Value: HS256
    /// </summary>
    public enum CreateOAuth2JWTRequestAlgorithm
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
    public static class CreateOAuth2JWTRequestAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOAuth2JWTRequestAlgorithm value)
        {
            return value switch
            {
                CreateOAuth2JWTRequestAlgorithm.Hs256 => "HS256",
                CreateOAuth2JWTRequestAlgorithm.Hs384 => "HS384",
                CreateOAuth2JWTRequestAlgorithm.Hs512 => "HS512",
                CreateOAuth2JWTRequestAlgorithm.Rs256 => "RS256",
                CreateOAuth2JWTRequestAlgorithm.Rs384 => "RS384",
                CreateOAuth2JWTRequestAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOAuth2JWTRequestAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "HS256" => CreateOAuth2JWTRequestAlgorithm.Hs256,
                "HS384" => CreateOAuth2JWTRequestAlgorithm.Hs384,
                "HS512" => CreateOAuth2JWTRequestAlgorithm.Hs512,
                "RS256" => CreateOAuth2JWTRequestAlgorithm.Rs256,
                "RS384" => CreateOAuth2JWTRequestAlgorithm.Rs384,
                "RS512" => CreateOAuth2JWTRequestAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}