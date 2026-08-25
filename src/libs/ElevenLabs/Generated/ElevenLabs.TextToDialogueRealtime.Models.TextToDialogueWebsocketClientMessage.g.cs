
#nullable enable

namespace ElevenLabs.TextToDialogueRealtime
{
    /// <summary>
    /// All fields are optional unless noted for the **first** message.<br/>
    /// **First message requirements**<br/>
    /// - `voices`: non-empty array of voice IDs (maximum 10 for `eleven_v3`; exactly 1 for `eleven_v3_conversational`).<br/>
    /// - Credentials if not supplied via `xi-api-key` / `Authorization` headers or `single_use_token` query parameter.<br/>
    /// **Subsequent messages**<br/>
    /// - Do not resend `voices`, `pronunciation_dictionary_locators`, or credential fields.
    /// </summary>
    public sealed partial class TextToDialogueWebsocketClientMessage
    {
        /// <summary>
        /// Dialogue lines to append for synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketVoiceInput>? Inputs { get; set; }

        /// <summary>
        /// Force generation of buffered text without closing the connection.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flush")]
        public bool? Flush { get; set; }

        /// <summary>
        /// Flush buffers, emit remaining audio, send `is_final`, and close the WebSocket.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("close_socket")]
        public bool? CloseSocket { get; set; }

        /// <summary>
        /// Resets the 20s inactivity timer; performs no synthesis.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_alive")]
        public bool? KeepAlive { get; set; }

        /// <summary>
        /// API key for the first message if not provided via the `xi-api-key` header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xi_api_key")]
        public string? XiApiKey { get; set; }

        /// <summary>
        /// Bearer token for the first message if not provided via the `Authorization` header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization")]
        public string? Authorization { get; set; }

        /// <summary>
        /// Single-use token for the first message if not provided via the `single_use_token` query parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_use_token")]
        public string? SingleUseToken { get; set; }

        /// <summary>
        /// Voice IDs to load for the session (first message only, required on first message).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        public global::System.Collections.Generic.IList<string>? Voices { get; set; }

        /// <summary>
        /// Optional voice settings (first message only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_settings")]
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketVoiceSettings? VoiceSettings { get; set; }

        /// <summary>
        /// Optional pronunciation dictionaries (first message only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_locators")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueRealtime.PronunciationDictionaryLocator>? PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketClientMessage" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Dialogue lines to append for synthesis.
        /// </param>
        /// <param name="flush">
        /// Force generation of buffered text without closing the connection.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="closeSocket">
        /// Flush buffers, emit remaining audio, send `is_final`, and close the WebSocket.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keepAlive">
        /// Resets the 20s inactivity timer; performs no synthesis.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKey">
        /// API key for the first message if not provided via the `xi-api-key` header.
        /// </param>
        /// <param name="authorization">
        /// Bearer token for the first message if not provided via the `Authorization` header.
        /// </param>
        /// <param name="singleUseToken">
        /// Single-use token for the first message if not provided via the `single_use_token` query parameter.
        /// </param>
        /// <param name="voices">
        /// Voice IDs to load for the session (first message only, required on first message).
        /// </param>
        /// <param name="voiceSettings">
        /// Optional voice settings (first message only).
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// Optional pronunciation dictionaries (first message only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToDialogueWebsocketClientMessage(
            global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketVoiceInput>? inputs,
            bool? flush,
            bool? closeSocket,
            bool? keepAlive,
            string? xiApiKey,
            string? authorization,
            string? singleUseToken,
            global::System.Collections.Generic.IList<string>? voices,
            global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketVoiceSettings? voiceSettings,
            global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueRealtime.PronunciationDictionaryLocator>? pronunciationDictionaryLocators)
        {
            this.Inputs = inputs;
            this.Flush = flush;
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
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketClientMessage" /> class.
        /// </summary>
        public TextToDialogueWebsocketClientMessage()
        {
        }

    }
}