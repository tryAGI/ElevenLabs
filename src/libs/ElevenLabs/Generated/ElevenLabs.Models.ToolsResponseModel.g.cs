
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseModel> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsResponseModel" /> class.
        /// </summary>
        /// <param name="tools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseModel> tools)
        {
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsResponseModel" /> class.
        /// </summary>
        public ToolsResponseModel()
        {
        }
    }
}