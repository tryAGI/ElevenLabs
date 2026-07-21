
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum MusicFinetuneFailureReason
    {
        /// <summary>
        /// 
        /// </summary>
        AudioProcessingFailed,
        /// <summary>
        /// 
        /// </summary>
        CopyrightViolation,
        /// <summary>
        /// 
        /// </summary>
        TrainingFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MusicFinetuneFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MusicFinetuneFailureReason value)
        {
            return value switch
            {
                MusicFinetuneFailureReason.AudioProcessingFailed => "audio_processing_failed",
                MusicFinetuneFailureReason.CopyrightViolation => "copyright_violation",
                MusicFinetuneFailureReason.TrainingFailed => "training_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MusicFinetuneFailureReason? ToEnum(string value)
        {
            return value switch
            {
                "audio_processing_failed" => MusicFinetuneFailureReason.AudioProcessingFailed,
                "copyright_violation" => MusicFinetuneFailureReason.CopyrightViolation,
                "training_failed" => MusicFinetuneFailureReason.TrainingFailed,
                _ => null,
            };
        }
    }
}