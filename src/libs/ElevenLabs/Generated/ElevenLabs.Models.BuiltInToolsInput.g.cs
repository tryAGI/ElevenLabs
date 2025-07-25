
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuiltInToolsInput
    {
        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call")]
        public global::ElevenLabs.SystemToolConfigInput? EndCall { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public global::ElevenLabs.SystemToolConfigInput? LanguageDetection { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_agent")]
        public global::ElevenLabs.SystemToolConfigInput? TransferToAgent { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_number")]
        public global::ElevenLabs.SystemToolConfigInput? TransferToNumber { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_turn")]
        public global::ElevenLabs.SystemToolConfigInput? SkipTurn { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("play_keypad_touch_tone")]
        public global::ElevenLabs.SystemToolConfigInput? PlayKeypadTouchTone { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemail_detection")]
        public global::ElevenLabs.SystemToolConfigInput? VoicemailDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInToolsInput" /> class.
        /// </summary>
        /// <param name="endCall">
        /// A system tool is a tool that is used to call a system method in the server
        /// </param>
        /// <param name="languageDetection">
        /// A system tool is a tool that is used to call a system method in the server
        /// </param>
        /// <param name="transferToAgent">
        /// A system tool is a tool that is used to call a system method in the server
        /// </param>
        /// <param name="transferToNumber">
        /// A system tool is a tool that is used to call a system method in the server
        /// </param>
        /// <param name="skipTurn">
        /// A system tool is a tool that is used to call a system method in the server
        /// </param>
        /// <param name="playKeypadTouchTone">
        /// A system tool is a tool that is used to call a system method in the server
        /// </param>
        /// <param name="voicemailDetection">
        /// A system tool is a tool that is used to call a system method in the server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuiltInToolsInput(
            global::ElevenLabs.SystemToolConfigInput? endCall,
            global::ElevenLabs.SystemToolConfigInput? languageDetection,
            global::ElevenLabs.SystemToolConfigInput? transferToAgent,
            global::ElevenLabs.SystemToolConfigInput? transferToNumber,
            global::ElevenLabs.SystemToolConfigInput? skipTurn,
            global::ElevenLabs.SystemToolConfigInput? playKeypadTouchTone,
            global::ElevenLabs.SystemToolConfigInput? voicemailDetection)
        {
            this.EndCall = endCall;
            this.LanguageDetection = languageDetection;
            this.TransferToAgent = transferToAgent;
            this.TransferToNumber = transferToNumber;
            this.SkipTurn = skipTurn;
            this.PlayKeypadTouchTone = playKeypadTouchTone;
            this.VoicemailDetection = voicemailDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInToolsInput" /> class.
        /// </summary>
        public BuiltInToolsInput()
        {
        }
    }
}