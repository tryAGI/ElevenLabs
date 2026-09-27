
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An error returned in place of an edited transcript when the edit could not be produced.
    /// </summary>
    public sealed partial class TranscriptEditError
    {
        /// <summary>
        /// Default Value: error
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string Kind { get; set; } = "error";

        /// <summary>
        /// edit_failed: the edit could not be produced.
        /// </summary>
        /// <default>"edit_failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        public string ErrorType { get; set; } = "edit_failed";

        /// <summary>
        /// A short, user-facing explanation of the failure.
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
        /// Initializes a new instance of the <see cref="TranscriptEditError" /> class.
        /// </summary>
        /// <param name="message">
        /// A short, user-facing explanation of the failure.
        /// </param>
        /// <param name="kind">
        /// Default Value: error
        /// </param>
        /// <param name="errorType">
        /// edit_failed: the edit could not be produced.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptEditError(
            string message,
            string kind = "error",
            string errorType = "edit_failed")
        {
            this.Kind = kind;
            this.ErrorType = errorType;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptEditError" /> class.
        /// </summary>
        public TranscriptEditError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TranscriptEditError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TranscriptEditError FromMessage(string message)
        {
            return new TranscriptEditError
            {
                Message = message,
            };
        }

    }
}