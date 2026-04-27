
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The type of static asset: 'image', 'video', 'audio', or 'text'.
    /// </summary>
    public enum AddStaticAssetNodeInputModality
    {
        /// <summary>
        /// 'image', 'video', 'audio', or 'text'.
        /// </summary>
        Audio,
        /// <summary>
        /// 'image', 'video', 'audio', or 'text'.
        /// </summary>
        Image,
        /// <summary>
        /// 'image', 'video', 'audio', or 'text'.
        /// </summary>
        Text,
        /// <summary>
        /// 'image', 'video', 'audio', or 'text'.
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddStaticAssetNodeInputModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddStaticAssetNodeInputModality value)
        {
            return value switch
            {
                AddStaticAssetNodeInputModality.Audio => "audio",
                AddStaticAssetNodeInputModality.Image => "image",
                AddStaticAssetNodeInputModality.Text => "text",
                AddStaticAssetNodeInputModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddStaticAssetNodeInputModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AddStaticAssetNodeInputModality.Audio,
                "image" => AddStaticAssetNodeInputModality.Image,
                "text" => AddStaticAssetNodeInputModality.Text,
                "video" => AddStaticAssetNodeInputModality.Video,
                _ => null,
            };
        }
    }
}