
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Whether a catalog item's price and duration are known up front.<br/>
    /// Orthogonal to :class:`SMBServiceKind`, which describes the *resource*<br/>
    /// model (staff / asset / seats) rather than the price. A quotable service<br/>
    /// can still be staff-delivered or asset-based, so this cannot be folded<br/>
    /// into the kind discriminator.<br/>
    /// - ``FIXED``: catalog price and duration apply (the default, and every<br/>
    ///   pre-existing item).<br/>
    /// - ``QUOTE``: neither is knowable until the owner has seen the job. The<br/>
    ///   agent collects intake answers and files a quote request instead of<br/>
    ///   booking a slot or taking an order.<br/>
    /// Default Value: fixed
    /// </summary>
    public enum PricingMode
    {
        /// <summary>
        ///
        /// </summary>
        Fixed,
        /// <summary>
        ///
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