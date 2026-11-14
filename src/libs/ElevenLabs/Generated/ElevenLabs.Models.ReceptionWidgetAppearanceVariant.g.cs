
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Widget size, from the smallest ('tiny') to the largest ('full').
    /// </summary>
    public enum ReceptionWidgetAppearanceVariant
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
    public static class ReceptionWidgetAppearanceVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionWidgetAppearanceVariant value)
        {
            return value switch
            {
                ReceptionWidgetAppearanceVariant.Compact => "compact",
                ReceptionWidgetAppearanceVariant.Full => "full",
                ReceptionWidgetAppearanceVariant.Tiny => "tiny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionWidgetAppearanceVariant? ToEnum(string value)
        {
            return value switch
            {
                "compact" => ReceptionWidgetAppearanceVariant.Compact,
                "full" => ReceptionWidgetAppearanceVariant.Full,
                "tiny" => ReceptionWidgetAppearanceVariant.Tiny,
                _ => null,
            };
        }
    }
}