
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConvAIStoredSecretConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Stored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConvAIStoredSecretConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConvAIStoredSecretConfigType value)
        {
            return value switch
            {
                ConvAIStoredSecretConfigType.Stored => "stored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConvAIStoredSecretConfigType? ToEnum(string value)
        {
            return value switch
            {
                "stored" => ConvAIStoredSecretConfigType.Stored,
                _ => null,
            };
        }
    }
}