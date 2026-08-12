
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoReferenceDiscriminatorType
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
    public static class VideoReferenceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoReferenceDiscriminatorType value)
        {
            return value switch
            {
                VideoReferenceDiscriminatorType.Asset => "asset",
                VideoReferenceDiscriminatorType.Generation => "generation",
                VideoReferenceDiscriminatorType.InlineBase64 => "inline_base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoReferenceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "asset" => VideoReferenceDiscriminatorType.Asset,
                "generation" => VideoReferenceDiscriminatorType.Generation,
                "inline_base64" => VideoReferenceDiscriminatorType.InlineBase64,
                _ => null,
            };
        }
    }
}