
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Simulation/preview-side config: tools are identified by IDs, resolved to names at runtime.
    /// </summary>
    public sealed partial class SimulationToolMockBehaviorConfig
    {
        /// <summary>
        /// Which tools to mock: 'all' mocks every mockable tool, 'selected' mocks only those in mocked_tool_names/mocked_tool_ids, 'none' disables mocking.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mocking_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MockingStrategyJsonConverter))]
        public global::ElevenLabs.MockingStrategy? MockingStrategy { get; set; }

        /// <summary>
        /// Behavior when no mock matches a tool call.<br/>
        /// Default Value: raise_error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MockNoMatchBehaviorJsonConverter))]
        public global::ElevenLabs.MockNoMatchBehavior? FallbackStrategy { get; set; }

        /// <summary>
        /// Tool IDs to mock. Resolved to tool names before being passed to the orchestrator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mocked_tool_ids")]
        public global::System.Collections.Generic.IList<string>? MockedToolIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationToolMockBehaviorConfig" /> class.
        /// </summary>
        /// <param name="mockingStrategy">
        /// Which tools to mock: 'all' mocks every mockable tool, 'selected' mocks only those in mocked_tool_names/mocked_tool_ids, 'none' disables mocking.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="fallbackStrategy">
        /// Behavior when no mock matches a tool call.<br/>
        /// Default Value: raise_error
        /// </param>
        /// <param name="mockedToolIds">
        /// Tool IDs to mock. Resolved to tool names before being passed to the orchestrator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationToolMockBehaviorConfig(
            global::ElevenLabs.MockingStrategy? mockingStrategy,
            global::ElevenLabs.MockNoMatchBehavior? fallbackStrategy,
            global::System.Collections.Generic.IList<string>? mockedToolIds)
        {
            this.MockingStrategy = mockingStrategy;
            this.FallbackStrategy = fallbackStrategy;
            this.MockedToolIds = mockedToolIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationToolMockBehaviorConfig" /> class.
        /// </summary>
        public SimulationToolMockBehaviorConfig()
        {
        }

    }
}