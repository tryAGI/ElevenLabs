
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The type of asset (image, video, text, or audio).
    /// </summary>
    public enum StaticAssetNodeModality
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
    public static class StaticAssetNodeModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StaticAssetNodeModality value)
        {
            return value switch
            {
                StaticAssetNodeModality.Audio => "audio",
                StaticAssetNodeModality.Image => "image",
                StaticAssetNodeModality.Text => "text",
                StaticAssetNodeModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StaticAssetNodeModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => StaticAssetNodeModality.Audio,
                "image" => StaticAssetNodeModality.Image,
                "text" => StaticAssetNodeModality.Text,
                "video" => StaticAssetNodeModality.Video,
                _ => null,
            };
        }
    }
}