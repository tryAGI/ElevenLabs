
#nullable enable

namespace ElevenLabs.TextToDialogueRealtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToDialogueWebsocketError
    {
        /// <summary>
        /// Human-readable error description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Machine-readable error identifier (for example `authentication_required`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// WebSocket close code that will follow this payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        /// Field name related to the error, when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error description.
        /// </param>
        /// <param name="error">
        /// Machine-readable error identifier (for example `authentication_required`).
        /// </param>
        /// <param name="code">
        /// WebSocket close code that will follow this payload.
        /// </param>
        /// <param name="param">
        /// Field name related to the error, when applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToDialogueWebsocketError(
            string message,
            string error,
            int code,
            string? param)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Code = code;
            this.Param = param;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketError" /> class.
        /// </summary>
        public TextToDialogueWebsocketError()
        {
        }

    }
}