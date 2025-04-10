
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemToolConfigOutputParamsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeJsonConverter))]
        public global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType? SystemToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfigOutputParamsDiscriminator" /> class.
        /// </summary>
        /// <param name="systemToolType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemToolConfigOutputParamsDiscriminator(
            global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType? systemToolType)
        {
            this.SystemToolType = systemToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfigOutputParamsDiscriminator" /> class.
        /// </summary>
        public SystemToolConfigOutputParamsDiscriminator()
        {
        }
    }
}