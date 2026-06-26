
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"account_sid":"your-account-sid","api_key":"your-api-key","api_subdomain":"api.in.exotel.com","api_token":"********","app_id":"12345","label":"Exotel Outbound","phone_number":"\u002B919999999999","provider":"exotel"}
    /// </summary>
    public sealed partial class CreateExotelPhoneNumberRequest
    {
        /// <summary>
        /// Phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Label for the phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed in the future. Whether this phone number supports inbound calls<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_inbound")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SupportsInbound { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed in the future. Whether this phone number supports outbound calls<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_outbound")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SupportsOutbound { get; set; }

        /// <summary>
        /// Default Value: exotel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Agent ID to assign the phone number to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Exotel Account SID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_sid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountSid { get; set; }

        /// <summary>
        /// Exotel API Key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Exotel API Token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiToken { get; set; }

        /// <summary>
        /// Exotel region-specific API host
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_subdomain")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ExotelApiSubdomainJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ExotelApiSubdomain ApiSubdomain { get; set; }

        /// <summary>
        /// Exotel applet identifier used in Calls/connect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppId { get; set; }

        /// <summary>
        /// Optional full applet URL override. Defaults to Exotel start_voice URL derived from account SID and app ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applet_url")]
        public string? AppletUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExotelPhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number
        /// </param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="accountSid">
        /// Exotel Account SID
        /// </param>
        /// <param name="apiKey">
        /// Exotel API Key
        /// </param>
        /// <param name="apiToken">
        /// Exotel API Token
        /// </param>
        /// <param name="apiSubdomain">
        /// Exotel region-specific API host
        /// </param>
        /// <param name="appId">
        /// Exotel applet identifier used in Calls/connect
        /// </param>
        /// <param name="provider">
        /// Default Value: exotel
        /// </param>
        /// <param name="agentId">
        /// Agent ID to assign the phone number to
        /// </param>
        /// <param name="appletUrl">
        /// Optional full applet URL override. Defaults to Exotel start_voice URL derived from account SID and app ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExotelPhoneNumberRequest(
            string phoneNumber,
            string label,
            string accountSid,
            string apiKey,
            string apiToken,
            global::ElevenLabs.ExotelApiSubdomain apiSubdomain,
            string appId,
            string? provider,
            string? agentId,
            string? appletUrl)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Provider = provider;
            this.AgentId = agentId;
            this.AccountSid = accountSid ?? throw new global::System.ArgumentNullException(nameof(accountSid));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.ApiToken = apiToken ?? throw new global::System.ArgumentNullException(nameof(apiToken));
            this.ApiSubdomain = apiSubdomain;
            this.AppId = appId ?? throw new global::System.ArgumentNullException(nameof(appId));
            this.AppletUrl = appletUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExotelPhoneNumberRequest" /> class.
        /// </summary>
        public CreateExotelPhoneNumberRequest()
        {
        }

    }
}