
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// `open` while the card is still being retried; `void` once retries ran out and the workspace's plan was ended.
    /// </summary>
    public enum ResellerInvoiceStatus
    {
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
        Void,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResellerInvoiceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResellerInvoiceStatus value)
        {
            return value switch
            {
                ResellerInvoiceStatus.Open => "open",
                ResellerInvoiceStatus.Paid => "paid",
                ResellerInvoiceStatus.Void => "void",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResellerInvoiceStatus? ToEnum(string value)
        {
            return value switch
            {
                "open" => ResellerInvoiceStatus.Open,
                "paid" => ResellerInvoiceStatus.Paid,
                "void" => ResellerInvoiceStatus.Void,
                _ => null,
            };
        }
    }
}