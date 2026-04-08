
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Available,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType.Available => "available",
                GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType.Available,
                "unknown" => GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}