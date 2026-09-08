
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum StudioClipLocatorClipType
    {
        /// <summary>
        ///
        /// </summary>
        ExternalAudio,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        TtsNode,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StudioClipLocatorClipTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StudioClipLocatorClipType value)
        {
            return value switch
            {
                StudioClipLocatorClipType.ExternalAudio => "external_audio",
                StudioClipLocatorClipType.Image => "image",
                StudioClipLocatorClipType.TtsNode => "tts_node",
                StudioClipLocatorClipType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StudioClipLocatorClipType? ToEnum(string value)
        {
            return value switch
            {
                "external_audio" => StudioClipLocatorClipType.ExternalAudio,
                "image" => StudioClipLocatorClipType.Image,
                "tts_node" => StudioClipLocatorClipType.TtsNode,
                "video" => StudioClipLocatorClipType.Video,
                _ => null,
            };
        }
    }
}