
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentModality
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentModality value)
        {
            return value switch
            {
                ContentModality.Audio => "audio",
                ContentModality.Image => "image",
                ContentModality.Text => "text",
                ContentModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ContentModality.Audio,
                "image" => ContentModality.Image,
                "text" => ContentModality.Text,
                "video" => ContentModality.Video,
                _ => null,
            };
        }
    }
}