
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SMBWidgetAppearancePlacement
    {
        /// <summary>
        ///
        /// </summary>
        Bottom,
        /// <summary>
        ///
        /// </summary>
        BottomLeft,
        /// <summary>
        ///
        /// </summary>
        BottomRight,
        /// <summary>
        ///
        /// </summary>
        Top,
        /// <summary>
        ///
        /// </summary>
        TopLeft,
        /// <summary>
        ///
        /// </summary>
        TopRight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SMBWidgetAppearancePlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBWidgetAppearancePlacement value)
        {
            return value switch
            {
                SMBWidgetAppearancePlacement.Bottom => "bottom",
                SMBWidgetAppearancePlacement.BottomLeft => "bottom-left",
                SMBWidgetAppearancePlacement.BottomRight => "bottom-right",
                SMBWidgetAppearancePlacement.Top => "top",
                SMBWidgetAppearancePlacement.TopLeft => "top-left",
                SMBWidgetAppearancePlacement.TopRight => "top-right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBWidgetAppearancePlacement? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => SMBWidgetAppearancePlacement.Bottom,
                "bottom-left" => SMBWidgetAppearancePlacement.BottomLeft,
                "bottom-right" => SMBWidgetAppearancePlacement.BottomRight,
                "top" => SMBWidgetAppearancePlacement.Top,
                "top-left" => SMBWidgetAppearancePlacement.TopLeft,
                "top-right" => SMBWidgetAppearancePlacement.TopRight,
                _ => null,
            };
        }
    }
}