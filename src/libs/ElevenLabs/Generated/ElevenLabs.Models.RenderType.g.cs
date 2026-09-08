
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum RenderType
    {
        /// <summary>
        ///
        /// </summary>
        Aac,
        /// <summary>
        ///
        /// </summary>
        Aaf,
        /// <summary>
        ///
        /// </summary>
        ClipsZip,
        /// <summary>
        ///
        /// </summary>
        Mp3,
        /// <summary>
        ///
        /// </summary>
        Mp4,
        /// <summary>
        ///
        /// </summary>
        TracksZip,
        /// <summary>
        ///
        /// </summary>
        Wav,
        /// <summary>
        ///
        /// </summary>
        Zip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RenderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenderType value)
        {
            return value switch
            {
                RenderType.Aac => "aac",
                RenderType.Aaf => "aaf",
                RenderType.ClipsZip => "clips_zip",
                RenderType.Mp3 => "mp3",
                RenderType.Mp4 => "mp4",
                RenderType.TracksZip => "tracks_zip",
                RenderType.Wav => "wav",
                RenderType.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenderType? ToEnum(string value)
        {
            return value switch
            {
                "aac" => RenderType.Aac,
                "aaf" => RenderType.Aaf,
                "clips_zip" => RenderType.ClipsZip,
                "mp3" => RenderType.Mp3,
                "mp4" => RenderType.Mp4,
                "tracks_zip" => RenderType.TracksZip,
                "wav" => RenderType.Wav,
                "zip" => RenderType.Zip,
                _ => null,
            };
        }
    }
}