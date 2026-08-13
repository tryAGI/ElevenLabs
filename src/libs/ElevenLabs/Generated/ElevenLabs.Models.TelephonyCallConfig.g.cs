
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelephonyCallConfig
    {
        /// <summary>
        /// How long to ring the recipient before giving up, in seconds. Note that this will also be limited by the provider's own constraints.<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ringing_timeout_secs")]
        public int? RingingTimeoutSecs { get; set; }

        /// <summary>
        /// Whether to record the call using Twilio call recording. Ignored for non-Twilio providers. Recordings are stored in your Twilio account.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilio_call_recording_enabled")]
        public bool? TwilioCallRecordingEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyCallConfig" /> class.
        /// </summary>
        /// <param name="ringingTimeoutSecs">
        /// How long to ring the recipient before giving up, in seconds. Note that this will also be limited by the provider's own constraints.<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="twilioCallRecordingEnabled">
        /// Whether to record the call using Twilio call recording. Ignored for non-Twilio providers. Recordings are stored in your Twilio account.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelephonyCallConfig(
            int? ringingTimeoutSecs,
            bool? twilioCallRecordingEnabled)
        {
            this.RingingTimeoutSecs = ringingTimeoutSecs;
            this.TwilioCallRecordingEnabled = twilioCallRecordingEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyCallConfig" /> class.
        /// </summary>
        public TelephonyCallConfig()
        {
        }

    }
}