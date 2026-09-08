
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum VoiceResponseModelRecordingQuality
    {
        /// <summary>
        ///
        /// </summary>
        Bad,
        /// <summary>
        ///
        /// </summary>
        Good,
        /// <summary>
        ///
        /// </summary>
        Ok,
        /// <summary>
        ///
        /// </summary>
        Poor,
        /// <summary>
        ///
        /// </summary>
        Studio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceResponseModelRecordingQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResponseModelRecordingQuality value)
        {
            return value switch
            {
                VoiceResponseModelRecordingQuality.Bad => "bad",
                VoiceResponseModelRecordingQuality.Good => "good",
                VoiceResponseModelRecordingQuality.Ok => "ok",
                VoiceResponseModelRecordingQuality.Poor => "poor",
                VoiceResponseModelRecordingQuality.Studio => "studio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResponseModelRecordingQuality? ToEnum(string value)
        {
            return value switch
            {
                "bad" => VoiceResponseModelRecordingQuality.Bad,
                "good" => VoiceResponseModelRecordingQuality.Good,
                "ok" => VoiceResponseModelRecordingQuality.Ok,
                "poor" => VoiceResponseModelRecordingQuality.Poor,
                "studio" => VoiceResponseModelRecordingQuality.Studio,
                _ => null,
            };
        }
    }
}