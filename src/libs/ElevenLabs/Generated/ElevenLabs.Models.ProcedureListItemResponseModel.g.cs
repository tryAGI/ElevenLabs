
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"has_draft":false,"name":"Customer Support Procedure","procedure_id":"agtprc_6qbpwdq8n01bxhk44bgjy6f10ck3","referenced_dynamic_variables":["customer_id"],"referenced_kb_ids":["kb_123"],"referenced_procedure_ids":["agtprc_other"],"referenced_tool_ids":["tool_123"],"trigger":"When the customer asks for support","type":"free_form","version_id":"agtprcv_7rbqxer9o12cyxi55ckw6sgz1dl4"}
    /// </summary>
    public sealed partial class ProcedureListItemResponseModel
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
        /// True when the procedure has unpublished draft changes on this branch (a newly created or edited procedure not yet published). When true, the name, type, and trigger reflect that draft.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_draft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasDraft { get; set; }

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
        /// Procedure ID of the folder this procedure is placed in. None means root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_parent_id")]
        public string? FolderParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureListItemResponseModel" /> class.
        /// </summary>
        /// <param name="procedureId">
        /// Procedure ID
        /// </param>
        /// <param name="hasDraft">
        /// True when the procedure has unpublished draft changes on this branch (a newly created or edited procedure not yet published). When true, the name, type, and trigger reflect that draft.
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
        /// <param name="folderParentId">
        /// Procedure ID of the folder this procedure is placed in. None means root.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcedureListItemResponseModel(
            string procedureId,
            bool hasDraft,
            string? versionId,
            string? name,
            global::ElevenLabs.ProcedureType? type,
            string? trigger,
            global::System.Collections.Generic.IList<string>? referencedToolIds,
            global::System.Collections.Generic.IList<string>? referencedKbIds,
            global::System.Collections.Generic.IList<string>? referencedProcedureIds,
            global::System.Collections.Generic.IList<string>? referencedDynamicVariables,
            string? folderParentId)
        {
            this.ProcedureId = procedureId ?? throw new global::System.ArgumentNullException(nameof(procedureId));
            this.VersionId = versionId;
            this.Name = name;
            this.Type = type;
            this.Trigger = trigger;
            this.HasDraft = hasDraft;
            this.ReferencedToolIds = referencedToolIds;
            this.ReferencedKbIds = referencedKbIds;
            this.ReferencedProcedureIds = referencedProcedureIds;
            this.ReferencedDynamicVariables = referencedDynamicVariables;
            this.FolderParentId = folderParentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureListItemResponseModel" /> class.
        /// </summary>
        public ProcedureListItemResponseModel()
        {
        }

    }
}