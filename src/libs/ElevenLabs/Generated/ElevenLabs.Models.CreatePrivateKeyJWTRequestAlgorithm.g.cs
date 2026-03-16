
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// JWT signing algorithm<br/>
    /// Default Value: HS256
    /// </summary>
    public enum CreatePrivateKeyJWTRequestAlgorithm
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
    public static class CreatePrivateKeyJWTRequestAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePrivateKeyJWTRequestAlgorithm value)
        {
            return value switch
            {
                CreatePrivateKeyJWTRequestAlgorithm.Hs256 => "HS256",
                CreatePrivateKeyJWTRequestAlgorithm.Hs384 => "HS384",
                CreatePrivateKeyJWTRequestAlgorithm.Hs512 => "HS512",
                CreatePrivateKeyJWTRequestAlgorithm.Rs256 => "RS256",
                CreatePrivateKeyJWTRequestAlgorithm.Rs384 => "RS384",
                CreatePrivateKeyJWTRequestAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePrivateKeyJWTRequestAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "HS256" => CreatePrivateKeyJWTRequestAlgorithm.Hs256,
                "HS384" => CreatePrivateKeyJWTRequestAlgorithm.Hs384,
                "HS512" => CreatePrivateKeyJWTRequestAlgorithm.Hs512,
                "RS256" => CreatePrivateKeyJWTRequestAlgorithm.Rs256,
                "RS384" => CreatePrivateKeyJWTRequestAlgorithm.Rs384,
                "RS512" => CreatePrivateKeyJWTRequestAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}