
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"procedures":[{"has_draft":false,"name":"Customer Support Procedure","procedure_id":"agtprc_6qbpwdq8n01bxhk44bgjy6f10ck3","trigger":"When the customer asks for support","type":"free_form","version_id":"agtprcv_7rbqxer9o12cyxi55ckw6sgz1dl4"}]}
    /// </summary>
    public sealed partial class ListProceduresResponseModel
    {
        /// <summary>
        /// Procedures on the branch with their draft-aware metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("procedures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureListItemResponseModel> Procedures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProceduresResponseModel" /> class.
        /// </summary>
        /// <param name="procedures">
        /// Procedures on the branch with their draft-aware metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProceduresResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureListItemResponseModel> procedures)
        {
            this.Procedures = procedures ?? throw new global::System.ArgumentNullException(nameof(procedures));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProceduresResponseModel" /> class.
        /// </summary>
        public ListProceduresResponseModel()
        {
        }

    }
}