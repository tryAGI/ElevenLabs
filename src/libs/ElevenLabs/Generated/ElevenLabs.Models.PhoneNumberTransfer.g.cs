
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberTransfer
    {
        /// <summary>
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_sip_headers")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem>? CustomSipHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestinationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TransferDestination TransferDestination { get; set; }

        /// <summary>
        /// Default Value: conference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferTypeEnumJsonConverter))]
        public global::ElevenLabs.TransferTypeEnum? TransferType { get; set; }

        /// <summary>
        /// User-to-User Information (RFC 7433) to attach to SIP REFER transfers. Carries call context such as CRM identifiers or escalation reason across the transfer boundary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uui")]
        public global::ElevenLabs.UUITransferConfig? Uui { get; set; }

        /// <summary>
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension). Can be either a static value or a dynamic variable reference. Use 'w' for 0.5s pause. Only supported for Twilio transfers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_dial_digits")]
        public global::ElevenLabs.PostDialDigitsVariant1? PostDialDigits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberTransfer" /> class.
        /// </summary>
        /// <param name="transferDestination"></param>
        /// <param name="condition"></param>
        /// <param name="customSipHeaders">
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </param>
        /// <param name="transferType">
        /// Default Value: conference
        /// </param>
        /// <param name="uui">
        /// User-to-User Information (RFC 7433) to attach to SIP REFER transfers. Carries call context such as CRM identifiers or escalation reason across the transfer boundary.
        /// </param>
        /// <param name="postDialDigits">
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension). Can be either a static value or a dynamic variable reference. Use 'w' for 0.5s pause. Only supported for Twilio transfers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberTransfer(
            global::ElevenLabs.TransferDestination transferDestination,
            string condition,
            global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem>? customSipHeaders,
            global::ElevenLabs.TransferTypeEnum? transferType,
            global::ElevenLabs.UUITransferConfig? uui,
            global::ElevenLabs.PostDialDigitsVariant1? postDialDigits)
        {
            this.CustomSipHeaders = customSipHeaders;
            this.TransferDestination = transferDestination;
            this.TransferType = transferType;
            this.Uui = uui;
            this.PostDialDigits = postDialDigits;
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberTransfer" /> class.
        /// </summary>
        public PhoneNumberTransfer()
        {
        }

    }
}