
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// What state the dub is currently in.
    /// </summary>
    public enum ListDubsV1DubbingGetDubbingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        Dubbed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDubsV1DubbingGetDubbingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDubsV1DubbingGetDubbingStatus value)
        {
            return value switch
            {
                ListDubsV1DubbingGetDubbingStatus.Dubbing => "dubbing",
                ListDubsV1DubbingGetDubbingStatus.Dubbed => "dubbed",
                ListDubsV1DubbingGetDubbingStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDubsV1DubbingGetDubbingStatus? ToEnum(string value)
        {
            return value switch
            {
                "dubbing" => ListDubsV1DubbingGetDubbingStatus.Dubbing,
                "dubbed" => ListDubsV1DubbingGetDubbingStatus.Dubbed,
                "failed" => ListDubsV1DubbingGetDubbingStatus.Failed,
                _ => null,
            };
        }
    }
}