
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Currency code for all prices (ISO 4217)<br/>
    /// Default Value: USD
    /// </summary>
    public enum ReceptionUpdateAgentInfoRequestCurrency
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
    public static class ReceptionUpdateAgentInfoRequestCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionUpdateAgentInfoRequestCurrency value)
        {
            return value switch
            {
                ReceptionUpdateAgentInfoRequestCurrency.Aed => "AED",
                ReceptionUpdateAgentInfoRequestCurrency.Ars => "ARS",
                ReceptionUpdateAgentInfoRequestCurrency.Aud => "AUD",
                ReceptionUpdateAgentInfoRequestCurrency.Bdt => "BDT",
                ReceptionUpdateAgentInfoRequestCurrency.Bgn => "BGN",
                ReceptionUpdateAgentInfoRequestCurrency.Brl => "BRL",
                ReceptionUpdateAgentInfoRequestCurrency.Cad => "CAD",
                ReceptionUpdateAgentInfoRequestCurrency.Chf => "CHF",
                ReceptionUpdateAgentInfoRequestCurrency.Clp => "CLP",
                ReceptionUpdateAgentInfoRequestCurrency.Cny => "CNY",
                ReceptionUpdateAgentInfoRequestCurrency.Cop => "COP",
                ReceptionUpdateAgentInfoRequestCurrency.Czk => "CZK",
                ReceptionUpdateAgentInfoRequestCurrency.Dkk => "DKK",
                ReceptionUpdateAgentInfoRequestCurrency.Egp => "EGP",
                ReceptionUpdateAgentInfoRequestCurrency.Eur => "EUR",
                ReceptionUpdateAgentInfoRequestCurrency.Gbp => "GBP",
                ReceptionUpdateAgentInfoRequestCurrency.Hkd => "HKD",
                ReceptionUpdateAgentInfoRequestCurrency.Huf => "HUF",
                ReceptionUpdateAgentInfoRequestCurrency.Idr => "IDR",
                ReceptionUpdateAgentInfoRequestCurrency.Ils => "ILS",
                ReceptionUpdateAgentInfoRequestCurrency.Inr => "INR",
                ReceptionUpdateAgentInfoRequestCurrency.Isk => "ISK",
                ReceptionUpdateAgentInfoRequestCurrency.Jpy => "JPY",
                ReceptionUpdateAgentInfoRequestCurrency.Kes => "KES",
                ReceptionUpdateAgentInfoRequestCurrency.Krw => "KRW",
                ReceptionUpdateAgentInfoRequestCurrency.Kwd => "KWD",
                ReceptionUpdateAgentInfoRequestCurrency.Mxn => "MXN",
                ReceptionUpdateAgentInfoRequestCurrency.Myr => "MYR",
                ReceptionUpdateAgentInfoRequestCurrency.Ngn => "NGN",
                ReceptionUpdateAgentInfoRequestCurrency.Nok => "NOK",
                ReceptionUpdateAgentInfoRequestCurrency.Nzd => "NZD",
                ReceptionUpdateAgentInfoRequestCurrency.Pen => "PEN",
                ReceptionUpdateAgentInfoRequestCurrency.Php => "PHP",
                ReceptionUpdateAgentInfoRequestCurrency.Pkr => "PKR",
                ReceptionUpdateAgentInfoRequestCurrency.Pln => "PLN",
                ReceptionUpdateAgentInfoRequestCurrency.Qar => "QAR",
                ReceptionUpdateAgentInfoRequestCurrency.Ron => "RON",
                ReceptionUpdateAgentInfoRequestCurrency.Rub => "RUB",
                ReceptionUpdateAgentInfoRequestCurrency.Sar => "SAR",
                ReceptionUpdateAgentInfoRequestCurrency.Sek => "SEK",
                ReceptionUpdateAgentInfoRequestCurrency.Sgd => "SGD",
                ReceptionUpdateAgentInfoRequestCurrency.Thb => "THB",
                ReceptionUpdateAgentInfoRequestCurrency.Try => "TRY",
                ReceptionUpdateAgentInfoRequestCurrency.Twd => "TWD",
                ReceptionUpdateAgentInfoRequestCurrency.Uah => "UAH",
                ReceptionUpdateAgentInfoRequestCurrency.Usd => "USD",
                ReceptionUpdateAgentInfoRequestCurrency.Vnd => "VND",
                ReceptionUpdateAgentInfoRequestCurrency.Zar => "ZAR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionUpdateAgentInfoRequestCurrency? ToEnum(string value)
        {
            return value switch
            {
                "AED" => ReceptionUpdateAgentInfoRequestCurrency.Aed,
                "ARS" => ReceptionUpdateAgentInfoRequestCurrency.Ars,
                "AUD" => ReceptionUpdateAgentInfoRequestCurrency.Aud,
                "BDT" => ReceptionUpdateAgentInfoRequestCurrency.Bdt,
                "BGN" => ReceptionUpdateAgentInfoRequestCurrency.Bgn,
                "BRL" => ReceptionUpdateAgentInfoRequestCurrency.Brl,
                "CAD" => ReceptionUpdateAgentInfoRequestCurrency.Cad,
                "CHF" => ReceptionUpdateAgentInfoRequestCurrency.Chf,
                "CLP" => ReceptionUpdateAgentInfoRequestCurrency.Clp,
                "CNY" => ReceptionUpdateAgentInfoRequestCurrency.Cny,
                "COP" => ReceptionUpdateAgentInfoRequestCurrency.Cop,
                "CZK" => ReceptionUpdateAgentInfoRequestCurrency.Czk,
                "DKK" => ReceptionUpdateAgentInfoRequestCurrency.Dkk,
                "EGP" => ReceptionUpdateAgentInfoRequestCurrency.Egp,
                "EUR" => ReceptionUpdateAgentInfoRequestCurrency.Eur,
                "GBP" => ReceptionUpdateAgentInfoRequestCurrency.Gbp,
                "HKD" => ReceptionUpdateAgentInfoRequestCurrency.Hkd,
                "HUF" => ReceptionUpdateAgentInfoRequestCurrency.Huf,
                "IDR" => ReceptionUpdateAgentInfoRequestCurrency.Idr,
                "ILS" => ReceptionUpdateAgentInfoRequestCurrency.Ils,
                "INR" => ReceptionUpdateAgentInfoRequestCurrency.Inr,
                "ISK" => ReceptionUpdateAgentInfoRequestCurrency.Isk,
                "JPY" => ReceptionUpdateAgentInfoRequestCurrency.Jpy,
                "KES" => ReceptionUpdateAgentInfoRequestCurrency.Kes,
                "KRW" => ReceptionUpdateAgentInfoRequestCurrency.Krw,
                "KWD" => ReceptionUpdateAgentInfoRequestCurrency.Kwd,
                "MXN" => ReceptionUpdateAgentInfoRequestCurrency.Mxn,
                "MYR" => ReceptionUpdateAgentInfoRequestCurrency.Myr,
                "NGN" => ReceptionUpdateAgentInfoRequestCurrency.Ngn,
                "NOK" => ReceptionUpdateAgentInfoRequestCurrency.Nok,
                "NZD" => ReceptionUpdateAgentInfoRequestCurrency.Nzd,
                "PEN" => ReceptionUpdateAgentInfoRequestCurrency.Pen,
                "PHP" => ReceptionUpdateAgentInfoRequestCurrency.Php,
                "PKR" => ReceptionUpdateAgentInfoRequestCurrency.Pkr,
                "PLN" => ReceptionUpdateAgentInfoRequestCurrency.Pln,
                "QAR" => ReceptionUpdateAgentInfoRequestCurrency.Qar,
                "RON" => ReceptionUpdateAgentInfoRequestCurrency.Ron,
                "RUB" => ReceptionUpdateAgentInfoRequestCurrency.Rub,
                "SAR" => ReceptionUpdateAgentInfoRequestCurrency.Sar,
                "SEK" => ReceptionUpdateAgentInfoRequestCurrency.Sek,
                "SGD" => ReceptionUpdateAgentInfoRequestCurrency.Sgd,
                "THB" => ReceptionUpdateAgentInfoRequestCurrency.Thb,
                "TRY" => ReceptionUpdateAgentInfoRequestCurrency.Try,
                "TWD" => ReceptionUpdateAgentInfoRequestCurrency.Twd,
                "UAH" => ReceptionUpdateAgentInfoRequestCurrency.Uah,
                "USD" => ReceptionUpdateAgentInfoRequestCurrency.Usd,
                "VND" => ReceptionUpdateAgentInfoRequestCurrency.Vnd,
                "ZAR" => ReceptionUpdateAgentInfoRequestCurrency.Zar,
                _ => null,
            };
        }
    }
}