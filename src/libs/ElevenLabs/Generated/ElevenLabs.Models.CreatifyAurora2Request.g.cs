
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body for the Creatify Aurora 2.0 lipsync video model.
    /// </summary>
    public sealed partial class CreatifyAurora2Request
    {
        /// <summary>
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::ElevenLabs.WebhookTarget? Webhook { get; set; }

        /// <summary>
        /// The model to use for the generation.
        /// </summary>
        /// <default>"creatify-aurora-2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = "creatify-aurora-2";

        /// <summary>
        /// The image of the character to animate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ImageReferenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ImageReference Image { get; set; }

        /// <summary>
        /// The speech audio to drive the character's lip movements. At most 59.7 seconds, or 14.375 seconds at `2K`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AudioReferenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AudioReference Audio { get; set; }

        /// <summary>
        /// The resolution of the output video.<br/>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CreatifyAurora2RequestResolutionJsonConverter))]
        public global::ElevenLabs.CreatifyAurora2RequestResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatifyAurora2Request" /> class.
        /// </summary>
        /// <param name="image">
        /// The image of the character to animate.
        /// </param>
        /// <param name="audio">
        /// The speech audio to drive the character's lip movements. At most 59.7 seconds, or 14.375 seconds at `2K`.
        /// </param>
        /// <param name="webhook">
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </param>
        /// <param name="resolution">
        /// The resolution of the output video.<br/>
        /// Default Value: 720p
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatifyAurora2Request(
            global::ElevenLabs.ImageReference image,
            global::ElevenLabs.AudioReference audio,
            global::ElevenLabs.WebhookTarget? webhook,
            global::ElevenLabs.CreatifyAurora2RequestResolution? resolution,
            string modelId = "creatify-aurora-2")
        {
            this.Webhook = webhook;
            this.ModelId = modelId;
            this.Image = image;
            this.Audio = audio;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatifyAurora2Request" /> class.
        /// </summary>
        public CreatifyAurora2Request()
        {
        }

    }
}