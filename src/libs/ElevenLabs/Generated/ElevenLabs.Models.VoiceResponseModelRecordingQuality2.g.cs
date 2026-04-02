
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceResponseModelRecordingQuality2
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
    public static class VoiceResponseModelRecordingQuality2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResponseModelRecordingQuality2 value)
        {
            return value switch
            {
                VoiceResponseModelRecordingQuality2.Bad => "bad",
                VoiceResponseModelRecordingQuality2.Good => "good",
                VoiceResponseModelRecordingQuality2.Ok => "ok",
                VoiceResponseModelRecordingQuality2.Poor => "poor",
                VoiceResponseModelRecordingQuality2.Studio => "studio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResponseModelRecordingQuality2? ToEnum(string value)
        {
            return value switch
            {
                "bad" => VoiceResponseModelRecordingQuality2.Bad,
                "good" => VoiceResponseModelRecordingQuality2.Good,
                "ok" => VoiceResponseModelRecordingQuality2.Ok,
                "poor" => VoiceResponseModelRecordingQuality2.Poor,
                "studio" => VoiceResponseModelRecordingQuality2.Studio,
                _ => null,
            };
        }
    }
}