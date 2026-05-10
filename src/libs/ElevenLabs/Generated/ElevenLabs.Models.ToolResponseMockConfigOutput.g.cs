
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolResponseMockConfigOutput
    {
        /// <summary>
        /// If the list is empty, the mock will always activate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter_conditions")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestToolCallParameter>? ParameterConditions { get; set; }

        /// <summary>
        /// The return value the LLM sees when this mock is active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mock_result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MockResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResponseMockConfigOutput" /> class.
        /// </summary>
        /// <param name="mockResult">
        /// The return value the LLM sees when this mock is active.
        /// </param>
        /// <param name="parameterConditions">
        /// If the list is empty, the mock will always activate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolResponseMockConfigOutput(
            string mockResult,
            global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestToolCallParameter>? parameterConditions)
        {
            this.ParameterConditions = parameterConditions;
            this.MockResult = mockResult ?? throw new global::System.ArgumentNullException(nameof(mockResult));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResponseMockConfigOutput" /> class.
        /// </summary>
        public ToolResponseMockConfigOutput()
        {
        }

    }
}