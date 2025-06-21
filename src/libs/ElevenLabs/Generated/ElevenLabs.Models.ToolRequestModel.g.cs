
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolRequestModel
    {
        /// <summary>
        /// The type of tool
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
        /// <param name="toolConfig">
        /// The type of tool
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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