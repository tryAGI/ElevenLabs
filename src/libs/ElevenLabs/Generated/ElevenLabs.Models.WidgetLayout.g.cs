
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: default
    /// </summary>
    public enum WidgetLayout
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        SidePanel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WidgetLayoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetLayout value)
        {
            return value switch
            {
                WidgetLayout.Default => "default",
                WidgetLayout.SidePanel => "side-panel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetLayout? ToEnum(string value)
        {
            return value switch
            {
                "default" => WidgetLayout.Default,
                "side-panel" => WidgetLayout.SidePanel,
                _ => null,
            };
        }
    }
}