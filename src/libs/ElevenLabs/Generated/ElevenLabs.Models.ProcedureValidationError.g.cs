
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcedureValidationError
    {
        /// <summary>
        /// JSON path to the error, e.g. 'trigger', 'steps[0].instruction'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Human-readable error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureValidationError" /> class.
        /// </summary>
        /// <param name="path">
        /// JSON path to the error, e.g. 'trigger', 'steps[0].instruction'
        /// </param>
        /// <param name="message">
        /// Human-readable error message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcedureValidationError(
            string path,
            string message)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureValidationError" /> class.
        /// </summary>
        public ProcedureValidationError()
        {
        }

    }
}