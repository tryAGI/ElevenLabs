
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"content":"# Customer Support Procedure\n\n1. Greet the customer...","name":"Customer Support Procedure","procedure_id":"agtprc_6qbpwdq8n01bxhk44bgjy6f10ck3","trigger":"When the customer asks for support","type":"free_form","version_id":"agtprcv_7rbqxer9o12cyxi55ckw6sgz1dl4"}
    /// </summary>
    public sealed partial class ProcedureAtVersionResponseModel
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Procedure content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureAtVersionResponseModel" /> class.
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
        /// <param name="versionId">
        /// Version ID of a version of the procedure. None for a procedure never versioned.
        /// </param>
        /// <param name="type">
        /// Procedure type<br/>
        /// Default Value: free_form
        /// </param>
        /// <param name="trigger">
        /// When the agent should use this procedure. Empty string means this is a sub-procedure that should only start when another procedure references it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcedureAtVersionResponseModel(
            string procedureId,
            string name,
            string content,
            string? versionId,
            global::ElevenLabs.ProcedureType? type,
            string? trigger)
        {
            this.ProcedureId = procedureId ?? throw new global::System.ArgumentNullException(nameof(procedureId));
            this.VersionId = versionId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
            this.Trigger = trigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureAtVersionResponseModel" /> class.
        /// </summary>
        public ProcedureAtVersionResponseModel()
        {
        }

    }
}