
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StreamEndedData
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::ElevenLabs.AgentOutputError? Error { get; set; }

        /// <summary>
        /// The actions the agent waits on. Answer each `client_tool_call` with a `client_tool_result` item in `input` to continue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_actions")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ClientToolCallRequiredAction>? RequiredActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEndedData" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="error"></param>
        /// <param name="requiredActions">
        /// The actions the agent waits on. Answer each `client_tool_call` with a `client_tool_result` item in `input` to continue.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamEndedData(
            global::ElevenLabs.AgentOutputStatus status,
            global::ElevenLabs.AgentOutputError? error,
            global::System.Collections.Generic.IList<global::ElevenLabs.ClientToolCallRequiredAction>? requiredActions)
        {
            this.Status = status;
            this.Error = error;
            this.RequiredActions = requiredActions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEndedData" /> class.
        /// </summary>
        public StreamEndedData()
        {
        }

    }
}