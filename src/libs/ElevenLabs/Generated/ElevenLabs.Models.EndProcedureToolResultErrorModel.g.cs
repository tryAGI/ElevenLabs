
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndProcedureToolResultErrorModel
    {
        /// <summary>
        /// Default Value: end_procedure_error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        public string? ResultType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.EndProcedureToolErrorStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.EndProcedureToolErrorStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("procedure_id")]
        public string? ProcedureId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndProcedureToolResultErrorModel" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="resultType">
        /// Default Value: end_procedure_error
        /// </param>
        /// <param name="procedureId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndProcedureToolResultErrorModel(
            global::ElevenLabs.EndProcedureToolErrorStatus status,
            string message,
            string? resultType,
            string? procedureId)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.ProcedureId = procedureId;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndProcedureToolResultErrorModel" /> class.
        /// </summary>
        public EndProcedureToolResultErrorModel()
        {
        }

    }
}