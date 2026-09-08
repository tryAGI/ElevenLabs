
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How to run Twilio's carrier-level answering machine detection (AMD) on a call.
    /// </summary>
    public sealed partial class TwilioMachineDetectionConfig
    {
        /// <summary>
        /// How thorough the detection should be. `enable` returns a verdict as soon as Twilio can tell a human from a machine. `detect_message_end` also waits for the voicemail greeting to finish, which is what produces the `machine_end_*` verdicts, but returns a result later.<br/>
        /// Default Value: enable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TwilioMachineDetectionModeJsonConverter))]
        public global::ElevenLabs.TwilioMachineDetectionMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioMachineDetectionConfig" /> class.
        /// </summary>
        /// <param name="mode">
        /// How thorough the detection should be. `enable` returns a verdict as soon as Twilio can tell a human from a machine. `detect_message_end` also waits for the voicemail greeting to finish, which is what produces the `machine_end_*` verdicts, but returns a result later.<br/>
        /// Default Value: enable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TwilioMachineDetectionConfig(
            global::ElevenLabs.TwilioMachineDetectionMode? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioMachineDetectionConfig" /> class.
        /// </summary>
        public TwilioMachineDetectionConfig()
        {
        }

    }
}