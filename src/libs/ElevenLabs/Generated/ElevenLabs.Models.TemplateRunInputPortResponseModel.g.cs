
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Input port value for a specific template run.
    /// </summary>
    public sealed partial class TemplateRunInputPortResponseModel
    {
        /// <summary>
        /// Input port ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Input port display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Input port modality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ContentModalityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ContentModality Modality { get; set; }

        /// <summary>
        /// Resolved value bound to this input port for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ReferenceText, global::ElevenLabs.ReferenceImage, global::ElevenLabs.ReferenceVideo, global::ElevenLabs.ReferenceAudio, object>))]
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ReferenceText, global::ElevenLabs.ReferenceImage, global::ElevenLabs.ReferenceVideo, global::ElevenLabs.ReferenceAudio, object>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunInputPortResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Input port ID.
        /// </param>
        /// <param name="name">
        /// Input port display name.
        /// </param>
        /// <param name="modality">
        /// Input port modality.
        /// </param>
        /// <param name="value">
        /// Resolved value bound to this input port for this run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateRunInputPortResponseModel(
            string id,
            string name,
            global::ElevenLabs.ContentModality modality,
            global::ElevenLabs.AnyOf<global::ElevenLabs.ReferenceText, global::ElevenLabs.ReferenceImage, global::ElevenLabs.ReferenceVideo, global::ElevenLabs.ReferenceAudio, object>? value)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Modality = modality;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunInputPortResponseModel" /> class.
        /// </summary>
        public TemplateRunInputPortResponseModel()
        {
        }

    }
}