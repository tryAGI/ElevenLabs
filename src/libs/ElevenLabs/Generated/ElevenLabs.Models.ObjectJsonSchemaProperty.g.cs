
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjectJsonSchemaProperty
    {
        /// <summary>
        /// Default Value: object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ObjectJsonSchemaPropertyTypeJsonConverter))]
        public global::ElevenLabs.ObjectJsonSchemaPropertyType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.JsonSchemaProperty>? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectJsonSchemaProperty" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: object
        /// </param>
        /// <param name="properties"></param>
        /// <param name="required"></param>
        /// <param name="description"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ObjectJsonSchemaProperty(
            global::ElevenLabs.ObjectJsonSchemaPropertyType? type,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.JsonSchemaProperty>? properties,
            global::System.Collections.Generic.IList<string>? required,
            string? description)
        {
            this.Type = type;
            this.Properties = properties;
            this.Required = required;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectJsonSchemaProperty" /> class.
        /// </summary>
        public ObjectJsonSchemaProperty()
        {
        }
    }
}