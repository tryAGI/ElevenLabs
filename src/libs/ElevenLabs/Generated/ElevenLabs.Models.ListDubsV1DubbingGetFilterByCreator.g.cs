
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Filters who created the resources being listed, whether it was the user running the request or someone else that shared the resource with them.<br/>
    /// Default Value: all<br/>
    /// Example: all
    /// </summary>
    public enum ListDubsV1DubbingGetFilterByCreator
    {
        /// <summary>
        /// 
        /// </summary>
        Personal,
        /// <summary>
        /// 
        /// </summary>
        Others,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDubsV1DubbingGetFilterByCreatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDubsV1DubbingGetFilterByCreator value)
        {
            return value switch
            {
                ListDubsV1DubbingGetFilterByCreator.Personal => "personal",
                ListDubsV1DubbingGetFilterByCreator.Others => "others",
                ListDubsV1DubbingGetFilterByCreator.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDubsV1DubbingGetFilterByCreator? ToEnum(string value)
        {
            return value switch
            {
                "personal" => ListDubsV1DubbingGetFilterByCreator.Personal,
                "others" => ListDubsV1DubbingGetFilterByCreator.Others,
                "all" => ListDubsV1DubbingGetFilterByCreator.All,
                _ => null,
            };
        }
    }
}