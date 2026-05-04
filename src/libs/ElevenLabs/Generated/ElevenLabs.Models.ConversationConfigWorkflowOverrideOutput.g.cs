
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"client_events":["audio","interruption"],"max_duration_seconds":600}
    /// </summary>
    public sealed partial class ConversationConfigWorkflowOverrideOutput
    {
        /// <summary>
        /// If enabled audio will not be processed and only text will be used, use to avoid audio pricing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_only")]
        public bool? TextOnly { get; set; }

        /// <summary>
        /// The maximum duration of a conversation in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_seconds")]
        public int? MaxDurationSeconds { get; set; }

        /// <summary>
        /// The events that will be sent to the client
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_events")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>? ClientEvents { get; set; }

        /// <summary>
        /// Configuration for file input (image/PDF uploads) during conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_input")]
        public global::ElevenLabs.FileInputConfigWorkflowOverride? FileInput { get; set; }

        /// <summary>
        /// Enable real-time monitoring of conversations via WebSocket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitoring_enabled")]
        public bool? MonitoringEnabled { get; set; }

        /// <summary>
        /// The events that will be sent to monitoring connections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitoring_events")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>? MonitoringEvents { get; set; }

        /// <summary>
        /// When enabled and knowledge base content is present, the LLM is instructed to report which sources it used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_attribution")]
        public bool? SourceAttribution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigWorkflowOverrideOutput" /> class.
        /// </summary>
        /// <param name="textOnly">
        /// If enabled audio will not be processed and only text will be used, use to avoid audio pricing.
        /// </param>
        /// <param name="maxDurationSeconds">
        /// The maximum duration of a conversation in seconds
        /// </param>
        /// <param name="clientEvents">
        /// The events that will be sent to the client
        /// </param>
        /// <param name="fileInput">
        /// Configuration for file input (image/PDF uploads) during conversations.
        /// </param>
        /// <param name="monitoringEnabled">
        /// Enable real-time monitoring of conversations via WebSocket
        /// </param>
        /// <param name="monitoringEvents">
        /// The events that will be sent to monitoring connections.
        /// </param>
        /// <param name="sourceAttribution">
        /// When enabled and knowledge base content is present, the LLM is instructed to report which sources it used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConfigWorkflowOverrideOutput(
            bool? textOnly,
            int? maxDurationSeconds,
            global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>? clientEvents,
            global::ElevenLabs.FileInputConfigWorkflowOverride? fileInput,
            bool? monitoringEnabled,
            global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>? monitoringEvents,
            bool? sourceAttribution)
        {
            this.TextOnly = textOnly;
            this.MaxDurationSeconds = maxDurationSeconds;
            this.ClientEvents = clientEvents;
            this.FileInput = fileInput;
            this.MonitoringEnabled = monitoringEnabled;
            this.MonitoringEvents = monitoringEvents;
            this.SourceAttribution = sourceAttribution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigWorkflowOverrideOutput" /> class.
        /// </summary>
        public ConversationConfigWorkflowOverrideOutput()
        {
        }
    }
}