
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: start
    /// </summary>
    public enum IntervalPlacement
    {
        /// <summary>
        ///
        /// </summary>
        Random,
        /// <summary>
        ///
        /// </summary>
        Rotate,
        /// <summary>
        ///
        /// </summary>
        Start,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntervalPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntervalPlacement value)
        {
            return value switch
            {
                IntervalPlacement.Random => "random",
                IntervalPlacement.Rotate => "rotate",
                IntervalPlacement.Start => "start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntervalPlacement? ToEnum(string value)
        {
            return value switch
            {
                "random" => IntervalPlacement.Random,
                "rotate" => IntervalPlacement.Rotate,
                "start" => IntervalPlacement.Start,
                _ => null,
            };
        }
    }
}