
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body for the Google Veo 3.1 Fast video model.
    /// </summary>
    public sealed partial class Veo31FastRequest
    {
        /// <summary>
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::ElevenLabs.WebhookTarget? Webhook { get; set; }

        /// <summary>
        /// A text description of the video to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// A text description of what the video should avoid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// A seed for reproducible generation: the same seed and inputs give similar output across generations. Omit for random.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Whether the model may rewrite the prompt to improve results.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance_prompt")]
        public bool? EnhancePrompt { get; set; }

        /// <summary>
        /// The duration of the output video in seconds.<br/>
        /// Default Value: 8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// The aspect ratio of the output video.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Veo31FastRequestAspectRatioJsonConverter))]
        public global::ElevenLabs.Veo31FastRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The resolution of the output video.<br/>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Veo31FastRequestResolutionJsonConverter))]
        public global::ElevenLabs.Veo31FastRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Whether to generate audio with the video.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_audio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// The image to use as the video's first frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame")]
        public global::ElevenLabs.ImageReference? StartFrame { get; set; }

        /// <summary>
        /// The image to use as the video's last frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_frame")]
        public global::ElevenLabs.ImageReference? EndFrame { get; set; }

        /// <summary>
        /// Up to 3 reference images to draw subjects or style from. Cannot be combined with `start_frame`/`end_frame`, and requires the 8-second duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.VeoImageReference>? Images { get; set; }

        /// <summary>
        /// The model to use for the generation.
        /// </summary>
        /// <default>"veo-3.1-fast-generate-001"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = "veo-3.1-fast-generate-001";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Veo31FastRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A text description of the video to generate.
        /// </param>
        /// <param name="webhook">
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </param>
        /// <param name="negativePrompt">
        /// A text description of what the video should avoid.
        /// </param>
        /// <param name="seed">
        /// A seed for reproducible generation: the same seed and inputs give similar output across generations. Omit for random.
        /// </param>
        /// <param name="enhancePrompt">
        /// Whether the model may rewrite the prompt to improve results.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="durationSecs">
        /// The duration of the output video in seconds.<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the output video.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// The resolution of the output video.<br/>
        /// Default Value: 720p
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate audio with the video.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="startFrame">
        /// The image to use as the video's first frame.
        /// </param>
        /// <param name="endFrame">
        /// The image to use as the video's last frame.
        /// </param>
        /// <param name="images">
        /// Up to 3 reference images to draw subjects or style from. Cannot be combined with `start_frame`/`end_frame`, and requires the 8-second duration.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Veo31FastRequest(
            string prompt,
            global::ElevenLabs.WebhookTarget? webhook,
            string? negativePrompt,
            int? seed,
            bool? enhancePrompt,
            int? durationSecs,
            global::ElevenLabs.Veo31FastRequestAspectRatio? aspectRatio,
            global::ElevenLabs.Veo31FastRequestResolution? resolution,
            bool? generateAudio,
            global::ElevenLabs.ImageReference? startFrame,
            global::ElevenLabs.ImageReference? endFrame,
            global::System.Collections.Generic.IList<global::ElevenLabs.VeoImageReference>? images,
            string modelId = "veo-3.1-fast-generate-001")
        {
            this.Webhook = webhook;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.Seed = seed;
            this.EnhancePrompt = enhancePrompt;
            this.DurationSecs = durationSecs;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.GenerateAudio = generateAudio;
            this.StartFrame = startFrame;
            this.EndFrame = endFrame;
            this.Images = images;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Veo31FastRequest" /> class.
        /// </summary>
        public Veo31FastRequest()
        {
        }

        /// <summary>
        /// Creates a new <see cref="Veo31FastRequest"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static Veo31FastRequest FromPrompt(string prompt)
        {
            return new Veo31FastRequest
            {
                Prompt = prompt,
            };
        }

    }
}