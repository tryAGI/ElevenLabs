
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum Currency
    {
        /// <summary>
        /// 
        /// </summary>
        Eur,
        /// <summary>
        /// 
        /// </summary>
        Inr,
        /// <summary>
        /// 
        /// </summary>
        Pln,
        /// <summary>
        /// 
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Currency value)
        {
            return value switch
            {
                Currency.Eur => "eur",
                Currency.Inr => "inr",
                Currency.Pln => "pln",
                Currency.Usd => "usd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Currency? ToEnum(string value)
        {
            return value switch
            {
                "eur" => Currency.Eur,
                "inr" => Currency.Inr,
                "pln" => Currency.Pln,
                "usd" => Currency.Usd,
                _ => null,
            };
        }
    }
}