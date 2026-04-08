
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType
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
    public static class GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType.Available => "available",
                GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType.Available,
                "unknown" => GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}