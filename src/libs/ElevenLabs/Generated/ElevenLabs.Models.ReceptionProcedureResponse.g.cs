
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A stored procedure plus whether the receptionist can actually run it.
    /// </summary>
    public sealed partial class ReceptionProcedureResponse
    {
        /// <summary>
        /// Name of the procedure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// When the receptionist should run the procedure, in natural language. The receptionist matches caller requests against it, e.g. 'When the caller wants to book an appointment'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Trigger { get; set; }

        /// <summary>
        /// Step-by-step instructions, as markdown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// ID of the procedure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// When the procedure was created, as a Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedAtUnix { get; set; }

        /// <summary>
        /// Set when the procedure was copied from an integration's template; null for procedures you create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_key")]
        public string? SourceKey { get; set; }

        /// <summary>
        /// Tool API names the steps point at that the receptionist does not have. While non-empty the procedure is left off calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing_tools")]
        public global::System.Collections.Generic.IList<string>? MissingTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionProcedureResponse" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the procedure.
        /// </param>
        /// <param name="trigger">
        /// When the receptionist should run the procedure, in natural language. The receptionist matches caller requests against it, e.g. 'When the caller wants to book an appointment'.
        /// </param>
        /// <param name="body">
        /// Step-by-step instructions, as markdown.
        /// </param>
        /// <param name="id">
        /// ID of the procedure.
        /// </param>
        /// <param name="createdAtUnix">
        /// When the procedure was created, as a Unix timestamp in seconds.
        /// </param>
        /// <param name="sourceKey">
        /// Set when the procedure was copied from an integration's template; null for procedures you create.
        /// </param>
        /// <param name="missingTools">
        /// Tool API names the steps point at that the receptionist does not have. While non-empty the procedure is left off calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionProcedureResponse(
            string name,
            string trigger,
            string? body,
            string? id,
            global::System.DateTimeOffset? createdAtUnix,
            string? sourceKey,
            global::System.Collections.Generic.IList<string>? missingTools)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Trigger = trigger ?? throw new global::System.ArgumentNullException(nameof(trigger));
            this.Body = body;
            this.Id = id;
            this.CreatedAtUnix = createdAtUnix;
            this.SourceKey = sourceKey;
            this.MissingTools = missingTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionProcedureResponse" /> class.
        /// </summary>
        public ReceptionProcedureResponse()
        {
        }

    }
}