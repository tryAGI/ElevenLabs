
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Currency code for all prices (ISO 4217)<br/>
    /// Default Value: USD
    /// </summary>
    public enum ReceptionAgentInfoResponseCurrency
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
    public static class ReceptionAgentInfoResponseCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionAgentInfoResponseCurrency value)
        {
            return value switch
            {
                ReceptionAgentInfoResponseCurrency.Aed => "AED",
                ReceptionAgentInfoResponseCurrency.Ars => "ARS",
                ReceptionAgentInfoResponseCurrency.Aud => "AUD",
                ReceptionAgentInfoResponseCurrency.Bdt => "BDT",
                ReceptionAgentInfoResponseCurrency.Bgn => "BGN",
                ReceptionAgentInfoResponseCurrency.Brl => "BRL",
                ReceptionAgentInfoResponseCurrency.Cad => "CAD",
                ReceptionAgentInfoResponseCurrency.Chf => "CHF",
                ReceptionAgentInfoResponseCurrency.Clp => "CLP",
                ReceptionAgentInfoResponseCurrency.Cny => "CNY",
                ReceptionAgentInfoResponseCurrency.Cop => "COP",
                ReceptionAgentInfoResponseCurrency.Czk => "CZK",
                ReceptionAgentInfoResponseCurrency.Dkk => "DKK",
                ReceptionAgentInfoResponseCurrency.Egp => "EGP",
                ReceptionAgentInfoResponseCurrency.Eur => "EUR",
                ReceptionAgentInfoResponseCurrency.Gbp => "GBP",
                ReceptionAgentInfoResponseCurrency.Hkd => "HKD",
                ReceptionAgentInfoResponseCurrency.Huf => "HUF",
                ReceptionAgentInfoResponseCurrency.Idr => "IDR",
                ReceptionAgentInfoResponseCurrency.Ils => "ILS",
                ReceptionAgentInfoResponseCurrency.Inr => "INR",
                ReceptionAgentInfoResponseCurrency.Isk => "ISK",
                ReceptionAgentInfoResponseCurrency.Jpy => "JPY",
                ReceptionAgentInfoResponseCurrency.Kes => "KES",
                ReceptionAgentInfoResponseCurrency.Krw => "KRW",
                ReceptionAgentInfoResponseCurrency.Kwd => "KWD",
                ReceptionAgentInfoResponseCurrency.Mxn => "MXN",
                ReceptionAgentInfoResponseCurrency.Myr => "MYR",
                ReceptionAgentInfoResponseCurrency.Ngn => "NGN",
                ReceptionAgentInfoResponseCurrency.Nok => "NOK",
                ReceptionAgentInfoResponseCurrency.Nzd => "NZD",
                ReceptionAgentInfoResponseCurrency.Pen => "PEN",
                ReceptionAgentInfoResponseCurrency.Php => "PHP",
                ReceptionAgentInfoResponseCurrency.Pkr => "PKR",
                ReceptionAgentInfoResponseCurrency.Pln => "PLN",
                ReceptionAgentInfoResponseCurrency.Qar => "QAR",
                ReceptionAgentInfoResponseCurrency.Ron => "RON",
                ReceptionAgentInfoResponseCurrency.Rub => "RUB",
                ReceptionAgentInfoResponseCurrency.Sar => "SAR",
                ReceptionAgentInfoResponseCurrency.Sek => "SEK",
                ReceptionAgentInfoResponseCurrency.Sgd => "SGD",
                ReceptionAgentInfoResponseCurrency.Thb => "THB",
                ReceptionAgentInfoResponseCurrency.Try => "TRY",
                ReceptionAgentInfoResponseCurrency.Twd => "TWD",
                ReceptionAgentInfoResponseCurrency.Uah => "UAH",
                ReceptionAgentInfoResponseCurrency.Usd => "USD",
                ReceptionAgentInfoResponseCurrency.Vnd => "VND",
                ReceptionAgentInfoResponseCurrency.Zar => "ZAR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionAgentInfoResponseCurrency? ToEnum(string value)
        {
            return value switch
            {
                "AED" => ReceptionAgentInfoResponseCurrency.Aed,
                "ARS" => ReceptionAgentInfoResponseCurrency.Ars,
                "AUD" => ReceptionAgentInfoResponseCurrency.Aud,
                "BDT" => ReceptionAgentInfoResponseCurrency.Bdt,
                "BGN" => ReceptionAgentInfoResponseCurrency.Bgn,
                "BRL" => ReceptionAgentInfoResponseCurrency.Brl,
                "CAD" => ReceptionAgentInfoResponseCurrency.Cad,
                "CHF" => ReceptionAgentInfoResponseCurrency.Chf,
                "CLP" => ReceptionAgentInfoResponseCurrency.Clp,
                "CNY" => ReceptionAgentInfoResponseCurrency.Cny,
                "COP" => ReceptionAgentInfoResponseCurrency.Cop,
                "CZK" => ReceptionAgentInfoResponseCurrency.Czk,
                "DKK" => ReceptionAgentInfoResponseCurrency.Dkk,
                "EGP" => ReceptionAgentInfoResponseCurrency.Egp,
                "EUR" => ReceptionAgentInfoResponseCurrency.Eur,
                "GBP" => ReceptionAgentInfoResponseCurrency.Gbp,
                "HKD" => ReceptionAgentInfoResponseCurrency.Hkd,
                "HUF" => ReceptionAgentInfoResponseCurrency.Huf,
                "IDR" => ReceptionAgentInfoResponseCurrency.Idr,
                "ILS" => ReceptionAgentInfoResponseCurrency.Ils,
                "INR" => ReceptionAgentInfoResponseCurrency.Inr,
                "ISK" => ReceptionAgentInfoResponseCurrency.Isk,
                "JPY" => ReceptionAgentInfoResponseCurrency.Jpy,
                "KES" => ReceptionAgentInfoResponseCurrency.Kes,
                "KRW" => ReceptionAgentInfoResponseCurrency.Krw,
                "KWD" => ReceptionAgentInfoResponseCurrency.Kwd,
                "MXN" => ReceptionAgentInfoResponseCurrency.Mxn,
                "MYR" => ReceptionAgentInfoResponseCurrency.Myr,
                "NGN" => ReceptionAgentInfoResponseCurrency.Ngn,
                "NOK" => ReceptionAgentInfoResponseCurrency.Nok,
                "NZD" => ReceptionAgentInfoResponseCurrency.Nzd,
                "PEN" => ReceptionAgentInfoResponseCurrency.Pen,
                "PHP" => ReceptionAgentInfoResponseCurrency.Php,
                "PKR" => ReceptionAgentInfoResponseCurrency.Pkr,
                "PLN" => ReceptionAgentInfoResponseCurrency.Pln,
                "QAR" => ReceptionAgentInfoResponseCurrency.Qar,
                "RON" => ReceptionAgentInfoResponseCurrency.Ron,
                "RUB" => ReceptionAgentInfoResponseCurrency.Rub,
                "SAR" => ReceptionAgentInfoResponseCurrency.Sar,
                "SEK" => ReceptionAgentInfoResponseCurrency.Sek,
                "SGD" => ReceptionAgentInfoResponseCurrency.Sgd,
                "THB" => ReceptionAgentInfoResponseCurrency.Thb,
                "TRY" => ReceptionAgentInfoResponseCurrency.Try,
                "TWD" => ReceptionAgentInfoResponseCurrency.Twd,
                "UAH" => ReceptionAgentInfoResponseCurrency.Uah,
                "USD" => ReceptionAgentInfoResponseCurrency.Usd,
                "VND" => ReceptionAgentInfoResponseCurrency.Vnd,
                "ZAR" => ReceptionAgentInfoResponseCurrency.Zar,
                _ => null,
            };
        }
    }
}