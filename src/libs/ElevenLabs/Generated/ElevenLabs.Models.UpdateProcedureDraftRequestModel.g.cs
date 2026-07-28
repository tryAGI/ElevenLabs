
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProcedureDraftRequestModel
    {
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
        /// <default>global::ElevenLabs.ProcedureType.FreeForm</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProcedureTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ProcedureType Type { get; set; } = global::ElevenLabs.ProcedureType.FreeForm;

        /// <summary>
        /// When the agent should use this procedure. Empty string means this is a sub-procedure that should only start when another procedure references it. If omitted or null, the trigger is derived from the content instead. Also accepts `description` as an alias.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public string? Trigger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProcedureDraftRequestModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Procedure name
        /// </param>
        /// <param name="content">
        /// Procedure content
        /// </param>
        /// <param name="type">
        /// Procedure type<br/>
        /// Default Value: free_form
        /// </param>
        /// <param name="trigger">
        /// When the agent should use this procedure. Empty string means this is a sub-procedure that should only start when another procedure references it. If omitted or null, the trigger is derived from the content instead. Also accepts `description` as an alias.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProcedureDraftRequestModel(
            string name,
            string content,
            global::ElevenLabs.ProcedureType type,
            string? trigger)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
            this.Trigger = trigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProcedureDraftRequestModel" /> class.
        /// </summary>
        public UpdateProcedureDraftRequestModel()
        {
        }

    }
}