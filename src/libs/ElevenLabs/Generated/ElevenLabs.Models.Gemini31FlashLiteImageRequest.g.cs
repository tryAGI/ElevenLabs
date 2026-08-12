
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body for the Google Gemini 3.1 Flash Lite image model.
    /// </summary>
    public sealed partial class Gemini31FlashLiteImageRequest
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
        /// The model to use for the generation.
        /// </summary>
        /// <default>"gemini-3.1-flash-lite-image"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = "gemini-3.1-flash-lite-image";

        /// <summary>
        /// Up to 14 reference images to edit or draw from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? Images { get; set; }

        /// <summary>
        /// The aspect ratio of the output image. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Gemini31FlashLiteImageRequestAspectRatioJsonConverter))]
        public global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The resolution of the output image.<br/>
        /// Default Value: 1K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Gemini31FlashLiteImageRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A text description of the image to generate.
        /// </param>
        /// <param name="webhook">
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </param>
        /// <param name="images">
        /// Up to 14 reference images to edit or draw from.
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
        public Gemini31FlashLiteImageRequest(
            string prompt,
            global::ElevenLabs.WebhookTarget? webhook,
            global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? images,
            global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio? aspectRatio,
            string? resolution,
            string modelId = "gemini-3.1-flash-lite-image")
        {
            this.Webhook = webhook;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ModelId = modelId;
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Gemini31FlashLiteImageRequest" /> class.
        /// </summary>
        public Gemini31FlashLiteImageRequest()
        {
        }

        /// <summary>
        /// Creates a new <see cref="Gemini31FlashLiteImageRequest"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static Gemini31FlashLiteImageRequest FromPrompt(string prompt)
        {
            return new Gemini31FlashLiteImageRequest
            {
                Prompt = prompt,
            };
        }

    }
}