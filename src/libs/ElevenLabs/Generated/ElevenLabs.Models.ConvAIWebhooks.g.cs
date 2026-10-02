
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConvAIWebhooks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_call_webhook_id")]
        public string? PostCallWebhookId { get; set; }

        /// <summary>
        /// List of event types to send via webhook. Options: transcript, audio, call_initiation_failure, answering_machine_detection, unredacted_transcript, unredacted_audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.WebhookEventType>? Events { get; set; }

        /// <summary>
        /// Format for transcript webhooks.<br/>
        /// Default Value: json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WebhookTranscriptFormatJsonConverter))]
        public global::ElevenLabs.WebhookTranscriptFormat? TranscriptFormat { get; set; }

        /// <summary>
        /// When true, JSON post-call transcription webhooks omit the turn-by-turn transcript. Analysis, metadata, and other conversation fields are still sent. Ignored for OpenTelemetry transcript format.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_transcript")]
        public bool? ExcludeTranscript { get; set; }

        /// <summary>
        /// DEPRECATED: Use 'events' field instead. Whether to send audio data with post-call webhooks for ConvAI conversations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_audio")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SendAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWebhooks" /> class.
        /// </summary>
        /// <param name="postCallWebhookId"></param>
        /// <param name="events">
        /// List of event types to send via webhook. Options: transcript, audio, call_initiation_failure, answering_machine_detection, unredacted_transcript, unredacted_audio.
        /// </param>
        /// <param name="transcriptFormat">
        /// Format for transcript webhooks.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="excludeTranscript">
        /// When true, JSON post-call transcription webhooks omit the turn-by-turn transcript. Analysis, metadata, and other conversation fields are still sent. Ignored for OpenTelemetry transcript format.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvAIWebhooks(
            string? postCallWebhookId,
            global::System.Collections.Generic.IList<global::ElevenLabs.WebhookEventType>? events,
            global::ElevenLabs.WebhookTranscriptFormat? transcriptFormat,
            bool? excludeTranscript)
        {
            this.PostCallWebhookId = postCallWebhookId;
            this.Events = events;
            this.TranscriptFormat = transcriptFormat;
            this.ExcludeTranscript = excludeTranscript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWebhooks" /> class.
        /// </summary>
        public ConvAIWebhooks()
        {
        }

    }
}