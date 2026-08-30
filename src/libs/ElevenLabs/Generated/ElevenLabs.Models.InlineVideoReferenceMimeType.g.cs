
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The MIME type of the encoded video.
    /// </summary>
    public enum InlineVideoReferenceMimeType
    {
        /// <summary>
        ///
        /// </summary>
        VideoMp4,
        /// <summary>
        ///
        /// </summary>
        VideoQuicktime,
        /// <summary>
        ///
        /// </summary>
        VideoWebm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InlineVideoReferenceMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InlineVideoReferenceMimeType value)
        {
            return value switch
            {
                InlineVideoReferenceMimeType.VideoMp4 => "video/mp4",
                InlineVideoReferenceMimeType.VideoQuicktime => "video/quicktime",
                InlineVideoReferenceMimeType.VideoWebm => "video/webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InlineVideoReferenceMimeType? ToEnum(string value)
        {
            return value switch
            {
                "video/mp4" => InlineVideoReferenceMimeType.VideoMp4,
                "video/quicktime" => InlineVideoReferenceMimeType.VideoQuicktime,
                "video/webm" => InlineVideoReferenceMimeType.VideoWebm,
                _ => null,
            };
        }
    }
}