
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageReferenceDiscriminatorType
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
    public static class ImageReferenceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageReferenceDiscriminatorType value)
        {
            return value switch
            {
                ImageReferenceDiscriminatorType.Asset => "asset",
                ImageReferenceDiscriminatorType.Generation => "generation",
                ImageReferenceDiscriminatorType.InlineBase64 => "inline_base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageReferenceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "asset" => ImageReferenceDiscriminatorType.Asset,
                "generation" => ImageReferenceDiscriminatorType.Generation,
                "inline_base64" => ImageReferenceDiscriminatorType.InlineBase64,
                _ => null,
            };
        }
    }
}