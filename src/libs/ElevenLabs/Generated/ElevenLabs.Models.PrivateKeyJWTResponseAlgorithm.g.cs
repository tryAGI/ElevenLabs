
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// JWT signing algorithm<br/>
    /// Default Value: HS256
    /// </summary>
    public enum PrivateKeyJWTResponseAlgorithm
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
    public static class PrivateKeyJWTResponseAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateKeyJWTResponseAlgorithm value)
        {
            return value switch
            {
                PrivateKeyJWTResponseAlgorithm.Hs256 => "HS256",
                PrivateKeyJWTResponseAlgorithm.Hs384 => "HS384",
                PrivateKeyJWTResponseAlgorithm.Hs512 => "HS512",
                PrivateKeyJWTResponseAlgorithm.Rs256 => "RS256",
                PrivateKeyJWTResponseAlgorithm.Rs384 => "RS384",
                PrivateKeyJWTResponseAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateKeyJWTResponseAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "HS256" => PrivateKeyJWTResponseAlgorithm.Hs256,
                "HS384" => PrivateKeyJWTResponseAlgorithm.Hs384,
                "HS512" => PrivateKeyJWTResponseAlgorithm.Hs512,
                "RS256" => PrivateKeyJWTResponseAlgorithm.Rs256,
                "RS384" => PrivateKeyJWTResponseAlgorithm.Rs384,
                "RS512" => PrivateKeyJWTResponseAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}