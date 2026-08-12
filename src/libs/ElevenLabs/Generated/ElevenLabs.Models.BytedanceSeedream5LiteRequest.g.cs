
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body for the ByteDance Seedream 5.0 Lite image model.
    /// </summary>
    public sealed partial class BytedanceSeedream5LiteRequest
    {
        /// <summary>
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::ElevenLabs.WebhookTarget? Webhook { get; set; }

        /// <summary>
        /// A text description of the image to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Up to 10 reference images to edit or draw from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? Images { get; set; }

        /// <summary>
        /// The aspect ratio of the output image. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedream5LiteRequestAspectRatioJsonConverter))]
        public global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// A seed for reproducible generation: the same seed and inputs give similar output across generations. Omit for random.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The model to use for the generation.
        /// </summary>
        /// <default>"bytedance-seedream-5-lite"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = "bytedance-seedream-5-lite";

        /// <summary>
        /// The resolution of the output image.<br/>
        /// Default Value: 2K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedream5LiteRequestResolutionJsonConverter))]
        public global::ElevenLabs.BytedanceSeedream5LiteRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedream5LiteRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A text description of the image to generate.
        /// </param>
        /// <param name="webhook">
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </param>
        /// <param name="images">
        /// Up to 10 reference images to edit or draw from.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the output image. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="seed">
        /// A seed for reproducible generation: the same seed and inputs give similar output across generations. Omit for random.
        /// </param>
        /// <param name="resolution">
        /// The resolution of the output image.<br/>
        /// Default Value: 2K
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BytedanceSeedream5LiteRequest(
            string prompt,
            global::ElevenLabs.WebhookTarget? webhook,
            global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? images,
            global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio? aspectRatio,
            int? seed,
            global::ElevenLabs.BytedanceSeedream5LiteRequestResolution? resolution,
            string modelId = "bytedance-seedream-5-lite")
        {
            this.Webhook = webhook;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Seed = seed;
            this.ModelId = modelId;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedream5LiteRequest" /> class.
        /// </summary>
        public BytedanceSeedream5LiteRequest()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BytedanceSeedream5LiteRequest"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BytedanceSeedream5LiteRequest FromPrompt(string prompt)
        {
            return new BytedanceSeedream5LiteRequest
            {
                Prompt = prompt,
            };
        }

    }
}