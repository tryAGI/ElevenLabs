
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Per-agent (receptionist) configuration for client identity verification codes.
    /// </summary>
    public sealed partial class SMBIdentityVerificationConfig
    {
        /// <summary>
        /// When enabled, the receptionist may only look up or modify a client's appointments and records after that client has completed OTP identity verification in this conversation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBNotificationChannel>? Channels { get; set; }

        /// <summary>
        /// Twilio phone number ID used to send SMS verification codes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_phone_number_id")]
        public string? SmsPhoneNumberId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBIdentityVerificationConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// When enabled, the receptionist may only look up or modify a client's appointments and records after that client has completed OTP identity verification in this conversation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="channels"></param>
        /// <param name="smsPhoneNumberId">
        /// Twilio phone number ID used to send SMS verification codes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBIdentityVerificationConfig(
            bool? enabled,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBNotificationChannel>? channels,
            string? smsPhoneNumberId)
        {
            this.Enabled = enabled;
            this.Channels = channels;
            this.SmsPhoneNumberId = smsPhoneNumberId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBIdentityVerificationConfig" /> class.
        /// </summary>
        public SMBIdentityVerificationConfig()
        {
        }

    }
}