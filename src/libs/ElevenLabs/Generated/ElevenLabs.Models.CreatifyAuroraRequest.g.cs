
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body for the Creatify Aurora lipsync video model.
    /// </summary>
    public sealed partial class CreatifyAuroraRequest
    {
        /// <summary>
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::ElevenLabs.WebhookTarget? Webhook { get; set; }

        /// <summary>
        /// The model to use for the generation.
        /// </summary>
        /// <default>"creatify-aurora"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = "creatify-aurora";

        /// <summary>
        /// The image of the character to animate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ImageReferenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ImageReference Image { get; set; }

        /// <summary>
        /// The speech audio to drive the character's lip movements.
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CreatifyAuroraRequestResolutionJsonConverter))]
        public global::ElevenLabs.CreatifyAuroraRequestResolution? Resolution { get; set; }

        /// <summary>
        /// How strongly the generation adheres to the input image. Omit to use the model's default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// How strongly the lip movements adhere to the audio. Omit to use the model's default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_guidance_scale")]
        public double? AudioGuidanceScale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatifyAuroraRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The image of the character to animate.
        /// </param>
        /// <param name="audio">
        /// The speech audio to drive the character's lip movements.
        /// </param>
        /// <param name="webhook">
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </param>
        /// <param name="resolution">
        /// The resolution of the output video.<br/>
        /// Default Value: 720p
        /// </param>
        /// <param name="guidanceScale">
        /// How strongly the generation adheres to the input image. Omit to use the model's default.
        /// </param>
        /// <param name="audioGuidanceScale">
        /// How strongly the lip movements adhere to the audio. Omit to use the model's default.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatifyAuroraRequest(
            global::ElevenLabs.ImageReference image,
            global::ElevenLabs.AudioReference audio,
            global::ElevenLabs.WebhookTarget? webhook,
            global::ElevenLabs.CreatifyAuroraRequestResolution? resolution,
            double? guidanceScale,
            double? audioGuidanceScale,
            string modelId = "creatify-aurora")
        {
            this.Webhook = webhook;
            this.ModelId = modelId;
            this.Image = image;
            this.Audio = audio;
            this.Resolution = resolution;
            this.GuidanceScale = guidanceScale;
            this.AudioGuidanceScale = audioGuidanceScale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatifyAuroraRequest" /> class.
        /// </summary>
        public CreatifyAuroraRequest()
        {
        }

    }
}