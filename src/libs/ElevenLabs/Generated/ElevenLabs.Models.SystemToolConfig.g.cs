
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A system tool is a tool that is used to call a system method in the server
    /// </summary>
    public sealed partial class SystemToolConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SystemToolConfigTypeJsonConverter))]
        public global::ElevenLabs.SystemToolConfigType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SystemToolConfig(
            string name,
            string description,
            global::ElevenLabs.SystemToolConfigType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfig" /> class.
        /// </summary>
        public SystemToolConfig()
        {
        }
    }
}