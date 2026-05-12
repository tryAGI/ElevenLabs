
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The temperature for the LLM. Defaults to 0. Set to null to omit the parameter from the LLM request entirely (useful for custom LLMs that reject the temperature field).<br/>
    /// Default Value: 0F
    /// </summary>
    public sealed partial class PromptAgentAPIModelOutputTemperature
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}