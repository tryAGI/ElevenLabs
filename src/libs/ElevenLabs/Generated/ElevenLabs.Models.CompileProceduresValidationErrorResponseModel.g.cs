
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"errors":{"agtprc_6qbpwdq8n01bxhk44bgjy6f10ck3":[{"message":"Field required","path":"steps.0.message"}]}}
    /// </summary>
    public sealed partial class CompileProceduresValidationErrorResponseModel
    {
        /// <summary>
        /// Validation errors keyed by procedure ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureValidationError>> Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompileProceduresValidationErrorResponseModel" /> class.
        /// </summary>
        /// <param name="errors">
        /// Validation errors keyed by procedure ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompileProceduresValidationErrorResponseModel(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureValidationError>> errors)
        {
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompileProceduresValidationErrorResponseModel" /> class.
        /// </summary>
        public CompileProceduresValidationErrorResponseModel()
        {
        }

    }
}