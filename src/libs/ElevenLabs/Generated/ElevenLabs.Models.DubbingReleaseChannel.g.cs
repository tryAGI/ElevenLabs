
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum DubbingReleaseChannel
    {
        /// <summary>
        ///
        /// </summary>
        Experimental,
        /// <summary>
        ///
        /// </summary>
        Release,
        /// <summary>
        ///
        /// </summary>
        Stable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DubbingReleaseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbingReleaseChannel value)
        {
            return value switch
            {
                DubbingReleaseChannel.Experimental => "experimental",
                DubbingReleaseChannel.Release => "release",
                DubbingReleaseChannel.Stable => "stable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbingReleaseChannel? ToEnum(string value)
        {
            return value switch
            {
                "experimental" => DubbingReleaseChannel.Experimental,
                "release" => DubbingReleaseChannel.Release,
                "stable" => DubbingReleaseChannel.Stable,
                _ => null,
            };
        }
    }
}