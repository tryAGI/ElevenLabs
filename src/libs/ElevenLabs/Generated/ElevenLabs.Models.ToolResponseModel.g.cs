
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ToolConfig2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ToolConfig2 ToolConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ResourceAccessInfo AccessInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ToolUsageStatsResponseModel UsageStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="toolConfig">
        /// The type of tool
        /// </param>
        /// <param name="accessInfo"></param>
        /// <param name="usageStats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolResponseModel(
            string id,
            global::ElevenLabs.ToolConfig2 toolConfig,
            global::ElevenLabs.ResourceAccessInfo accessInfo,
            global::ElevenLabs.ToolUsageStatsResponseModel usageStats)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ToolConfig = toolConfig;
            this.AccessInfo = accessInfo ?? throw new global::System.ArgumentNullException(nameof(accessInfo));
            this.UsageStats = usageStats ?? throw new global::System.ArgumentNullException(nameof(usageStats));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResponseModel" /> class.
        /// </summary>
        public ToolResponseModel()
        {
        }
    }
}