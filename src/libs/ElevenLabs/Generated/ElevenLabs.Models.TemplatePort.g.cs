
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// One input or output port of a published template version.
    /// </summary>
    public sealed partial class TemplatePort
    {
        /// <summary>
        /// The port id. Input ids are the keys of the `inputs` map on `POST /v1/flows/templates/{template_id}/runs`; output ids are the keys of the `outputs` map on the run response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// What this port accepts or produces, as a `ContentSchema`. Its `title` is the port's display name and its `description` is the help text the template author wrote. For an input, its `type` decides what value is accepted: `string` takes a bare string or a `generation` reference, `voice` takes a `voice` reference, and `image`/`video`/`audio` take an `asset`, `generation` or `inline_base64` reference. `number`, `integer` and `boolean` take a JSON value of that type. An `array` input takes a JSON array with one value per element, each admissible for its `items`. `object` inputs cannot be bound through this API yet. A `string` schema may carry an `enum` of the only values accepted. For an output, its `type` decides which `Template&lt;Kind&gt;Output` shape the run response holds under the port id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_schema")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ContentSchemaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ContentSchema ContentSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatePort" /> class.
        /// </summary>
        /// <param name="id">
        /// The port id. Input ids are the keys of the `inputs` map on `POST /v1/flows/templates/{template_id}/runs`; output ids are the keys of the `outputs` map on the run response.
        /// </param>
        /// <param name="contentSchema">
        /// What this port accepts or produces, as a `ContentSchema`. Its `title` is the port's display name and its `description` is the help text the template author wrote. For an input, its `type` decides what value is accepted: `string` takes a bare string or a `generation` reference, `voice` takes a `voice` reference, and `image`/`video`/`audio` take an `asset`, `generation` or `inline_base64` reference. `number`, `integer` and `boolean` take a JSON value of that type. An `array` input takes a JSON array with one value per element, each admissible for its `items`. `object` inputs cannot be bound through this API yet. A `string` schema may carry an `enum` of the only values accepted. For an output, its `type` decides which `Template&lt;Kind&gt;Output` shape the run response holds under the port id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatePort(
            string id,
            global::ElevenLabs.ContentSchema contentSchema)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ContentSchema = contentSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatePort" /> class.
        /// </summary>
        public TemplatePort()
        {
        }

    }
}