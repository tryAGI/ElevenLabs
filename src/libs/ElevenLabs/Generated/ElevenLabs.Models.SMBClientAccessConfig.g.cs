
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SMBClientAccessConfig
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_secure_mode")]
        public bool? EnableSecureMode { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_verification_enabled")]
        public bool? IdentityVerificationEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_verification_email_enabled")]
        public bool? IdentityVerificationEmailEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_verification_sms_enabled")]
        public bool? IdentityVerificationSmsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBClientAccessConfig" /> class.
        /// </summary>
        /// <param name="enableSecureMode">
        /// Default Value: false
        /// </param>
        /// <param name="identityVerificationEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="identityVerificationEmailEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="identityVerificationSmsEnabled">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBClientAccessConfig(
            bool? enableSecureMode,
            bool? identityVerificationEnabled,
            bool? identityVerificationEmailEnabled,
            bool? identityVerificationSmsEnabled)
        {
            this.EnableSecureMode = enableSecureMode;
            this.IdentityVerificationEnabled = identityVerificationEnabled;
            this.IdentityVerificationEmailEnabled = identityVerificationEmailEnabled;
            this.IdentityVerificationSmsEnabled = identityVerificationSmsEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBClientAccessConfig" /> class.
        /// </summary>
        public SMBClientAccessConfig()
        {
        }

    }
}