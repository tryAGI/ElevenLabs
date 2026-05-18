
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
                OrderState.Done => "done",
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
                "done" => OrderState.Done,
                "open" => OrderState.Open,
                "paid" => OrderState.Paid,
                "rejected" => OrderState.Rejected,
                "submitted" => OrderState.Submitted,
                _ => null,
            };
        }
    }
}