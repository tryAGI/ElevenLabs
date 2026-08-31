
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DubbingError
    {
        /// <summary>
        /// Stable identifier for the failure, safe to branch on. New codes are added over time, so we recommend treating an unrecognized value as `internal_error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable description of the failure, for display. The wording may change at any time, so we recommend branching on `code` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Whether resubmitting the same input could succeed. A value of false means the failure describes the input or the account, so an identical retry will fail the same way.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Retryable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingError" /> class.
        /// </summary>
        /// <param name="code">
        /// Stable identifier for the failure, safe to branch on. New codes are added over time, so we recommend treating an unrecognized value as `internal_error`.
        /// </param>
        /// <param name="message">
        /// Human-readable description of the failure, for display. The wording may change at any time, so we recommend branching on `code` instead.
        /// </param>
        /// <param name="retryable">
        /// Whether resubmitting the same input could succeed. A value of false means the failure describes the input or the account, so an identical retry will fail the same way.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingError(
            string code,
            string message,
            bool retryable)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Retryable = retryable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingError" /> class.
        /// </summary>
        public DubbingError()
        {
        }

    }
}