
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationTurn
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentOutputStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentOutputStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TextOutputItem>? Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::ElevenLabs.AgentOutputError? Error { get; set; }

        /// <summary>
        /// The actions the agent waits on. Answer each `client_tool_call` with a `client_tool_result` item in `input` to continue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_actions")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ClientToolCallRequiredAction>? RequiredActions { get; set; }

        /// <summary>
        /// Resume token for this turn's event stream. Present while the turn is in progress; pass it as Last-Event-ID to stream the turn's events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_cursor")]
        public string? StreamCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTurn" /> class.
        /// </summary>
        /// <param name="turnId"></param>
        /// <param name="status"></param>
        /// <param name="output"></param>
        /// <param name="error"></param>
        /// <param name="requiredActions">
        /// The actions the agent waits on. Answer each `client_tool_call` with a `client_tool_result` item in `input` to continue.
        /// </param>
        /// <param name="streamCursor">
        /// Resume token for this turn's event stream. Present while the turn is in progress; pass it as Last-Event-ID to stream the turn's events.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTurn(
            string turnId,
            global::ElevenLabs.AgentOutputStatus status,
            global::System.Collections.Generic.IList<global::ElevenLabs.TextOutputItem>? output,
            global::ElevenLabs.AgentOutputError? error,
            global::System.Collections.Generic.IList<global::ElevenLabs.ClientToolCallRequiredAction>? requiredActions,
            string? streamCursor)
        {
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Status = status;
            this.Output = output;
            this.Error = error;
            this.RequiredActions = requiredActions;
            this.StreamCursor = streamCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTurn" /> class.
        /// </summary>
        public ConversationTurn()
        {
        }

    }
}