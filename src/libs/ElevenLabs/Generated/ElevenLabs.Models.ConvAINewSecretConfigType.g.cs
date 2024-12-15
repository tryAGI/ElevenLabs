
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConvAINewSecretConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        New,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConvAINewSecretConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConvAINewSecretConfigType value)
        {
            return value switch
            {
                ConvAINewSecretConfigType.New => "new",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConvAINewSecretConfigType? ToEnum(string value)
        {
            return value switch
            {
                "new" => ConvAINewSecretConfigType.New,
                _ => null,
            };
        }
    }
}