
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunSubagentToolResultSuccessModel
    {
        /// <summary>
        /// Default Value: run_subagent_success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        public string? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSubagentToolResultSuccessModel" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="agentResponse"></param>
        /// <param name="resultType">
        /// Default Value: run_subagent_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunSubagentToolResultSuccessModel(
            string query,
            string agentResponse,
            string? resultType,
            string? status)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.AgentResponse = agentResponse ?? throw new global::System.ArgumentNullException(nameof(agentResponse));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSubagentToolResultSuccessModel" /> class.
        /// </summary>
        public RunSubagentToolResultSuccessModel()
        {
        }

    }
}