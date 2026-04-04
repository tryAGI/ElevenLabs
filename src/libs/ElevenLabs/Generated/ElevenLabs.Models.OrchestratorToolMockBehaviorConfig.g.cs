
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Orchestrator-side config: tools are identified by resolved names.
    /// </summary>
    public sealed partial class OrchestratorToolMockBehaviorConfig
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
        /// Tool names to mock. Only used when mocking_strategy is 'selected'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mocked_tool_names")]
        public global::System.Collections.Generic.IList<string>? MockedToolNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorToolMockBehaviorConfig" /> class.
        /// </summary>
        /// <param name="mockingStrategy">
        /// Which tools to mock: 'all' mocks every mockable tool, 'selected' mocks only those in mocked_tool_names/mocked_tool_ids, 'none' disables mocking.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="fallbackStrategy">
        /// Behavior when no mock matches a tool call.<br/>
        /// Default Value: raise_error
        /// </param>
        /// <param name="mockedToolNames">
        /// Tool names to mock. Only used when mocking_strategy is 'selected'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrchestratorToolMockBehaviorConfig(
            global::ElevenLabs.MockingStrategy? mockingStrategy,
            global::ElevenLabs.MockNoMatchBehavior? fallbackStrategy,
            global::System.Collections.Generic.IList<string>? mockedToolNames)
        {
            this.MockingStrategy = mockingStrategy;
            this.FallbackStrategy = fallbackStrategy;
            this.MockedToolNames = mockedToolNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorToolMockBehaviorConfig" /> class.
        /// </summary>
        public OrchestratorToolMockBehaviorConfig()
        {
        }
    }
}