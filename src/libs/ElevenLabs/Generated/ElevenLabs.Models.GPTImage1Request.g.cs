
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body for the OpenAI GPT Image 1 model.
    /// </summary>
    public sealed partial class GPTImage1Request
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImage1RequestQualityJsonConverter))]
        public global::ElevenLabs.GPTImage1RequestQuality? Quality { get; set; }

        /// <summary>
        /// The background of the output image. With `auto`, the model picks the background that suits the image.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImage1RequestBackgroundJsonConverter))]
        public global::ElevenLabs.GPTImage1RequestBackground? Background { get; set; }

        /// <summary>
        /// The aspect ratio of the output image.<br/>
        /// Default Value: 1:1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImage1RequestAspectRatioJsonConverter))]
        public global::ElevenLabs.GPTImage1RequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The model to use for the generation.
        /// </summary>
        /// <default>"gpt-image-1"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = "gpt-image-1";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPTImage1Request" /> class.
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
        public GPTImage1Request(
            string prompt,
            global::ElevenLabs.WebhookTarget? webhook,
            global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? images,
            global::ElevenLabs.ImageReference? mask,
            global::ElevenLabs.GPTImage1RequestQuality? quality,
            global::ElevenLabs.GPTImage1RequestBackground? background,
            global::ElevenLabs.GPTImage1RequestAspectRatio? aspectRatio,
            string modelId = "gpt-image-1")
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
        /// Initializes a new instance of the <see cref="GPTImage1Request" /> class.
        /// </summary>
        public GPTImage1Request()
        {
        }

        /// <summary>
        /// Creates a new <see cref="GPTImage1Request"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static GPTImage1Request FromPrompt(string prompt)
        {
            return new GPTImage1Request
            {
                Prompt = prompt,
            };
        }

    }
}