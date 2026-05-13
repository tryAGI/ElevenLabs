
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcedureAtVersion
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
        /// Procedure content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

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
        /// Initializes a new instance of the <see cref="ProcedureAtVersion" /> class.
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
        /// <param name="versionId">
        /// Version ID of a version of the procedure. None for a procedure never versioned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcedureAtVersion(
            string procedureId,
            string name,
            string content,
            string agentId,
            string? versionId)
        {
            this.ProcedureId = procedureId ?? throw new global::System.ArgumentNullException(nameof(procedureId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureAtVersion" /> class.
        /// </summary>
        public ProcedureAtVersion()
        {
        }

    }
}