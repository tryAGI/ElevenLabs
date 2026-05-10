
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechEngineConfig
    {
        /// <summary>
        /// The WebSocket URL for the transcript server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ws_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WsUrl { get; set; }

        /// <summary>
        /// Headers to include in the WebSocket connection request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechEngineConfig" /> class.
        /// </summary>
        /// <param name="wsUrl">
        /// The WebSocket URL for the transcript server
        /// </param>
        /// <param name="requestHeaders">
        /// Headers to include in the WebSocket connection request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechEngineConfig(
            string wsUrl,
            object? requestHeaders)
        {
            this.WsUrl = wsUrl ?? throw new global::System.ArgumentNullException(nameof(wsUrl));
            this.RequestHeaders = requestHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechEngineConfig" /> class.
        /// </summary>
        public SpeechEngineConfig()
        {
        }

    }
}