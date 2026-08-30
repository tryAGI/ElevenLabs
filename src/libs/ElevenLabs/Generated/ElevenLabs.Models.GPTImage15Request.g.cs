
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body for the OpenAI GPT Image 1.5 model.
    /// </summary>
    public sealed partial class GPTImage15Request
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
        /// Up to 5 reference images to edit or draw from.
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImage15RequestQualityJsonConverter))]
        public global::ElevenLabs.GPTImage15RequestQuality? Quality { get; set; }

        /// <summary>
        /// The background of the output image. With `auto`, the model picks the background that suits the image.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImage15RequestBackgroundJsonConverter))]
        public global::ElevenLabs.GPTImage15RequestBackground? Background { get; set; }

        /// <summary>
        /// The aspect ratio of the output image.<br/>
        /// Default Value: 1:1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImage15RequestAspectRatioJsonConverter))]
        public global::ElevenLabs.GPTImage15RequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The model to use for the generation.
        /// </summary>
        /// <default>"gpt-image-1.5"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = "gpt-image-1.5";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPTImage15Request" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A text description of the image to generate.
        /// </param>
        /// <param name="webhook">
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </param>
        /// <param name="images">
        /// Up to 5 reference images to edit or draw from.
        /// </param>
        /// <param name="mask">
        /// An image whose fully transparent areas mark where the first reference image may be edited; requires `images`.
        /// </param>
        /// <param name="quality">
        /// The quality of the output image.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="background">
        /// The background of the output image. With `auto`, the model picks the background that suits the image.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the output image.<br/>
        /// Default Value: 1:1
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPTImage15Request(
            string prompt,
            global::ElevenLabs.WebhookTarget? webhook,
            global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? images,
            global::ElevenLabs.ImageReference? mask,
            global::ElevenLabs.GPTImage15RequestQuality? quality,
            global::ElevenLabs.GPTImage15RequestBackground? background,
            global::ElevenLabs.GPTImage15RequestAspectRatio? aspectRatio,
            string modelId = "gpt-image-1.5")
        {
            this.Webhook = webhook;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Images = images;
            this.Mask = mask;
            this.Quality = quality;
            this.Background = background;
            this.AspectRatio = aspectRatio;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPTImage15Request" /> class.
        /// </summary>
        public GPTImage15Request()
        {
        }

        /// <summary>
        /// Creates a new <see cref="GPTImage15Request"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static GPTImage15Request FromPrompt(string prompt)
        {
            return new GPTImage15Request
            {
                Prompt = prompt,
            };
        }

    }
}