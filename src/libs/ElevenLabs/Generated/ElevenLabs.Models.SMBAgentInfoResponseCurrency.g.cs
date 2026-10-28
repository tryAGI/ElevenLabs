
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Currency code for all prices (ISO 4217)<br/>
    /// Default Value: USD
    /// </summary>
    public enum SMBAgentInfoResponseCurrency
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
    public static class SMBAgentInfoResponseCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBAgentInfoResponseCurrency value)
        {
            return value switch
            {
                SMBAgentInfoResponseCurrency.Aed => "AED",
                SMBAgentInfoResponseCurrency.Ars => "ARS",
                SMBAgentInfoResponseCurrency.Aud => "AUD",
                SMBAgentInfoResponseCurrency.Bdt => "BDT",
                SMBAgentInfoResponseCurrency.Bgn => "BGN",
                SMBAgentInfoResponseCurrency.Brl => "BRL",
                SMBAgentInfoResponseCurrency.Cad => "CAD",
                SMBAgentInfoResponseCurrency.Chf => "CHF",
                SMBAgentInfoResponseCurrency.Clp => "CLP",
                SMBAgentInfoResponseCurrency.Cny => "CNY",
                SMBAgentInfoResponseCurrency.Cop => "COP",
                SMBAgentInfoResponseCurrency.Czk => "CZK",
                SMBAgentInfoResponseCurrency.Dkk => "DKK",
                SMBAgentInfoResponseCurrency.Egp => "EGP",
                SMBAgentInfoResponseCurrency.Eur => "EUR",
                SMBAgentInfoResponseCurrency.Gbp => "GBP",
                SMBAgentInfoResponseCurrency.Hkd => "HKD",
                SMBAgentInfoResponseCurrency.Huf => "HUF",
                SMBAgentInfoResponseCurrency.Idr => "IDR",
                SMBAgentInfoResponseCurrency.Ils => "ILS",
                SMBAgentInfoResponseCurrency.Inr => "INR",
                SMBAgentInfoResponseCurrency.Isk => "ISK",
                SMBAgentInfoResponseCurrency.Jpy => "JPY",
                SMBAgentInfoResponseCurrency.Kes => "KES",
                SMBAgentInfoResponseCurrency.Krw => "KRW",
                SMBAgentInfoResponseCurrency.Kwd => "KWD",
                SMBAgentInfoResponseCurrency.Mxn => "MXN",
                SMBAgentInfoResponseCurrency.Myr => "MYR",
                SMBAgentInfoResponseCurrency.Ngn => "NGN",
                SMBAgentInfoResponseCurrency.Nok => "NOK",
                SMBAgentInfoResponseCurrency.Nzd => "NZD",
                SMBAgentInfoResponseCurrency.Pen => "PEN",
                SMBAgentInfoResponseCurrency.Php => "PHP",
                SMBAgentInfoResponseCurrency.Pkr => "PKR",
                SMBAgentInfoResponseCurrency.Pln => "PLN",
                SMBAgentInfoResponseCurrency.Qar => "QAR",
                SMBAgentInfoResponseCurrency.Ron => "RON",
                SMBAgentInfoResponseCurrency.Rub => "RUB",
                SMBAgentInfoResponseCurrency.Sar => "SAR",
                SMBAgentInfoResponseCurrency.Sek => "SEK",
                SMBAgentInfoResponseCurrency.Sgd => "SGD",
                SMBAgentInfoResponseCurrency.Thb => "THB",
                SMBAgentInfoResponseCurrency.Try => "TRY",
                SMBAgentInfoResponseCurrency.Twd => "TWD",
                SMBAgentInfoResponseCurrency.Uah => "UAH",
                SMBAgentInfoResponseCurrency.Usd => "USD",
                SMBAgentInfoResponseCurrency.Vnd => "VND",
                SMBAgentInfoResponseCurrency.Zar => "ZAR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBAgentInfoResponseCurrency? ToEnum(string value)
        {
            return value switch
            {
                "AED" => SMBAgentInfoResponseCurrency.Aed,
                "ARS" => SMBAgentInfoResponseCurrency.Ars,
                "AUD" => SMBAgentInfoResponseCurrency.Aud,
                "BDT" => SMBAgentInfoResponseCurrency.Bdt,
                "BGN" => SMBAgentInfoResponseCurrency.Bgn,
                "BRL" => SMBAgentInfoResponseCurrency.Brl,
                "CAD" => SMBAgentInfoResponseCurrency.Cad,
                "CHF" => SMBAgentInfoResponseCurrency.Chf,
                "CLP" => SMBAgentInfoResponseCurrency.Clp,
                "CNY" => SMBAgentInfoResponseCurrency.Cny,
                "COP" => SMBAgentInfoResponseCurrency.Cop,
                "CZK" => SMBAgentInfoResponseCurrency.Czk,
                "DKK" => SMBAgentInfoResponseCurrency.Dkk,
                "EGP" => SMBAgentInfoResponseCurrency.Egp,
                "EUR" => SMBAgentInfoResponseCurrency.Eur,
                "GBP" => SMBAgentInfoResponseCurrency.Gbp,
                "HKD" => SMBAgentInfoResponseCurrency.Hkd,
                "HUF" => SMBAgentInfoResponseCurrency.Huf,
                "IDR" => SMBAgentInfoResponseCurrency.Idr,
                "ILS" => SMBAgentInfoResponseCurrency.Ils,
                "INR" => SMBAgentInfoResponseCurrency.Inr,
                "ISK" => SMBAgentInfoResponseCurrency.Isk,
                "JPY" => SMBAgentInfoResponseCurrency.Jpy,
                "KES" => SMBAgentInfoResponseCurrency.Kes,
                "KRW" => SMBAgentInfoResponseCurrency.Krw,
                "KWD" => SMBAgentInfoResponseCurrency.Kwd,
                "MXN" => SMBAgentInfoResponseCurrency.Mxn,
                "MYR" => SMBAgentInfoResponseCurrency.Myr,
                "NGN" => SMBAgentInfoResponseCurrency.Ngn,
                "NOK" => SMBAgentInfoResponseCurrency.Nok,
                "NZD" => SMBAgentInfoResponseCurrency.Nzd,
                "PEN" => SMBAgentInfoResponseCurrency.Pen,
                "PHP" => SMBAgentInfoResponseCurrency.Php,
                "PKR" => SMBAgentInfoResponseCurrency.Pkr,
                "PLN" => SMBAgentInfoResponseCurrency.Pln,
                "QAR" => SMBAgentInfoResponseCurrency.Qar,
                "RON" => SMBAgentInfoResponseCurrency.Ron,
                "RUB" => SMBAgentInfoResponseCurrency.Rub,
                "SAR" => SMBAgentInfoResponseCurrency.Sar,
                "SEK" => SMBAgentInfoResponseCurrency.Sek,
                "SGD" => SMBAgentInfoResponseCurrency.Sgd,
                "THB" => SMBAgentInfoResponseCurrency.Thb,
                "TRY" => SMBAgentInfoResponseCurrency.Try,
                "TWD" => SMBAgentInfoResponseCurrency.Twd,
                "UAH" => SMBAgentInfoResponseCurrency.Uah,
                "USD" => SMBAgentInfoResponseCurrency.Usd,
                "VND" => SMBAgentInfoResponseCurrency.Vnd,
                "ZAR" => SMBAgentInfoResponseCurrency.Zar,
                _ => null,
            };
        }
    }
}