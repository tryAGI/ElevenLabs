
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Currency code for all prices (ISO 4217)<br/>
    /// Default Value: USD
    /// </summary>
    public enum SMBUpdateAgentInfoRequestCurrency
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
    public static class SMBUpdateAgentInfoRequestCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBUpdateAgentInfoRequestCurrency value)
        {
            return value switch
            {
                SMBUpdateAgentInfoRequestCurrency.Aed => "AED",
                SMBUpdateAgentInfoRequestCurrency.Ars => "ARS",
                SMBUpdateAgentInfoRequestCurrency.Aud => "AUD",
                SMBUpdateAgentInfoRequestCurrency.Bdt => "BDT",
                SMBUpdateAgentInfoRequestCurrency.Bgn => "BGN",
                SMBUpdateAgentInfoRequestCurrency.Brl => "BRL",
                SMBUpdateAgentInfoRequestCurrency.Cad => "CAD",
                SMBUpdateAgentInfoRequestCurrency.Chf => "CHF",
                SMBUpdateAgentInfoRequestCurrency.Clp => "CLP",
                SMBUpdateAgentInfoRequestCurrency.Cny => "CNY",
                SMBUpdateAgentInfoRequestCurrency.Cop => "COP",
                SMBUpdateAgentInfoRequestCurrency.Czk => "CZK",
                SMBUpdateAgentInfoRequestCurrency.Dkk => "DKK",
                SMBUpdateAgentInfoRequestCurrency.Egp => "EGP",
                SMBUpdateAgentInfoRequestCurrency.Eur => "EUR",
                SMBUpdateAgentInfoRequestCurrency.Gbp => "GBP",
                SMBUpdateAgentInfoRequestCurrency.Hkd => "HKD",
                SMBUpdateAgentInfoRequestCurrency.Huf => "HUF",
                SMBUpdateAgentInfoRequestCurrency.Idr => "IDR",
                SMBUpdateAgentInfoRequestCurrency.Ils => "ILS",
                SMBUpdateAgentInfoRequestCurrency.Inr => "INR",
                SMBUpdateAgentInfoRequestCurrency.Isk => "ISK",
                SMBUpdateAgentInfoRequestCurrency.Jpy => "JPY",
                SMBUpdateAgentInfoRequestCurrency.Kes => "KES",
                SMBUpdateAgentInfoRequestCurrency.Krw => "KRW",
                SMBUpdateAgentInfoRequestCurrency.Kwd => "KWD",
                SMBUpdateAgentInfoRequestCurrency.Mxn => "MXN",
                SMBUpdateAgentInfoRequestCurrency.Myr => "MYR",
                SMBUpdateAgentInfoRequestCurrency.Ngn => "NGN",
                SMBUpdateAgentInfoRequestCurrency.Nok => "NOK",
                SMBUpdateAgentInfoRequestCurrency.Nzd => "NZD",
                SMBUpdateAgentInfoRequestCurrency.Pen => "PEN",
                SMBUpdateAgentInfoRequestCurrency.Php => "PHP",
                SMBUpdateAgentInfoRequestCurrency.Pkr => "PKR",
                SMBUpdateAgentInfoRequestCurrency.Pln => "PLN",
                SMBUpdateAgentInfoRequestCurrency.Qar => "QAR",
                SMBUpdateAgentInfoRequestCurrency.Ron => "RON",
                SMBUpdateAgentInfoRequestCurrency.Rub => "RUB",
                SMBUpdateAgentInfoRequestCurrency.Sar => "SAR",
                SMBUpdateAgentInfoRequestCurrency.Sek => "SEK",
                SMBUpdateAgentInfoRequestCurrency.Sgd => "SGD",
                SMBUpdateAgentInfoRequestCurrency.Thb => "THB",
                SMBUpdateAgentInfoRequestCurrency.Try => "TRY",
                SMBUpdateAgentInfoRequestCurrency.Twd => "TWD",
                SMBUpdateAgentInfoRequestCurrency.Uah => "UAH",
                SMBUpdateAgentInfoRequestCurrency.Usd => "USD",
                SMBUpdateAgentInfoRequestCurrency.Vnd => "VND",
                SMBUpdateAgentInfoRequestCurrency.Zar => "ZAR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBUpdateAgentInfoRequestCurrency? ToEnum(string value)
        {
            return value switch
            {
                "AED" => SMBUpdateAgentInfoRequestCurrency.Aed,
                "ARS" => SMBUpdateAgentInfoRequestCurrency.Ars,
                "AUD" => SMBUpdateAgentInfoRequestCurrency.Aud,
                "BDT" => SMBUpdateAgentInfoRequestCurrency.Bdt,
                "BGN" => SMBUpdateAgentInfoRequestCurrency.Bgn,
                "BRL" => SMBUpdateAgentInfoRequestCurrency.Brl,
                "CAD" => SMBUpdateAgentInfoRequestCurrency.Cad,
                "CHF" => SMBUpdateAgentInfoRequestCurrency.Chf,
                "CLP" => SMBUpdateAgentInfoRequestCurrency.Clp,
                "CNY" => SMBUpdateAgentInfoRequestCurrency.Cny,
                "COP" => SMBUpdateAgentInfoRequestCurrency.Cop,
                "CZK" => SMBUpdateAgentInfoRequestCurrency.Czk,
                "DKK" => SMBUpdateAgentInfoRequestCurrency.Dkk,
                "EGP" => SMBUpdateAgentInfoRequestCurrency.Egp,
                "EUR" => SMBUpdateAgentInfoRequestCurrency.Eur,
                "GBP" => SMBUpdateAgentInfoRequestCurrency.Gbp,
                "HKD" => SMBUpdateAgentInfoRequestCurrency.Hkd,
                "HUF" => SMBUpdateAgentInfoRequestCurrency.Huf,
                "IDR" => SMBUpdateAgentInfoRequestCurrency.Idr,
                "ILS" => SMBUpdateAgentInfoRequestCurrency.Ils,
                "INR" => SMBUpdateAgentInfoRequestCurrency.Inr,
                "ISK" => SMBUpdateAgentInfoRequestCurrency.Isk,
                "JPY" => SMBUpdateAgentInfoRequestCurrency.Jpy,
                "KES" => SMBUpdateAgentInfoRequestCurrency.Kes,
                "KRW" => SMBUpdateAgentInfoRequestCurrency.Krw,
                "KWD" => SMBUpdateAgentInfoRequestCurrency.Kwd,
                "MXN" => SMBUpdateAgentInfoRequestCurrency.Mxn,
                "MYR" => SMBUpdateAgentInfoRequestCurrency.Myr,
                "NGN" => SMBUpdateAgentInfoRequestCurrency.Ngn,
                "NOK" => SMBUpdateAgentInfoRequestCurrency.Nok,
                "NZD" => SMBUpdateAgentInfoRequestCurrency.Nzd,
                "PEN" => SMBUpdateAgentInfoRequestCurrency.Pen,
                "PHP" => SMBUpdateAgentInfoRequestCurrency.Php,
                "PKR" => SMBUpdateAgentInfoRequestCurrency.Pkr,
                "PLN" => SMBUpdateAgentInfoRequestCurrency.Pln,
                "QAR" => SMBUpdateAgentInfoRequestCurrency.Qar,
                "RON" => SMBUpdateAgentInfoRequestCurrency.Ron,
                "RUB" => SMBUpdateAgentInfoRequestCurrency.Rub,
                "SAR" => SMBUpdateAgentInfoRequestCurrency.Sar,
                "SEK" => SMBUpdateAgentInfoRequestCurrency.Sek,
                "SGD" => SMBUpdateAgentInfoRequestCurrency.Sgd,
                "THB" => SMBUpdateAgentInfoRequestCurrency.Thb,
                "TRY" => SMBUpdateAgentInfoRequestCurrency.Try,
                "TWD" => SMBUpdateAgentInfoRequestCurrency.Twd,
                "UAH" => SMBUpdateAgentInfoRequestCurrency.Uah,
                "USD" => SMBUpdateAgentInfoRequestCurrency.Usd,
                "VND" => SMBUpdateAgentInfoRequestCurrency.Vnd,
                "ZAR" => SMBUpdateAgentInfoRequestCurrency.Zar,
                _ => null,
            };
        }
    }
}