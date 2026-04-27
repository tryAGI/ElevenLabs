
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum VeoReferenceImageType
    {
        /// <summary>
        /// 
        /// </summary>
        Asset,
        /// <summary>
        /// 
        /// </summary>
        Style,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VeoReferenceImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VeoReferenceImageType value)
        {
            return value switch
            {
                VeoReferenceImageType.Asset => "asset",
                VeoReferenceImageType.Style => "style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VeoReferenceImageType? ToEnum(string value)
        {
            return value switch
            {
                "asset" => VeoReferenceImageType.Asset,
                "style" => VeoReferenceImageType.Style,
                _ => null,
            };
        }
    }
}