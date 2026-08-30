
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"procedure_id":"agtprc_6qbpwdq8n01bxhk44bgjy6f10ck3"}
    /// </summary>
    public sealed partial class CreateProcedureResponseModel
    {
        /// <summary>
        /// ID of the created procedure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("procedure_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProcedureId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProcedureResponseModel" /> class.
        /// </summary>
        /// <param name="procedureId">
        /// ID of the created procedure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProcedureResponseModel(
            string procedureId)
        {
            this.ProcedureId = procedureId ?? throw new global::System.ArgumentNullException(nameof(procedureId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProcedureResponseModel" /> class.
        /// </summary>
        public CreateProcedureResponseModel()
        {
        }

    }
}