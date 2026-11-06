
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A phone number held by the workspace.
    /// </summary>
    public sealed partial class SMBPhoneAssignmentDBModel
    {
        /// <summary>
        /// Phone number in E.164 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// True when the phone is bring-your-own: registered by the workspace using their own telephony provider (Twilio credentials or SIP trunk). BYO phones are never part of the shared pool, do not count against the plan's phone number limit, and are deleted (rather than returned to the pool) on release.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byo")]
        public bool? IsByo { get; set; }

        /// <summary>
        /// Telephony provider for this phone number.<br/>
        /// Default Value: twilio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SMBPhoneProviderJsonConverter))]
        public global::ElevenLabs.SMBPhoneProvider? Provider { get; set; }

        /// <summary>
        /// US/Canada NANP area code (NPA) as an integer.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nanp_area_code")]
        public int? NanpAreaCode { get; set; }

        /// <summary>
        /// The receptionist that answers this number. Null when the workspace holds the number but no receptionist answers it yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_facing_agent_id")]
        public string? CustomerFacingAgentId { get; set; }

        /// <summary>
        /// Unix timestamp when this number was deactivated; it is released 14 days later. Null when active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivated_at_unix")]
        public int? DeactivatedAtUnix { get; set; }

        /// <summary>
        /// Why this number was deactivated. Null when active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivation_reason")]
        public global::ElevenLabs.SMBPhoneAssignmentDeactivationReason? DeactivationReason { get; set; }

        /// <summary>
        /// Null for numbers that need no paperwork. `held` while the workspace's own application is under review, `approved` once it passed and the number is fully usable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regulatory_status")]
        public global::ElevenLabs.SMBPhoneRegulatoryStatus? RegulatoryStatus { get; set; }

        /// <summary>
        /// The regulated number type this number was issued as. Null for numbers that need no paperwork.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regulatory_number_type")]
        public global::ElevenLabs.ApplicationNumberType? RegulatoryNumberType { get; set; }

        /// <summary>
        /// ISO country the regulated number was issued in. Null for numbers that need no paperwork.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regulatory_country")]
        public string? RegulatoryCountry { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unix timestamp (seconds since epoch)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedAtUnix { get; set; }

        /// <summary>
        /// Unix timestamp (seconds since epoch)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? UpdatedAtUnix { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool IsActive { get; set; } = default!;

        /// <summary>
        /// Whether inbound calls from the public may reach the receptionist.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepts_public_calls")]
        public bool AcceptsPublicCalls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBPhoneAssignmentDBModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="phoneNumber">
        /// Phone number in E.164 format.
        /// </param>
        /// <param name="isByo">
        /// True when the phone is bring-your-own: registered by the workspace using their own telephony provider (Twilio credentials or SIP trunk). BYO phones are never part of the shared pool, do not count against the plan's phone number limit, and are deleted (rather than returned to the pool) on release.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="provider">
        /// Telephony provider for this phone number.<br/>
        /// Default Value: twilio
        /// </param>
        /// <param name="nanpAreaCode">
        /// US/Canada NANP area code (NPA) as an integer.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="customerFacingAgentId">
        /// The receptionist that answers this number. Null when the workspace holds the number but no receptionist answers it yet.
        /// </param>
        /// <param name="deactivatedAtUnix">
        /// Unix timestamp when this number was deactivated; it is released 14 days later. Null when active.
        /// </param>
        /// <param name="deactivationReason">
        /// Why this number was deactivated. Null when active.
        /// </param>
        /// <param name="regulatoryStatus">
        /// Null for numbers that need no paperwork. `held` while the workspace's own application is under review, `approved` once it passed and the number is fully usable.
        /// </param>
        /// <param name="regulatoryNumberType">
        /// The regulated number type this number was issued as. Null for numbers that need no paperwork.
        /// </param>
        /// <param name="regulatoryCountry">
        /// ISO country the regulated number was issued in. Null for numbers that need no paperwork.
        /// </param>
        /// <param name="createdAtUnix">
        /// Unix timestamp (seconds since epoch)
        /// </param>
        /// <param name="updatedAtUnix">
        /// Unix timestamp (seconds since epoch)
        /// </param>
        /// <param name="isActive">
        /// Included only in responses
        /// </param>
        /// <param name="acceptsPublicCalls">
        /// Whether inbound calls from the public may reach the receptionist.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBPhoneAssignmentDBModel(
            string id,
            string? phoneNumber,
            bool? isByo,
            global::ElevenLabs.SMBPhoneProvider? provider,
            int? nanpAreaCode,
            string? customerFacingAgentId,
            int? deactivatedAtUnix,
            global::ElevenLabs.SMBPhoneAssignmentDeactivationReason? deactivationReason,
            global::ElevenLabs.SMBPhoneRegulatoryStatus? regulatoryStatus,
            global::ElevenLabs.ApplicationNumberType? regulatoryNumberType,
            string? regulatoryCountry,
            global::System.DateTimeOffset? createdAtUnix,
            global::System.DateTimeOffset? updatedAtUnix,
            bool isActive = default!,
            bool acceptsPublicCalls = default!)
        {
            this.PhoneNumber = phoneNumber;
            this.IsByo = isByo;
            this.Provider = provider;
            this.NanpAreaCode = nanpAreaCode;
            this.CustomerFacingAgentId = customerFacingAgentId;
            this.DeactivatedAtUnix = deactivatedAtUnix;
            this.DeactivationReason = deactivationReason;
            this.RegulatoryStatus = regulatoryStatus;
            this.RegulatoryNumberType = regulatoryNumberType;
            this.RegulatoryCountry = regulatoryCountry;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAtUnix = createdAtUnix;
            this.UpdatedAtUnix = updatedAtUnix;
            this.IsActive = isActive;
            this.AcceptsPublicCalls = acceptsPublicCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBPhoneAssignmentDBModel" /> class.
        /// </summary>
        public SMBPhoneAssignmentDBModel()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SMBPhoneAssignmentDBModel"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SMBPhoneAssignmentDBModel FromId(string id)
        {
            return new SMBPhoneAssignmentDBModel
            {
                Id = id,
            };
        }

    }
}