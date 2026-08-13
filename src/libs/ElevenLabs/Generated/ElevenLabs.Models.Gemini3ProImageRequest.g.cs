
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body for the Google Gemini 3 Pro image model.
    /// </summary>
    public sealed partial class Gemini3ProImageRequest
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
        /// <default>"gemini-3-pro-image"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = "gemini-3-pro-image";

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Gemini3ProImageRequestAspectRatioJsonConverter))]
        public global::ElevenLabs.Gemini3ProImageRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The resolution of the output image.<br/>
        /// Default Value: 1K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Gemini3ProImageRequestResolutionJsonConverter))]
        public global::ElevenLabs.Gemini3ProImageRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Gemini3ProImageRequest" /> class.
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
        public Gemini3ProImageRequest(
            string prompt,
            global::ElevenLabs.WebhookTarget? webhook,
            global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? images,
            global::ElevenLabs.Gemini3ProImageRequestAspectRatio? aspectRatio,
            global::ElevenLabs.Gemini3ProImageRequestResolution? resolution,
            string modelId = "gemini-3-pro-image")
        {
            this.Webhook = webhook;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ModelId = modelId;
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Gemini3ProImageRequest" /> class.
        /// </summary>
        public Gemini3ProImageRequest()
        {
        }

        /// <summary>
        /// Creates a new <see cref="Gemini3ProImageRequest"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static Gemini3ProImageRequest FromPrompt(string prompt)
        {
            return new Gemini3ProImageRequest
            {
                Prompt = prompt,
            };
        }

    }
}