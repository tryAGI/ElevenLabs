
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ResellerInvoiceLineKind
    {
        /// <summary>
        ///
        /// </summary>
        Adjustment,
        /// <summary>
        ///
        /// </summary>
        Overage,
        /// <summary>
        ///
        /// </summary>
        Plan,
        /// <summary>
        ///
        /// </summary>
        Proration,
        /// <summary>
        ///
        /// </summary>
        Telephony,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResellerInvoiceLineKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResellerInvoiceLineKind value)
        {
            return value switch
            {
                ResellerInvoiceLineKind.Adjustment => "adjustment",
                ResellerInvoiceLineKind.Overage => "overage",
                ResellerInvoiceLineKind.Plan => "plan",
                ResellerInvoiceLineKind.Proration => "proration",
                ResellerInvoiceLineKind.Telephony => "telephony",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResellerInvoiceLineKind? ToEnum(string value)
        {
            return value switch
            {
                "adjustment" => ResellerInvoiceLineKind.Adjustment,
                "overage" => ResellerInvoiceLineKind.Overage,
                "plan" => ResellerInvoiceLineKind.Plan,
                "proration" => ResellerInvoiceLineKind.Proration,
                "telephony" => ResellerInvoiceLineKind.Telephony,
                _ => null,
            };
        }
    }
}