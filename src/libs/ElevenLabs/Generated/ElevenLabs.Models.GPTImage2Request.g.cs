
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body for the OpenAI GPT Image 2 model.
    /// </summary>
    public sealed partial class GPTImage2Request
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
        /// An image whose fully transparent areas mark where the first reference image may be edited; requires `images`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public global::ElevenLabs.ImageReference? Mask { get; set; }

        /// <summary>
        /// The quality of the output image.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImage2RequestQualityJsonConverter))]
        public global::ElevenLabs.GPTImage2RequestQuality? Quality { get; set; }

        /// <summary>
        /// The model to use for the generation.
        /// </summary>
        /// <default>"gpt-image-2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = "gpt-image-2";

        /// <summary>
        /// The aspect ratio of the output image. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImage2RequestAspectRatioJsonConverter))]
        public global::ElevenLabs.GPTImage2RequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The resolution of the output image.<br/>
        /// Default Value: 1K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImage2RequestResolutionJsonConverter))]
        public global::ElevenLabs.GPTImage2RequestResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPTImage2Request" /> class.
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
        /// <param name="mask">
        /// An image whose fully transparent areas mark where the first reference image may be edited; requires `images`.
        /// </param>
        /// <param name="quality">
        /// The quality of the output image.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the output image. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// The resolution of the output image.<br/>
        /// Default Value: 1K
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPTImage2Request(
            string prompt,
            global::ElevenLabs.WebhookTarget? webhook,
            global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? images,
            global::ElevenLabs.ImageReference? mask,
            global::ElevenLabs.GPTImage2RequestQuality? quality,
            global::ElevenLabs.GPTImage2RequestAspectRatio? aspectRatio,
            global::ElevenLabs.GPTImage2RequestResolution? resolution,
            string modelId = "gpt-image-2")
        {
            this.Webhook = webhook;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Images = images;
            this.Mask = mask;
            this.Quality = quality;
            this.ModelId = modelId;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPTImage2Request" /> class.
        /// </summary>
        public GPTImage2Request()
        {
        }

        /// <summary>
        /// Creates a new <see cref="GPTImage2Request"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static GPTImage2Request FromPrompt(string prompt)
        {
            return new GPTImage2Request
            {
                Prompt = prompt,
            };
        }

    }
}