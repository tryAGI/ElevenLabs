
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchCallStatusResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchCallStatusResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchCallStatusResponseModelStatus value)
        {
            return value switch
            {
                BatchCallStatusResponseModelStatus.Pending => "pending",
                BatchCallStatusResponseModelStatus.Succeeded => "succeeded",
                BatchCallStatusResponseModelStatus.Failed => "failed",
                BatchCallStatusResponseModelStatus.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchCallStatusResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => BatchCallStatusResponseModelStatus.Pending,
                "succeeded" => BatchCallStatusResponseModelStatus.Succeeded,
                "failed" => BatchCallStatusResponseModelStatus.Failed,
                "cancelled" => BatchCallStatusResponseModelStatus.Cancelled,
                _ => null,
            };
        }
    }
}