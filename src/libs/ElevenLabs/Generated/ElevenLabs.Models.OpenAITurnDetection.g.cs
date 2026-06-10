
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAITurnDetection
    {
        /// <summary>
        /// Default Value: semantic_vad
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TurnDetectionTypeJsonConverter))]
        public global::ElevenLabs.TurnDetectionType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eagerness")]
        public global::ElevenLabs.Eagerness? Eagerness { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_response")]
        public bool? CreateResponse { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_response")]
        public bool? InterruptResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_padding_ms")]
        public int? PrefixPaddingMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_duration_ms")]
        public int? SilenceDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAITurnDetection" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: semantic_vad
        /// </param>
        /// <param name="eagerness"></param>
        /// <param name="createResponse">
        /// Default Value: true
        /// </param>
        /// <param name="interruptResponse">
        /// Default Value: true
        /// </param>
        /// <param name="threshold"></param>
        /// <param name="prefixPaddingMs"></param>
        /// <param name="silenceDurationMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAITurnDetection(
            global::ElevenLabs.TurnDetectionType? type,
            global::ElevenLabs.Eagerness? eagerness,
            bool? createResponse,
            bool? interruptResponse,
            double? threshold,
            int? prefixPaddingMs,
            int? silenceDurationMs)
        {
            this.Type = type;
            this.Eagerness = eagerness;
            this.CreateResponse = createResponse;
            this.InterruptResponse = interruptResponse;
            this.Threshold = threshold;
            this.PrefixPaddingMs = prefixPaddingMs;
            this.SilenceDurationMs = silenceDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAITurnDetection" /> class.
        /// </summary>
        public OpenAITurnDetection()
        {
        }

    }
}