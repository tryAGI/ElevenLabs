
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Definition for a tool the client can call.
    /// </summary>
    public sealed partial class Tool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSchema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Additional properties describing a Tool to clients.<br/>
        /// NOTE: all properties in ToolAnnotations are **hints**.<br/>
        /// They are not guaranteed to provide a faithful description of<br/>
        /// tool behavior (including descriptive properties like `title`).<br/>
        /// Clients should never make tool use decisions based on ToolAnnotations<br/>
        /// received from untrusted servers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::ElevenLabs.ToolAnnotations? Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="inputSchema"></param>
        /// <param name="outputSchema"></param>
        /// <param name="annotations">
        /// Additional properties describing a Tool to clients.<br/>
        /// NOTE: all properties in ToolAnnotations are **hints**.<br/>
        /// They are not guaranteed to provide a faithful description of<br/>
        /// tool behavior (including descriptive properties like `title`).<br/>
        /// Clients should never make tool use decisions based on ToolAnnotations<br/>
        /// received from untrusted servers.
        /// </param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Tool(
            string name,
            object inputSchema,
            string? title,
            string? description,
            object? outputSchema,
            global::ElevenLabs.ToolAnnotations? annotations,
            object? meta)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.Title = title;
            this.Description = description;
            this.OutputSchema = outputSchema;
            this.Annotations = annotations;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        public Tool()
        {
        }
    }
}