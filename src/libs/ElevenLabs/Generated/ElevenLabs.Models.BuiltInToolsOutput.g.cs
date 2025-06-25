
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuiltInToolsOutput
    {
        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call")]
        public global::ElevenLabs.SystemToolConfigOutput? EndCall { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public global::ElevenLabs.SystemToolConfigOutput? LanguageDetection { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_agent")]
        public global::ElevenLabs.SystemToolConfigOutput? TransferToAgent { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_number")]
        public global::ElevenLabs.SystemToolConfigOutput? TransferToNumber { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_turn")]
        public global::ElevenLabs.SystemToolConfigOutput? SkipTurn { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("play_keypad_touch_tone")]
        public global::ElevenLabs.SystemToolConfigOutput? PlayKeypadTouchTone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInToolsOutput" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuiltInToolsOutput(
            global::ElevenLabs.SystemToolConfigOutput? endCall,
            global::ElevenLabs.SystemToolConfigOutput? languageDetection,
            global::ElevenLabs.SystemToolConfigOutput? transferToAgent,
            global::ElevenLabs.SystemToolConfigOutput? transferToNumber,
            global::ElevenLabs.SystemToolConfigOutput? skipTurn,
            global::ElevenLabs.SystemToolConfigOutput? playKeypadTouchTone)
        {
            this.EndCall = endCall;
            this.LanguageDetection = languageDetection;
            this.TransferToAgent = transferToAgent;
            this.TransferToNumber = transferToNumber;
            this.SkipTurn = skipTurn;
            this.PlayKeypadTouchTone = playKeypadTouchTone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInToolsOutput" /> class.
        /// </summary>
        public BuiltInToolsOutput()
        {
        }
    }
}