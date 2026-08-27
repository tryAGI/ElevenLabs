
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchStrategy
    {
        /// <summary>
        ///
        /// </summary>
        Cat,
        /// <summary>
        ///
        /// </summary>
        Keyword,
        /// <summary>
        ///
        /// </summary>
        Ls,
        /// <summary>
        ///
        /// </summary>
        Semantic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchStrategy value)
        {
            return value switch
            {
                SearchStrategy.Cat => "cat",
                SearchStrategy.Keyword => "keyword",
                SearchStrategy.Ls => "ls",
                SearchStrategy.Semantic => "semantic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchStrategy? ToEnum(string value)
        {
            return value switch
            {
                "cat" => SearchStrategy.Cat,
                "keyword" => SearchStrategy.Keyword,
                "ls" => SearchStrategy.Ls,
                "semantic" => SearchStrategy.Semantic,
                _ => null,
            };
        }
    }
}