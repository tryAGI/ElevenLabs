
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioReferenceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Asset,
        /// <summary>
        /// 
        /// </summary>
        Generation,
        /// <summary>
        /// 
        /// </summary>
        InlineBase64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioReferenceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioReferenceDiscriminatorType value)
        {
            return value switch
            {
                AudioReferenceDiscriminatorType.Asset => "asset",
                AudioReferenceDiscriminatorType.Generation => "generation",
                AudioReferenceDiscriminatorType.InlineBase64 => "inline_base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioReferenceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "asset" => AudioReferenceDiscriminatorType.Asset,
                "generation" => AudioReferenceDiscriminatorType.Generation,
                "inline_base64" => AudioReferenceDiscriminatorType.InlineBase64,
                _ => null,
            };
        }
    }
}