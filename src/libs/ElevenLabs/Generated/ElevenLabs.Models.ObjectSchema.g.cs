
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ObjectSchema
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ContentSchema>? Properties { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectSchema" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="type">
        /// Default Value: object
        /// </param>
        /// <param name="properties"></param>
        /// <param name="required"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjectSchema(
            string? title,
            string? description,
            string? type,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ContentSchema>? properties,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Title = title;
            this.Description = description;
            this.Type = type;
            this.Properties = properties;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectSchema" /> class.
        /// </summary>
        public ObjectSchema()
        {
        }

    }
}