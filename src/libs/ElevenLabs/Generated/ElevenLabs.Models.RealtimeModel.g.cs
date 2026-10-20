
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: eleven_realtime_v1_mini
    /// </summary>
    public enum RealtimeModel
    {
        /// <summary>
        ///
        /// </summary>
        ElevenRealtimeV1Max,
        /// <summary>
        ///
        /// </summary>
        ElevenRealtimeV1Mini,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeModel value)
        {
            return value switch
            {
                RealtimeModel.ElevenRealtimeV1Max => "eleven_realtime_v1_max",
                RealtimeModel.ElevenRealtimeV1Mini => "eleven_realtime_v1_mini",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_realtime_v1_max" => RealtimeModel.ElevenRealtimeV1Max,
                "eleven_realtime_v1_mini" => RealtimeModel.ElevenRealtimeV1Mini,
                _ => null,
            };
        }
    }
}