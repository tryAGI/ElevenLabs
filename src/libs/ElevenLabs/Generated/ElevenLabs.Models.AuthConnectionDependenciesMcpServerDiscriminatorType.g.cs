
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthConnectionDependenciesMcpServerDiscriminatorType
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
    public static class AuthConnectionDependenciesMcpServerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthConnectionDependenciesMcpServerDiscriminatorType value)
        {
            return value switch
            {
                AuthConnectionDependenciesMcpServerDiscriminatorType.Available => "available",
                AuthConnectionDependenciesMcpServerDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthConnectionDependenciesMcpServerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => AuthConnectionDependenciesMcpServerDiscriminatorType.Available,
                "unknown" => AuthConnectionDependenciesMcpServerDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}