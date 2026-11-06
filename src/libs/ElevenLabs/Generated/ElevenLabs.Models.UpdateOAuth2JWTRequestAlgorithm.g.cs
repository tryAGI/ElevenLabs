
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateOAuth2JWTRequestAlgorithm
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
        Ps256,
        /// <summary>
        ///
        /// </summary>
        Ps384,
        /// <summary>
        ///
        /// </summary>
        Ps512,
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
    public static class UpdateOAuth2JWTRequestAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateOAuth2JWTRequestAlgorithm value)
        {
            return value switch
            {
                UpdateOAuth2JWTRequestAlgorithm.Hs256 => "HS256",
                UpdateOAuth2JWTRequestAlgorithm.Hs384 => "HS384",
                UpdateOAuth2JWTRequestAlgorithm.Hs512 => "HS512",
                UpdateOAuth2JWTRequestAlgorithm.Ps256 => "PS256",
                UpdateOAuth2JWTRequestAlgorithm.Ps384 => "PS384",
                UpdateOAuth2JWTRequestAlgorithm.Ps512 => "PS512",
                UpdateOAuth2JWTRequestAlgorithm.Rs256 => "RS256",
                UpdateOAuth2JWTRequestAlgorithm.Rs384 => "RS384",
                UpdateOAuth2JWTRequestAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateOAuth2JWTRequestAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "HS256" => UpdateOAuth2JWTRequestAlgorithm.Hs256,
                "HS384" => UpdateOAuth2JWTRequestAlgorithm.Hs384,
                "HS512" => UpdateOAuth2JWTRequestAlgorithm.Hs512,
                "PS256" => UpdateOAuth2JWTRequestAlgorithm.Ps256,
                "PS384" => UpdateOAuth2JWTRequestAlgorithm.Ps384,
                "PS512" => UpdateOAuth2JWTRequestAlgorithm.Ps512,
                "RS256" => UpdateOAuth2JWTRequestAlgorithm.Rs256,
                "RS384" => UpdateOAuth2JWTRequestAlgorithm.Rs384,
                "RS512" => UpdateOAuth2JWTRequestAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}