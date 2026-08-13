
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body for the ByteDance Seedance 2.5 video model.<br/>
    /// Diverges from the Seedance 2.0 public shape: 480p/720p only, durations up<br/>
    /// to 30s, larger reference caps, audio-only input allowed, and no ``seed``<br/>
    /// (Ark tolerates it but does not honour it).
    /// </summary>
    public sealed partial class BytedanceSeedance25Request
    {
        /// <summary>
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::ElevenLabs.WebhookTarget? Webhook { get; set; }

        /// <summary>
        /// The model to use for the generation.
        /// </summary>
        /// <default>"bytedance-seedance-v2.5"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = "bytedance-seedance-v2.5";

        /// <summary>
        /// A text description of the video to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The aspect ratio of the output video. With `auto`, the model picks an aspect ratio based on the inputs. First-frame / first-and-last-frame tasks always use `auto`.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedance25RequestAspectRatioJsonConverter))]
        public global::ElevenLabs.BytedanceSeedance25RequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The resolution of the output video.<br/>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedance25RequestResolutionJsonConverter))]
        public global::ElevenLabs.BytedanceSeedance25RequestResolution? Resolution { get; set; }

        /// <summary>
        /// The duration of the output video in seconds.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public int? DurationSecs { get; set; }

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
        /// Up to 30 reference images to draw subjects from. Cannot be combined with `start_frame`/`end_frame`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? Images { get; set; }

        /// <summary>
        /// Up to 10 reference videos to draw subjects or motion from. Cannot be combined with `start_frame`/`end_frame`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videos")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoReference>? Videos { get; set; }

        /// <summary>
        /// Up to 10 reference audios, e.g. for lipsync. Cannot be combined with `start_frame`/`end_frame`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audios")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioReference>? Audios { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedance25Request" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A text description of the video to generate.
        /// </param>
        /// <param name="webhook">
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the output video. With `auto`, the model picks an aspect ratio based on the inputs. First-frame / first-and-last-frame tasks always use `auto`.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// The resolution of the output video.<br/>
        /// Default Value: 720p
        /// </param>
        /// <param name="durationSecs">
        /// The duration of the output video in seconds.<br/>
        /// Default Value: 5
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
        /// Up to 30 reference images to draw subjects from. Cannot be combined with `start_frame`/`end_frame`.
        /// </param>
        /// <param name="videos">
        /// Up to 10 reference videos to draw subjects or motion from. Cannot be combined with `start_frame`/`end_frame`.
        /// </param>
        /// <param name="audios">
        /// Up to 10 reference audios, e.g. for lipsync. Cannot be combined with `start_frame`/`end_frame`.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BytedanceSeedance25Request(
            string prompt,
            global::ElevenLabs.WebhookTarget? webhook,
            global::ElevenLabs.BytedanceSeedance25RequestAspectRatio? aspectRatio,
            global::ElevenLabs.BytedanceSeedance25RequestResolution? resolution,
            int? durationSecs,
            bool? generateAudio,
            global::ElevenLabs.ImageReference? startFrame,
            global::ElevenLabs.ImageReference? endFrame,
            global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? images,
            global::System.Collections.Generic.IList<global::ElevenLabs.VideoReference>? videos,
            global::System.Collections.Generic.IList<global::ElevenLabs.AudioReference>? audios,
            string modelId = "bytedance-seedance-v2.5")
        {
            this.Webhook = webhook;
            this.ModelId = modelId;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.DurationSecs = durationSecs;
            this.GenerateAudio = generateAudio;
            this.StartFrame = startFrame;
            this.EndFrame = endFrame;
            this.Images = images;
            this.Videos = videos;
            this.Audios = audios;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedance25Request" /> class.
        /// </summary>
        public BytedanceSeedance25Request()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BytedanceSeedance25Request"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BytedanceSeedance25Request FromPrompt(string prompt)
        {
            return new BytedanceSeedance25Request
            {
                Prompt = prompt,
            };
        }

    }
}