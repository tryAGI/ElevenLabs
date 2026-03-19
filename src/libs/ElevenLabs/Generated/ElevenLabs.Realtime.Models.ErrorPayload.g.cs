
#nullable enable

namespace ElevenLabs.Realtime
{
    /// <summary>
    /// Error event from the ElevenLabs service.
    /// </summary>
    public sealed partial class ErrorPayload
    {
        /// <summary>
        /// The error type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.Realtime.JsonConverters.ErrorPayloadMessageTypeJsonConverter))]
        public global::ElevenLabs.Realtime.ErrorPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// Type of error (e.g., auth_error, quota_exceeded, rate_limited, input_error).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorType { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorPayload" /> class.
        /// </summary>
        /// <param name="messageType">
        /// The error type identifier.
        /// </param>
        /// <param name="errorType">
        /// Type of error (e.g., auth_error, quota_exceeded, rate_limited, input_error).
        /// </param>
        /// <param name="error">
        /// Human-readable error message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorPayload(
            string errorType,
            string error,
            global::ElevenLabs.Realtime.ErrorPayloadMessageType messageType)
        {
            this.ErrorType = errorType ?? throw new global::System.ArgumentNullException(nameof(errorType));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorPayload" /> class.
        /// </summary>
        public ErrorPayload()
        {
        }
    }
}