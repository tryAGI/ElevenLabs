
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthConnectionDependenciesToolDiscriminatorType
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
    public static class AuthConnectionDependenciesToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthConnectionDependenciesToolDiscriminatorType value)
        {
            return value switch
            {
                AuthConnectionDependenciesToolDiscriminatorType.Available => "available",
                AuthConnectionDependenciesToolDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthConnectionDependenciesToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => AuthConnectionDependenciesToolDiscriminatorType.Available,
                "unknown" => AuthConnectionDependenciesToolDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}