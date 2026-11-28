
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// What the prices are in. The same for every tier on a ladder.
    /// </summary>
    public enum ResellerTierResponseCurrency
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
        Gel,
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
    public static class ResellerTierResponseCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResellerTierResponseCurrency value)
        {
            return value switch
            {
                ResellerTierResponseCurrency.Aed => "AED",
                ResellerTierResponseCurrency.Ars => "ARS",
                ResellerTierResponseCurrency.Aud => "AUD",
                ResellerTierResponseCurrency.Bdt => "BDT",
                ResellerTierResponseCurrency.Bgn => "BGN",
                ResellerTierResponseCurrency.Brl => "BRL",
                ResellerTierResponseCurrency.Cad => "CAD",
                ResellerTierResponseCurrency.Chf => "CHF",
                ResellerTierResponseCurrency.Clp => "CLP",
                ResellerTierResponseCurrency.Cny => "CNY",
                ResellerTierResponseCurrency.Cop => "COP",
                ResellerTierResponseCurrency.Czk => "CZK",
                ResellerTierResponseCurrency.Dkk => "DKK",
                ResellerTierResponseCurrency.Egp => "EGP",
                ResellerTierResponseCurrency.Eur => "EUR",
                ResellerTierResponseCurrency.Gbp => "GBP",
                ResellerTierResponseCurrency.Gel => "GEL",
                ResellerTierResponseCurrency.Hkd => "HKD",
                ResellerTierResponseCurrency.Huf => "HUF",
                ResellerTierResponseCurrency.Idr => "IDR",
                ResellerTierResponseCurrency.Ils => "ILS",
                ResellerTierResponseCurrency.Inr => "INR",
                ResellerTierResponseCurrency.Isk => "ISK",
                ResellerTierResponseCurrency.Jpy => "JPY",
                ResellerTierResponseCurrency.Kes => "KES",
                ResellerTierResponseCurrency.Krw => "KRW",
                ResellerTierResponseCurrency.Kwd => "KWD",
                ResellerTierResponseCurrency.Mxn => "MXN",
                ResellerTierResponseCurrency.Myr => "MYR",
                ResellerTierResponseCurrency.Ngn => "NGN",
                ResellerTierResponseCurrency.Nok => "NOK",
                ResellerTierResponseCurrency.Nzd => "NZD",
                ResellerTierResponseCurrency.Pen => "PEN",
                ResellerTierResponseCurrency.Php => "PHP",
                ResellerTierResponseCurrency.Pkr => "PKR",
                ResellerTierResponseCurrency.Pln => "PLN",
                ResellerTierResponseCurrency.Qar => "QAR",
                ResellerTierResponseCurrency.Ron => "RON",
                ResellerTierResponseCurrency.Rub => "RUB",
                ResellerTierResponseCurrency.Sar => "SAR",
                ResellerTierResponseCurrency.Sek => "SEK",
                ResellerTierResponseCurrency.Sgd => "SGD",
                ResellerTierResponseCurrency.Thb => "THB",
                ResellerTierResponseCurrency.Try => "TRY",
                ResellerTierResponseCurrency.Twd => "TWD",
                ResellerTierResponseCurrency.Uah => "UAH",
                ResellerTierResponseCurrency.Usd => "USD",
                ResellerTierResponseCurrency.Vnd => "VND",
                ResellerTierResponseCurrency.Zar => "ZAR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResellerTierResponseCurrency? ToEnum(string value)
        {
            return value switch
            {
                "AED" => ResellerTierResponseCurrency.Aed,
                "ARS" => ResellerTierResponseCurrency.Ars,
                "AUD" => ResellerTierResponseCurrency.Aud,
                "BDT" => ResellerTierResponseCurrency.Bdt,
                "BGN" => ResellerTierResponseCurrency.Bgn,
                "BRL" => ResellerTierResponseCurrency.Brl,
                "CAD" => ResellerTierResponseCurrency.Cad,
                "CHF" => ResellerTierResponseCurrency.Chf,
                "CLP" => ResellerTierResponseCurrency.Clp,
                "CNY" => ResellerTierResponseCurrency.Cny,
                "COP" => ResellerTierResponseCurrency.Cop,
                "CZK" => ResellerTierResponseCurrency.Czk,
                "DKK" => ResellerTierResponseCurrency.Dkk,
                "EGP" => ResellerTierResponseCurrency.Egp,
                "EUR" => ResellerTierResponseCurrency.Eur,
                "GBP" => ResellerTierResponseCurrency.Gbp,
                "GEL" => ResellerTierResponseCurrency.Gel,
                "HKD" => ResellerTierResponseCurrency.Hkd,
                "HUF" => ResellerTierResponseCurrency.Huf,
                "IDR" => ResellerTierResponseCurrency.Idr,
                "ILS" => ResellerTierResponseCurrency.Ils,
                "INR" => ResellerTierResponseCurrency.Inr,
                "ISK" => ResellerTierResponseCurrency.Isk,
                "JPY" => ResellerTierResponseCurrency.Jpy,
                "KES" => ResellerTierResponseCurrency.Kes,
                "KRW" => ResellerTierResponseCurrency.Krw,
                "KWD" => ResellerTierResponseCurrency.Kwd,
                "MXN" => ResellerTierResponseCurrency.Mxn,
                "MYR" => ResellerTierResponseCurrency.Myr,
                "NGN" => ResellerTierResponseCurrency.Ngn,
                "NOK" => ResellerTierResponseCurrency.Nok,
                "NZD" => ResellerTierResponseCurrency.Nzd,
                "PEN" => ResellerTierResponseCurrency.Pen,
                "PHP" => ResellerTierResponseCurrency.Php,
                "PKR" => ResellerTierResponseCurrency.Pkr,
                "PLN" => ResellerTierResponseCurrency.Pln,
                "QAR" => ResellerTierResponseCurrency.Qar,
                "RON" => ResellerTierResponseCurrency.Ron,
                "RUB" => ResellerTierResponseCurrency.Rub,
                "SAR" => ResellerTierResponseCurrency.Sar,
                "SEK" => ResellerTierResponseCurrency.Sek,
                "SGD" => ResellerTierResponseCurrency.Sgd,
                "THB" => ResellerTierResponseCurrency.Thb,
                "TRY" => ResellerTierResponseCurrency.Try,
                "TWD" => ResellerTierResponseCurrency.Twd,
                "UAH" => ResellerTierResponseCurrency.Uah,
                "USD" => ResellerTierResponseCurrency.Usd,
                "VND" => ResellerTierResponseCurrency.Vnd,
                "ZAR" => ResellerTierResponseCurrency.Zar,
                _ => null,
            };
        }
    }
}