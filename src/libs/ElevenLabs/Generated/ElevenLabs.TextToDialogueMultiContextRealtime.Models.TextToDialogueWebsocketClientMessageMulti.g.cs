
#nullable enable

namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    /// <summary>
    /// All fields are optional unless noted for a context's **first** message.<br/>
    /// **Every message**<br/>
    /// - `context_id` is required, except on a message containing only `close_socket`.<br/>
    /// **First message for a context**<br/>
    /// - `voices`: non-empty array of voice IDs (maximum 10 per context for `eleven_v3`; exactly 1 for `eleven_v3_conversational`).<br/>
    /// - Credentials if not supplied via `xi-api-key` / `Authorization` headers or `single_use_token` query parameter (accepted on the first message of the connection only).<br/>
    /// **Subsequent messages for a context**<br/>
    /// - Do not resend `voices`, `voice_settings`, `pronunciation_dictionary_locators`, or credential fields.
    /// </summary>
    public sealed partial class TextToDialogueWebsocketClientMessageMulti
    {
        /// <summary>
        /// Identifier for an independent dialogue stream within the socket. The first message with a new `context_id` creates that context. Required on every message except one containing only `close_socket`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        public string? ContextId { get; set; }

        /// <summary>
        /// Dialogue lines to append to this context for synthesis. Each `voice_id` must be registered for this context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketVoiceInput>? Inputs { get; set; }

        /// <summary>
        /// Force generation of this context's buffered text without closing it.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flush")]
        public bool? Flush { get; set; }

        /// <summary>
        /// Flush this context's remaining audio, emit its `is_final` message, and close it. Other contexts stay open.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("close_context")]
        public bool? CloseContext { get; set; }

        /// <summary>
        /// Flush all contexts, emit their remaining audio and `is_final` messages, and close the WebSocket.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("close_socket")]
        public bool? CloseSocket { get; set; }

        /// <summary>
        /// Resets this context's 20s inactivity timer; performs no synthesis.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_alive")]
        public bool? KeepAlive { get; set; }

        /// <summary>
        /// API key for the first message of the connection if not provided via the `xi-api-key` header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xi_api_key")]
        public string? XiApiKey { get; set; }

        /// <summary>
        /// Bearer token for the first message of the connection if not provided via the `Authorization` header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization")]
        public string? Authorization { get; set; }

        /// <summary>
        /// Single-use token for the first message of the connection if not provided via the `single_use_token` query parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_use_token")]
        public string? SingleUseToken { get; set; }

        /// <summary>
        /// Voice IDs to load for this context (first message for the context only, required on that message).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        public global::System.Collections.Generic.IList<string>? Voices { get; set; }

        /// <summary>
        /// Optional voice settings for this context (first message for the context only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_settings")]
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketVoiceSettings? VoiceSettings { get; set; }

        /// <summary>
        /// Optional pronunciation dictionaries for this context (first message for the context only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_locators")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueMultiContextRealtime.PronunciationDictionaryLocator>? PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketClientMessageMulti" /> class.
        /// </summary>
        /// <param name="contextId">
        /// Identifier for an independent dialogue stream within the socket. The first message with a new `context_id` creates that context. Required on every message except one containing only `close_socket`.
        /// </param>
        /// <param name="inputs">
        /// Dialogue lines to append to this context for synthesis. Each `voice_id` must be registered for this context.
        /// </param>
        /// <param name="flush">
        /// Force generation of this context's buffered text without closing it.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="closeContext">
        /// Flush this context's remaining audio, emit its `is_final` message, and close it. Other contexts stay open.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="closeSocket">
        /// Flush all contexts, emit their remaining audio and `is_final` messages, and close the WebSocket.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keepAlive">
        /// Resets this context's 20s inactivity timer; performs no synthesis.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKey">
        /// API key for the first message of the connection if not provided via the `xi-api-key` header.
        /// </param>
        /// <param name="authorization">
        /// Bearer token for the first message of the connection if not provided via the `Authorization` header.
        /// </param>
        /// <param name="singleUseToken">
        /// Single-use token for the first message of the connection if not provided via the `single_use_token` query parameter.
        /// </param>
        /// <param name="voices">
        /// Voice IDs to load for this context (first message for the context only, required on that message).
        /// </param>
        /// <param name="voiceSettings">
        /// Optional voice settings for this context (first message for the context only).
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// Optional pronunciation dictionaries for this context (first message for the context only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToDialogueWebsocketClientMessageMulti(
            string? contextId,
            global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketVoiceInput>? inputs,
            bool? flush,
            bool? closeContext,
            bool? closeSocket,
            bool? keepAlive,
            string? xiApiKey,
            string? authorization,
            string? singleUseToken,
            global::System.Collections.Generic.IList<string>? voices,
            global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketVoiceSettings? voiceSettings,
            global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueMultiContextRealtime.PronunciationDictionaryLocator>? pronunciationDictionaryLocators)
        {
            this.ContextId = contextId;
            this.Inputs = inputs;
            this.Flush = flush;
            this.CloseContext = closeContext;
            this.CloseSocket = closeSocket;
            this.KeepAlive = keepAlive;
            this.XiApiKey = xiApiKey;
            this.Authorization = authorization;
            this.SingleUseToken = singleUseToken;
            this.Voices = voices;
            this.VoiceSettings = voiceSettings;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketClientMessageMulti" /> class.
        /// </summary>
        public TextToDialogueWebsocketClientMessageMulti()
        {
        }

    }
}