
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Whether a catalog item's price and duration are known up front.<br/>
    /// - `fixed`: the catalog price and duration apply (the default).<br/>
    /// - `quote`: neither is known until the owner has seen the job. The<br/>
    ///   receptionist collects intake answers and files a quote request instead<br/>
    ///   of booking a slot or taking an order.<br/>
    /// Default Value: fixed
    /// </summary>
    public enum PricingMode
    {
        /// <summary>
        /// the catalog price and duration apply (the default).
        /// </summary>
        Fixed,
        /// <summary>
        /// neither is known until the owner has seen the job. The
        /// </summary>
        Quote,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PricingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingMode value)
        {
            return value switch
            {
                PricingMode.Fixed => "fixed",
                PricingMode.Quote => "quote",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingMode? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => PricingMode.Fixed,
                "quote" => PricingMode.Quote,
                _ => null,
            };
        }
    }
}