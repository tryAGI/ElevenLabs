
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum OrderState
    {
        /// <summary>
        ///
        /// </summary>
        Accepted,
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Cancelling,
        /// <summary>
        ///
        /// </summary>
        Done,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Merged,
        /// <summary>
        ///
        /// </summary>
        Open,
        /// <summary>
        ///
        /// </summary>
        Paid,
        /// <summary>
        ///
        /// </summary>
        Rejected,
        /// <summary>
        ///
        /// </summary>
        Submitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrderStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrderState value)
        {
            return value switch
            {
                OrderState.Accepted => "accepted",
                OrderState.Cancelled => "cancelled",
                OrderState.Cancelling => "cancelling",
                OrderState.Done => "done",
                OrderState.Expired => "expired",
                OrderState.Merged => "merged",
                OrderState.Open => "open",
                OrderState.Paid => "paid",
                OrderState.Rejected => "rejected",
                OrderState.Submitted => "submitted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrderState? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => OrderState.Accepted,
                "cancelled" => OrderState.Cancelled,
                "cancelling" => OrderState.Cancelling,
                "done" => OrderState.Done,
                "expired" => OrderState.Expired,
                "merged" => OrderState.Merged,
                "open" => OrderState.Open,
                "paid" => OrderState.Paid,
                "rejected" => OrderState.Rejected,
                "submitted" => OrderState.Submitted,
                _ => null,
            };
        }
    }
}