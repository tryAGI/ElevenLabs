
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: none
    /// </summary>
    public enum MockingStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MockingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MockingStrategy value)
        {
            return value switch
            {
                MockingStrategy.All => "all",
                MockingStrategy.None => "none",
                MockingStrategy.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MockingStrategy? ToEnum(string value)
        {
            return value switch
            {
                "all" => MockingStrategy.All,
                "none" => MockingStrategy.None,
                "selected" => MockingStrategy.Selected,
                _ => null,
            };
        }
    }
}