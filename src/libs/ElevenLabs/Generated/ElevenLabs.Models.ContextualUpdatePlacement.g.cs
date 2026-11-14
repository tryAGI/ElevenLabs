
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Where the LLM view renders a contextual update.<br/>
    /// Default Value: in_place
    /// </summary>
    public enum ContextualUpdatePlacement
    {
        /// <summary>
        ///
        /// </summary>
        End,
        /// <summary>
        ///
        /// </summary>
        InPlace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContextualUpdatePlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContextualUpdatePlacement value)
        {
            return value switch
            {
                ContextualUpdatePlacement.End => "end",
                ContextualUpdatePlacement.InPlace => "in_place",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContextualUpdatePlacement? ToEnum(string value)
        {
            return value switch
            {
                "end" => ContextualUpdatePlacement.End,
                "in_place" => ContextualUpdatePlacement.InPlace,
                _ => null,
            };
        }
    }
}