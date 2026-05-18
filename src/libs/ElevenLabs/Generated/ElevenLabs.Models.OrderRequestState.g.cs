
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrderRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        Done,
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
    public static class OrderRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrderRequestState value)
        {
            return value switch
            {
                OrderRequestState.Accepted => "accepted",
                OrderRequestState.Done => "done",
                OrderRequestState.Open => "open",
                OrderRequestState.Paid => "paid",
                OrderRequestState.Rejected => "rejected",
                OrderRequestState.Submitted => "submitted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrderRequestState? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => OrderRequestState.Accepted,
                "done" => OrderRequestState.Done,
                "open" => OrderRequestState.Open,
                "paid" => OrderRequestState.Paid,
                "rejected" => OrderRequestState.Rejected,
                "submitted" => OrderRequestState.Submitted,
                _ => null,
            };
        }
    }
}