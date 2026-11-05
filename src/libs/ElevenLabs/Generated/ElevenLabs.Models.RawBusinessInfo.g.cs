
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Business profile data extracted from a single page.
    /// </summary>
    public sealed partial class RawBusinessInfo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_phone")]
        public string? BusinessPhone { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locations")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.RawLocationInfo>? Locations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_country")]
        public string? BusinessCountry { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_state")]
        public string? BusinessState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggested_currency")]
        public string? SuggestedCurrency { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggested_language")]
        public string? SuggestedLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RawBusinessInfo" /> class.
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="description"></param>
        /// <param name="businessPhone"></param>
        /// <param name="locations"></param>
        /// <param name="businessCountry"></param>
        /// <param name="businessState"></param>
        /// <param name="suggestedCurrency"></param>
        /// <param name="suggestedLanguage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RawBusinessInfo(
            string? companyName,
            string? description,
            string? businessPhone,
            global::System.Collections.Generic.IList<global::ElevenLabs.RawLocationInfo>? locations,
            string? businessCountry,
            string? businessState,
            string? suggestedCurrency,
            string? suggestedLanguage)
        {
            this.CompanyName = companyName;
            this.Description = description;
            this.BusinessPhone = businessPhone;
            this.Locations = locations;
            this.BusinessCountry = businessCountry;
            this.BusinessState = businessState;
            this.SuggestedCurrency = suggestedCurrency;
            this.SuggestedLanguage = suggestedLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawBusinessInfo" /> class.
        /// </summary>
        public RawBusinessInfo()
        {
        }

    }
}