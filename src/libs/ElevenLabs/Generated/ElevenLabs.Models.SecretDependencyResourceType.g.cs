
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretDependencyResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Agents,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumbers,
        /// <summary>
        /// 
        /// </summary>
        Tools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretDependencyResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretDependencyResourceType value)
        {
            return value switch
            {
                SecretDependencyResourceType.Agents => "agents",
                SecretDependencyResourceType.PhoneNumbers => "phone_numbers",
                SecretDependencyResourceType.Tools => "tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretDependencyResourceType? ToEnum(string value)
        {
            return value switch
            {
                "agents" => SecretDependencyResourceType.Agents,
                "phone_numbers" => SecretDependencyResourceType.PhoneNumbers,
                "tools" => SecretDependencyResourceType.Tools,
                _ => null,
            };
        }
    }
}