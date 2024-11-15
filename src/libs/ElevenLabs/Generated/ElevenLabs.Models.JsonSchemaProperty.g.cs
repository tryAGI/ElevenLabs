
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSchemaProperty
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.JsonLiteralType?, global::ElevenLabs.JsonSchemaPropertyType?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnyOf<global::ElevenLabs.JsonLiteralType?, global::ElevenLabs.JsonSchemaPropertyType?> Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaProperty" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public JsonSchemaProperty(
            global::ElevenLabs.AnyOf<global::ElevenLabs.JsonLiteralType?, global::ElevenLabs.JsonSchemaPropertyType?> type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaProperty" /> class.
        /// </summary>
        public JsonSchemaProperty()
        {
        }
    }
}