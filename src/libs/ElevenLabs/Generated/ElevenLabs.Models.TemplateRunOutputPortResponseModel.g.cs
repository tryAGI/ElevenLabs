
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Output port value for a specific template run.
    /// </summary>
    public sealed partial class TemplateRunOutputPortResponseModel
    {
        /// <summary>
        /// Output port ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Output port display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Output port modality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ContentModalityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ContentModality Modality { get; set; }

        /// <summary>
        /// Resolved output generation value for this output port.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::ElevenLabs.ContentGenerationResponseModel? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunOutputPortResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Output port ID.
        /// </param>
        /// <param name="name">
        /// Output port display name.
        /// </param>
        /// <param name="modality">
        /// Output port modality.
        /// </param>
        /// <param name="value">
        /// Resolved output generation value for this output port.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateRunOutputPortResponseModel(
            string id,
            string name,
            global::ElevenLabs.ContentModality modality,
            global::ElevenLabs.ContentGenerationResponseModel? value)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Modality = modality;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunOutputPortResponseModel" /> class.
        /// </summary>
        public TemplateRunOutputPortResponseModel()
        {
        }

    }
}