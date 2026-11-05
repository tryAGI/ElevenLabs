
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum LenientCurrencyEnum
    {
        /// <summary>
        ///
        /// </summary>
        Aed,
        /// <summary>
        ///
        /// </summary>
        Ars,
        /// <summary>
        ///
        /// </summary>
        Aud,
        /// <summary>
        ///
        /// </summary>
        Bdt,
        /// <summary>
        ///
        /// </summary>
        Bgn,
        /// <summary>
        ///
        /// </summary>
        Brl,
        /// <summary>
        ///
        /// </summary>
        Cad,
        /// <summary>
        ///
        /// </summary>
        Chf,
        /// <summary>
        ///
        /// </summary>
        Clp,
        /// <summary>
        ///
        /// </summary>
        Cny,
        /// <summary>
        ///
        /// </summary>
        Cop,
        /// <summary>
        ///
        /// </summary>
        Czk,
        /// <summary>
        ///
        /// </summary>
        Dkk,
        /// <summary>
        ///
        /// </summary>
        Egp,
        /// <summary>
        ///
        /// </summary>
        Eur,
        /// <summary>
        ///
        /// </summary>
        Gbp,
        /// <summary>
        ///
        /// </summary>
        Hkd,
        /// <summary>
        ///
        /// </summary>
        Huf,
        /// <summary>
        ///
        /// </summary>
        Idr,
        /// <summary>
        ///
        /// </summary>
        Ils,
        /// <summary>
        ///
        /// </summary>
        Inr,
        /// <summary>
        ///
        /// </summary>
        Isk,
        /// <summary>
        ///
        /// </summary>
        Jpy,
        /// <summary>
        ///
        /// </summary>
        Kes,
        /// <summary>
        ///
        /// </summary>
        Krw,
        /// <summary>
        ///
        /// </summary>
        Kwd,
        /// <summary>
        ///
        /// </summary>
        Mxn,
        /// <summary>
        ///
        /// </summary>
        Myr,
        /// <summary>
        ///
        /// </summary>
        Ngn,
        /// <summary>
        ///
        /// </summary>
        Nok,
        /// <summary>
        ///
        /// </summary>
        Nzd,
        /// <summary>
        ///
        /// </summary>
        Pen,
        /// <summary>
        ///
        /// </summary>
        Php,
        /// <summary>
        ///
        /// </summary>
        Pkr,
        /// <summary>
        ///
        /// </summary>
        Pln,
        /// <summary>
        ///
        /// </summary>
        Qar,
        /// <summary>
        ///
        /// </summary>
        Ron,
        /// <summary>
        ///
        /// </summary>
        Rub,
        /// <summary>
        ///
        /// </summary>
        Sar,
        /// <summary>
        ///
        /// </summary>
        Sek,
        /// <summary>
        ///
        /// </summary>
        Sgd,
        /// <summary>
        ///
        /// </summary>
        Thb,
        /// <summary>
        ///
        /// </summary>
        Try,
        /// <summary>
        ///
        /// </summary>
        Twd,
        /// <summary>
        ///
        /// </summary>
        Uah,
        /// <summary>
        ///
        /// </summary>
        Usd,
        /// <summary>
        ///
        /// </summary>
        Vnd,
        /// <summary>
        ///
        /// </summary>
        Zar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LenientCurrencyEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LenientCurrencyEnum value)
        {
            return value switch
            {
                LenientCurrencyEnum.Aed => "AED",
                LenientCurrencyEnum.Ars => "ARS",
                LenientCurrencyEnum.Aud => "AUD",
                LenientCurrencyEnum.Bdt => "BDT",
                LenientCurrencyEnum.Bgn => "BGN",
                LenientCurrencyEnum.Brl => "BRL",
                LenientCurrencyEnum.Cad => "CAD",
                LenientCurrencyEnum.Chf => "CHF",
                LenientCurrencyEnum.Clp => "CLP",
                LenientCurrencyEnum.Cny => "CNY",
                LenientCurrencyEnum.Cop => "COP",
                LenientCurrencyEnum.Czk => "CZK",
                LenientCurrencyEnum.Dkk => "DKK",
                LenientCurrencyEnum.Egp => "EGP",
                LenientCurrencyEnum.Eur => "EUR",
                LenientCurrencyEnum.Gbp => "GBP",
                LenientCurrencyEnum.Hkd => "HKD",
                LenientCurrencyEnum.Huf => "HUF",
                LenientCurrencyEnum.Idr => "IDR",
                LenientCurrencyEnum.Ils => "ILS",
                LenientCurrencyEnum.Inr => "INR",
                LenientCurrencyEnum.Isk => "ISK",
                LenientCurrencyEnum.Jpy => "JPY",
                LenientCurrencyEnum.Kes => "KES",
                LenientCurrencyEnum.Krw => "KRW",
                LenientCurrencyEnum.Kwd => "KWD",
                LenientCurrencyEnum.Mxn => "MXN",
                LenientCurrencyEnum.Myr => "MYR",
                LenientCurrencyEnum.Ngn => "NGN",
                LenientCurrencyEnum.Nok => "NOK",
                LenientCurrencyEnum.Nzd => "NZD",
                LenientCurrencyEnum.Pen => "PEN",
                LenientCurrencyEnum.Php => "PHP",
                LenientCurrencyEnum.Pkr => "PKR",
                LenientCurrencyEnum.Pln => "PLN",
                LenientCurrencyEnum.Qar => "QAR",
                LenientCurrencyEnum.Ron => "RON",
                LenientCurrencyEnum.Rub => "RUB",
                LenientCurrencyEnum.Sar => "SAR",
                LenientCurrencyEnum.Sek => "SEK",
                LenientCurrencyEnum.Sgd => "SGD",
                LenientCurrencyEnum.Thb => "THB",
                LenientCurrencyEnum.Try => "TRY",
                LenientCurrencyEnum.Twd => "TWD",
                LenientCurrencyEnum.Uah => "UAH",
                LenientCurrencyEnum.Usd => "USD",
                LenientCurrencyEnum.Vnd => "VND",
                LenientCurrencyEnum.Zar => "ZAR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LenientCurrencyEnum? ToEnum(string value)
        {
            return value switch
            {
                "AED" => LenientCurrencyEnum.Aed,
                "ARS" => LenientCurrencyEnum.Ars,
                "AUD" => LenientCurrencyEnum.Aud,
                "BDT" => LenientCurrencyEnum.Bdt,
                "BGN" => LenientCurrencyEnum.Bgn,
                "BRL" => LenientCurrencyEnum.Brl,
                "CAD" => LenientCurrencyEnum.Cad,
                "CHF" => LenientCurrencyEnum.Chf,
                "CLP" => LenientCurrencyEnum.Clp,
                "CNY" => LenientCurrencyEnum.Cny,
                "COP" => LenientCurrencyEnum.Cop,
                "CZK" => LenientCurrencyEnum.Czk,
                "DKK" => LenientCurrencyEnum.Dkk,
                "EGP" => LenientCurrencyEnum.Egp,
                "EUR" => LenientCurrencyEnum.Eur,
                "GBP" => LenientCurrencyEnum.Gbp,
                "HKD" => LenientCurrencyEnum.Hkd,
                "HUF" => LenientCurrencyEnum.Huf,
                "IDR" => LenientCurrencyEnum.Idr,
                "ILS" => LenientCurrencyEnum.Ils,
                "INR" => LenientCurrencyEnum.Inr,
                "ISK" => LenientCurrencyEnum.Isk,
                "JPY" => LenientCurrencyEnum.Jpy,
                "KES" => LenientCurrencyEnum.Kes,
                "KRW" => LenientCurrencyEnum.Krw,
                "KWD" => LenientCurrencyEnum.Kwd,
                "MXN" => LenientCurrencyEnum.Mxn,
                "MYR" => LenientCurrencyEnum.Myr,
                "NGN" => LenientCurrencyEnum.Ngn,
                "NOK" => LenientCurrencyEnum.Nok,
                "NZD" => LenientCurrencyEnum.Nzd,
                "PEN" => LenientCurrencyEnum.Pen,
                "PHP" => LenientCurrencyEnum.Php,
                "PKR" => LenientCurrencyEnum.Pkr,
                "PLN" => LenientCurrencyEnum.Pln,
                "QAR" => LenientCurrencyEnum.Qar,
                "RON" => LenientCurrencyEnum.Ron,
                "RUB" => LenientCurrencyEnum.Rub,
                "SAR" => LenientCurrencyEnum.Sar,
                "SEK" => LenientCurrencyEnum.Sek,
                "SGD" => LenientCurrencyEnum.Sgd,
                "THB" => LenientCurrencyEnum.Thb,
                "TRY" => LenientCurrencyEnum.Try,
                "TWD" => LenientCurrencyEnum.Twd,
                "UAH" => LenientCurrencyEnum.Uah,
                "USD" => LenientCurrencyEnum.Usd,
                "VND" => LenientCurrencyEnum.Vnd,
                "ZAR" => LenientCurrencyEnum.Zar,
                _ => null,
            };
        }
    }
}