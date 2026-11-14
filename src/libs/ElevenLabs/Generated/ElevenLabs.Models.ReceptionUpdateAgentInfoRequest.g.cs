
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Fields to change on the business profile.
    /// </summary>
    public sealed partial class ReceptionUpdateAgentInfoRequest
    {
        /// <summary>
        /// Name of the business.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_name")]
        public string? BusinessName { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code where the business is based (e.g. 'US', 'PL', 'DE').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_country")]
        public string? BusinessCountry { get; set; }

        /// <summary>
        /// What the business does, given to the receptionist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_description")]
        public string? BusinessDescription { get; set; }

        /// <summary>
        /// IANA timezone of the business.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Currency code for all prices (ISO 4217)<br/>
        /// Default Value: USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ReceptionUpdateAgentInfoRequestCurrencyJsonConverter))]
        public global::ElevenLabs.ReceptionUpdateAgentInfoRequestCurrency? Currency { get; set; }

        /// <summary>
        /// Default business hours. Each location's own operating_hours decide when that location is open.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operating_hours")]
        public global::ElevenLabs.WorkingHours? OperatingHours { get; set; }

        /// <summary>
        /// Ambient sound played while any receptionist runs a tool (e.g. checking availability or looking up a client), filling the silence callers would otherwise hear. One sound for the whole workspace, because custom webhook and MCP tools are shared by every receptionist. Off when null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound")]
        public global::ElevenLabs.ToolCallSoundType? ToolCallSound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionUpdateAgentInfoRequest" /> class.
        /// </summary>
        /// <param name="businessName">
        /// Name of the business.
        /// </param>
        /// <param name="businessCountry">
        /// ISO 3166-1 alpha-2 country code where the business is based (e.g. 'US', 'PL', 'DE').
        /// </param>
        /// <param name="businessDescription">
        /// What the business does, given to the receptionist.
        /// </param>
        /// <param name="timezone">
        /// IANA timezone of the business.
        /// </param>
        /// <param name="currency">
        /// Currency code for all prices (ISO 4217)<br/>
        /// Default Value: USD
        /// </param>
        /// <param name="operatingHours">
        /// Default business hours. Each location's own operating_hours decide when that location is open.
        /// </param>
        /// <param name="toolCallSound">
        /// Ambient sound played while any receptionist runs a tool (e.g. checking availability or looking up a client), filling the silence callers would otherwise hear. One sound for the whole workspace, because custom webhook and MCP tools are shared by every receptionist. Off when null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionUpdateAgentInfoRequest(
            string? businessName,
            string? businessCountry,
            string? businessDescription,
            string? timezone,
            global::ElevenLabs.ReceptionUpdateAgentInfoRequestCurrency? currency,
            global::ElevenLabs.WorkingHours? operatingHours,
            global::ElevenLabs.ToolCallSoundType? toolCallSound)
        {
            this.BusinessName = businessName;
            this.BusinessCountry = businessCountry;
            this.BusinessDescription = businessDescription;
            this.Timezone = timezone;
            this.Currency = currency;
            this.OperatingHours = operatingHours;
            this.ToolCallSound = toolCallSound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionUpdateAgentInfoRequest" /> class.
        /// </summary>
        public ReceptionUpdateAgentInfoRequest()
        {
        }

    }
}