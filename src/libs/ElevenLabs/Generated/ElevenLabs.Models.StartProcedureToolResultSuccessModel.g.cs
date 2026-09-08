
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StartProcedureToolResultSuccessModel
    {
        /// <summary>
        /// Default Value: start_procedure_success
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
        [global::System.Text.Json.Serialization.JsonPropertyName("procedure_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProcedureId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("procedure_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProcedureName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("procedure_entry_workflow_node")]
        public string? ProcedureEntryWorkflowNode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("procedure_return_workflow_node")]
        public string? ProcedureReturnWorkflowNode { get; set; }

        /// <summary>
        /// Default Value: Procedure is now started. Follow its instructions from the &lt;active-procedures&gt; section of your system prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartProcedureToolResultSuccessModel" /> class.
        /// </summary>
        /// <param name="procedureId"></param>
        /// <param name="procedureName"></param>
        /// <param name="resultType">
        /// Default Value: start_procedure_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="procedureEntryWorkflowNode"></param>
        /// <param name="procedureReturnWorkflowNode"></param>
        /// <param name="message">
        /// Default Value: Procedure is now started. Follow its instructions from the &lt;active-procedures&gt; section of your system prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartProcedureToolResultSuccessModel(
            string procedureId,
            string procedureName,
            string? resultType,
            string? status,
            string? procedureEntryWorkflowNode,
            string? procedureReturnWorkflowNode,
            string? message)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.ProcedureId = procedureId ?? throw new global::System.ArgumentNullException(nameof(procedureId));
            this.ProcedureName = procedureName ?? throw new global::System.ArgumentNullException(nameof(procedureName));
            this.ProcedureEntryWorkflowNode = procedureEntryWorkflowNode;
            this.ProcedureReturnWorkflowNode = procedureReturnWorkflowNode;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartProcedureToolResultSuccessModel" /> class.
        /// </summary>
        public StartProcedureToolResultSuccessModel()
        {
        }

    }
}