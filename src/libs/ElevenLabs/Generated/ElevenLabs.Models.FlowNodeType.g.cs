
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// All node types in the flows canvas.
    /// </summary>
    public enum FlowNodeType
    {
        /// <summary>
        /// 
        /// </summary>
        Composition,
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Music,
        /// <summary>
        /// 
        /// </summary>
        Sfx,
        /// <summary>
        /// 
        /// </summary>
        Tts,
        /// <summary>
        /// 
        /// </summary>
        VideoGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlowNodeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlowNodeType value)
        {
            return value switch
            {
                FlowNodeType.Composition => "composition",
                FlowNodeType.ImageGeneration => "image-generation",
                FlowNodeType.Llm => "llm",
                FlowNodeType.Music => "music",
                FlowNodeType.Sfx => "sfx",
                FlowNodeType.Tts => "tts",
                FlowNodeType.VideoGeneration => "video-generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlowNodeType? ToEnum(string value)
        {
            return value switch
            {
                "composition" => FlowNodeType.Composition,
                "image-generation" => FlowNodeType.ImageGeneration,
                "llm" => FlowNodeType.Llm,
                "music" => FlowNodeType.Music,
                "sfx" => FlowNodeType.Sfx,
                "tts" => FlowNodeType.Tts,
                "video-generation" => FlowNodeType.VideoGeneration,
                _ => null,
            };
        }
    }
}