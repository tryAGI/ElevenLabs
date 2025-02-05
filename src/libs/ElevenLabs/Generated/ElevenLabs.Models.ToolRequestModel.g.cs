
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ToolConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ToolConfig ToolConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRequestModel" /> class.
        /// </summary>
        /// <param name="toolConfig"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolRequestModel(
            global::ElevenLabs.ToolConfig toolConfig)
        {
            this.ToolConfig = toolConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRequestModel" /> class.
        /// </summary>
        public ToolRequestModel()
        {
        }
    }
}