
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DynamicVariablesConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable_placeholders")]
        public object? DynamicVariablePlaceholders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariablesConfig" /> class.
        /// </summary>
        /// <param name="dynamicVariablePlaceholders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicVariablesConfig(
            object? dynamicVariablePlaceholders)
        {
            this.DynamicVariablePlaceholders = dynamicVariablePlaceholders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariablesConfig" /> class.
        /// </summary>
        public DynamicVariablesConfig()
        {
        }
    }
}