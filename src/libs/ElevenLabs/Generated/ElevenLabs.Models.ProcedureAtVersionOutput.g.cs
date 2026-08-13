
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcedureAtVersionOutput
    {
        /// <summary>
        /// Procedure ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("procedure_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProcedureId { get; set; }

        /// <summary>
        /// Procedure name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
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
        /// Procedure content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomGuardrailConfig>? Guardrails { get; set; }

        /// <summary>
        /// Agent ID of the procedure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Version ID of a version of the procedure. None for a procedure never versioned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureAtVersionOutput" /> class.
        /// </summary>
        /// <param name="procedureId">
        /// Procedure ID
        /// </param>
        /// <param name="name">
        /// Procedure name
        /// </param>
        /// <param name="content">
        /// Procedure content
        /// </param>
        /// <param name="agentId">
        /// Agent ID of the procedure
        /// </param>
        /// <param name="type">
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
        /// <param name="guardrails"></param>
        /// <param name="versionId">
        /// Version ID of a version of the procedure. None for a procedure never versioned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcedureAtVersionOutput(
            string procedureId,
            string name,
            string content,
            string agentId,
            global::ElevenLabs.ProcedureType? type,
            string? trigger,
            global::System.Collections.Generic.IList<string>? referencedToolIds,
            global::System.Collections.Generic.IList<string>? referencedKbIds,
            global::System.Collections.Generic.IList<string>? referencedProcedureIds,
            global::System.Collections.Generic.IList<string>? referencedDynamicVariables,
            global::System.Collections.Generic.IList<global::ElevenLabs.CustomGuardrailConfig>? guardrails,
            string? versionId)
        {
            this.ProcedureId = procedureId ?? throw new global::System.ArgumentNullException(nameof(procedureId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Trigger = trigger;
            this.ReferencedToolIds = referencedToolIds;
            this.ReferencedKbIds = referencedKbIds;
            this.ReferencedProcedureIds = referencedProcedureIds;
            this.ReferencedDynamicVariables = referencedDynamicVariables;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Guardrails = guardrails;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureAtVersionOutput" /> class.
        /// </summary>
        public ProcedureAtVersionOutput()
        {
        }

    }
}