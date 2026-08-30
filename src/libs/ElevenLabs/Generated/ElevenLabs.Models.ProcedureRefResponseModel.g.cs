
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"name":"Customer Support Procedure","procedure_id":"agtprc_6qbpwdq8n01bxhk44bgjy6f10ck3","referenced_dynamic_variables":["customer_id"],"referenced_kb_ids":["kb_123"],"referenced_procedure_ids":["agtprc_other"],"referenced_tool_ids":["tool_123"],"trigger":"When the customer asks for support","type":"free_form","version_id":"agtprcv_7rbqxer9o12cyxi55ckw6sgz1dl4"}
    /// </summary>
    public sealed partial class ProcedureRefResponseModel
    {
        /// <summary>
        /// Procedure ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("procedure_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProcedureId { get; set; }

        /// <summary>
        /// Version ID of a version of the procedure. None for a procedure never versioned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Procedure name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Procedure type<br/>
        /// Default Value: free_form
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProcedureTypeJsonConverter))]
        public global::ElevenLabs.ProcedureType? Type { get; set; }

        /// <summary>
        /// When the agent should use this procedure. Empty string means this is a sub-procedure that should only start when another procedure references it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public string? Trigger { get; set; }

        /// <summary>
        /// Tool IDs referenced in the procedure content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenced_tool_ids")]
        public global::System.Collections.Generic.IList<string>? ReferencedToolIds { get; set; }

        /// <summary>
        /// Knowledge base IDs referenced in the procedure content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenced_kb_ids")]
        public global::System.Collections.Generic.IList<string>? ReferencedKbIds { get; set; }

        /// <summary>
        /// Procedure IDs referenced in the procedure content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenced_procedure_ids")]
        public global::System.Collections.Generic.IList<string>? ReferencedProcedureIds { get; set; }

        /// <summary>
        /// Dynamic variable names used in the procedure content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenced_dynamic_variables")]
        public global::System.Collections.Generic.IList<string>? ReferencedDynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureRefResponseModel" /> class.
        /// </summary>
        /// <param name="procedureId">
        /// Procedure ID
        /// </param>
        /// <param name="versionId">
        /// Version ID of a version of the procedure. None for a procedure never versioned.
        /// </param>
        /// <param name="name">
        /// Procedure name
        /// </param>
        /// <param name="type">
        /// Procedure type<br/>
        /// Default Value: free_form
        /// </param>
        /// <param name="trigger">
        /// When the agent should use this procedure. Empty string means this is a sub-procedure that should only start when another procedure references it.
        /// </param>
        /// <param name="referencedToolIds">
        /// Tool IDs referenced in the procedure content
        /// </param>
        /// <param name="referencedKbIds">
        /// Knowledge base IDs referenced in the procedure content
        /// </param>
        /// <param name="referencedProcedureIds">
        /// Procedure IDs referenced in the procedure content
        /// </param>
        /// <param name="referencedDynamicVariables">
        /// Dynamic variable names used in the procedure content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcedureRefResponseModel(
            string procedureId,
            string? versionId,
            string? name,
            global::ElevenLabs.ProcedureType? type,
            string? trigger,
            global::System.Collections.Generic.IList<string>? referencedToolIds,
            global::System.Collections.Generic.IList<string>? referencedKbIds,
            global::System.Collections.Generic.IList<string>? referencedProcedureIds,
            global::System.Collections.Generic.IList<string>? referencedDynamicVariables)
        {
            this.ProcedureId = procedureId ?? throw new global::System.ArgumentNullException(nameof(procedureId));
            this.VersionId = versionId;
            this.Name = name;
            this.Type = type;
            this.Trigger = trigger;
            this.ReferencedToolIds = referencedToolIds;
            this.ReferencedKbIds = referencedKbIds;
            this.ReferencedProcedureIds = referencedProcedureIds;
            this.ReferencedDynamicVariables = referencedDynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureRefResponseModel" /> class.
        /// </summary>
        public ProcedureRefResponseModel()
        {
        }

    }
}