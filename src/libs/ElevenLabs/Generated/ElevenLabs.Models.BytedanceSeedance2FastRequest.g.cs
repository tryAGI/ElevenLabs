
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body for the ByteDance Seedance 2.0 Fast video model.
    /// </summary>
    public sealed partial class BytedanceSeedance2FastRequest
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
        /// The aspect ratio of the output video. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedance2FastRequestAspectRatioJsonConverter))]
        public global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The duration of the output video in seconds.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// A seed for reproducible generation: the same seed and inputs give similar output across generations. Omit for random.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

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
        /// Up to 9 reference images to draw subjects from. Cannot be combined with `start_frame`/`end_frame`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? Images { get; set; }

        /// <summary>
        /// Up to 3 reference videos to draw subjects or motion from. Cannot be combined with `start_frame`/`end_frame`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videos")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoReference>? Videos { get; set; }

        /// <summary>
        /// Up to 3 reference audios, e.g. for lipsync. Requires at least one of `images` or `videos`, and cannot be combined with `start_frame`/`end_frame`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audios")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioReference>? Audios { get; set; }

        /// <summary>
        /// The model to use for the generation.
        /// </summary>
        /// <default>"bytedance-seedance-v2-fast"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = "bytedance-seedance-v2-fast";

        /// <summary>
        /// The resolution of the output video.<br/>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedance2FastRequestResolutionJsonConverter))]
        public global::ElevenLabs.BytedanceSeedance2FastRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedance2FastRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A text description of the video to generate.
        /// </param>
        /// <param name="webhook">
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the output video. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="durationSecs">
        /// The duration of the output video in seconds.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="seed">
        /// A seed for reproducible generation: the same seed and inputs give similar output across generations. Omit for random.
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
        /// Up to 9 reference images to draw subjects from. Cannot be combined with `start_frame`/`end_frame`.
        /// </param>
        /// <param name="videos">
        /// Up to 3 reference videos to draw subjects or motion from. Cannot be combined with `start_frame`/`end_frame`.
        /// </param>
        /// <param name="audios">
        /// Up to 3 reference audios, e.g. for lipsync. Requires at least one of `images` or `videos`, and cannot be combined with `start_frame`/`end_frame`.
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
        public BytedanceSeedance2FastRequest(
            string prompt,
            global::ElevenLabs.WebhookTarget? webhook,
            global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio? aspectRatio,
            int? durationSecs,
            int? seed,
            bool? generateAudio,
            global::ElevenLabs.ImageReference? startFrame,
            global::ElevenLabs.ImageReference? endFrame,
            global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? images,
            global::System.Collections.Generic.IList<global::ElevenLabs.VideoReference>? videos,
            global::System.Collections.Generic.IList<global::ElevenLabs.AudioReference>? audios,
            global::ElevenLabs.BytedanceSeedance2FastRequestResolution? resolution,
            string modelId = "bytedance-seedance-v2-fast")
        {
            this.Webhook = webhook;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.AspectRatio = aspectRatio;
            this.DurationSecs = durationSecs;
            this.Seed = seed;
            this.GenerateAudio = generateAudio;
            this.StartFrame = startFrame;
            this.EndFrame = endFrame;
            this.Images = images;
            this.Videos = videos;
            this.Audios = audios;
            this.ModelId = modelId;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedance2FastRequest" /> class.
        /// </summary>
        public BytedanceSeedance2FastRequest()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BytedanceSeedance2FastRequest"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BytedanceSeedance2FastRequest FromPrompt(string prompt)
        {
            return new BytedanceSeedance2FastRequest
            {
                Prompt = prompt,
            };
        }

    }
}