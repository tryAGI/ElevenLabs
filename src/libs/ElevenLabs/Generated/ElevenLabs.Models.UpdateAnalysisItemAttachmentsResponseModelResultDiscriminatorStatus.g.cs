
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failure,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus value)
        {
            return value switch
            {
                UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus.Failure => "failure",
                UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus.Failure,
                "success" => UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus.Success,
                _ => null,
            };
        }
    }
}