
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SMBWidgetAppearanceVariant
    {
        /// <summary>
        ///
        /// </summary>
        Compact,
        /// <summary>
        ///
        /// </summary>
        Full,
        /// <summary>
        ///
        /// </summary>
        Tiny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SMBWidgetAppearanceVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBWidgetAppearanceVariant value)
        {
            return value switch
            {
                SMBWidgetAppearanceVariant.Compact => "compact",
                SMBWidgetAppearanceVariant.Full => "full",
                SMBWidgetAppearanceVariant.Tiny => "tiny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBWidgetAppearanceVariant? ToEnum(string value)
        {
            return value switch
            {
                "compact" => SMBWidgetAppearanceVariant.Compact,
                "full" => SMBWidgetAppearanceVariant.Full,
                "tiny" => SMBWidgetAppearanceVariant.Tiny,
                _ => null,
            };
        }
    }
}