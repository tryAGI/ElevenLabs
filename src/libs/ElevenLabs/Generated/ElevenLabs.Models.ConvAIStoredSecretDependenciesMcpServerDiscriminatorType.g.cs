
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConvAIStoredSecretDependenciesMcpServerDiscriminatorType
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
    public static class ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConvAIStoredSecretDependenciesMcpServerDiscriminatorType value)
        {
            return value switch
            {
                ConvAIStoredSecretDependenciesMcpServerDiscriminatorType.Available => "available",
                ConvAIStoredSecretDependenciesMcpServerDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConvAIStoredSecretDependenciesMcpServerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => ConvAIStoredSecretDependenciesMcpServerDiscriminatorType.Available,
                "unknown" => ConvAIStoredSecretDependenciesMcpServerDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}