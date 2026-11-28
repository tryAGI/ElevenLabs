
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Where on the page the widget sits.
    /// </summary>
    public enum ReceptionWidgetAppearancePlacement
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
    public static class ReceptionWidgetAppearancePlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionWidgetAppearancePlacement value)
        {
            return value switch
            {
                ReceptionWidgetAppearancePlacement.Bottom => "bottom",
                ReceptionWidgetAppearancePlacement.BottomLeft => "bottom-left",
                ReceptionWidgetAppearancePlacement.BottomRight => "bottom-right",
                ReceptionWidgetAppearancePlacement.Top => "top",
                ReceptionWidgetAppearancePlacement.TopLeft => "top-left",
                ReceptionWidgetAppearancePlacement.TopRight => "top-right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionWidgetAppearancePlacement? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => ReceptionWidgetAppearancePlacement.Bottom,
                "bottom-left" => ReceptionWidgetAppearancePlacement.BottomLeft,
                "bottom-right" => ReceptionWidgetAppearancePlacement.BottomRight,
                "top" => ReceptionWidgetAppearancePlacement.Top,
                "top-left" => ReceptionWidgetAppearancePlacement.TopLeft,
                "top-right" => ReceptionWidgetAppearancePlacement.TopRight,
                _ => null,
            };
        }
    }
}