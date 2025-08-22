
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestToolResultModel
    {
        /// <summary>
        /// Default Value: testing_tool_result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TestToolResultModelResultTypeJsonConverter))]
        public global::ElevenLabs.TestToolResultModelResultType? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TestToolResultModelStatusJsonConverter))]
        public global::ElevenLabs.TestToolResultModelStatus? Status { get; set; }

        /// <summary>
        /// Default Value: Skipping tool call in test mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolResultModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: testing_tool_result
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="reason">
        /// Default Value: Skipping tool call in test mode
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestToolResultModel(
            global::ElevenLabs.TestToolResultModelResultType? resultType,
            global::ElevenLabs.TestToolResultModelStatus? status,
            string? reason)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolResultModel" /> class.
        /// </summary>
        public TestToolResultModel()
        {
        }
    }
}