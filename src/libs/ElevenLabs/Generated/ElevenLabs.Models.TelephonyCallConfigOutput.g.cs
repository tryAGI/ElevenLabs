
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TelephonyCallConfigOutput
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
        /// Configuration for Twilio's carrier-level answering machine detection (AMD). Omit or set to null to disable it. Ignored for non-Twilio providers and for inbound calls. The resulting verdict is delivered as its own `answering_machine_detection` webhook event, which requires that event to be enabled on the workspace or agent webhook settings; it is not part of the conversation or the post-call webhook. Detection runs asynchronously so it never delays the start of the conversation, and the verdict can arrive at any point during the call -- with `detect_message_end`, even after it has ended. Twilio bills separately for AMD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilio_machine_detection")]
        public global::ElevenLabs.TwilioMachineDetectionConfig? TwilioMachineDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyCallConfigOutput" /> class.
        /// </summary>
        /// <param name="ringingTimeoutSecs">
        /// How long to ring the recipient before giving up, in seconds. Note that this will also be limited by the provider's own constraints.<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="twilioCallRecordingEnabled">
        /// Whether to record the call using Twilio call recording. Ignored for non-Twilio providers. Recordings are stored in your Twilio account.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="twilioMachineDetection">
        /// Configuration for Twilio's carrier-level answering machine detection (AMD). Omit or set to null to disable it. Ignored for non-Twilio providers and for inbound calls. The resulting verdict is delivered as its own `answering_machine_detection` webhook event, which requires that event to be enabled on the workspace or agent webhook settings; it is not part of the conversation or the post-call webhook. Detection runs asynchronously so it never delays the start of the conversation, and the verdict can arrive at any point during the call -- with `detect_message_end`, even after it has ended. Twilio bills separately for AMD.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelephonyCallConfigOutput(
            int? ringingTimeoutSecs,
            bool? twilioCallRecordingEnabled,
            global::ElevenLabs.TwilioMachineDetectionConfig? twilioMachineDetection)
        {
            this.RingingTimeoutSecs = ringingTimeoutSecs;
            this.TwilioCallRecordingEnabled = twilioCallRecordingEnabled;
            this.TwilioMachineDetection = twilioMachineDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyCallConfigOutput" /> class.
        /// </summary>
        public TelephonyCallConfigOutput()
        {
        }

    }
}