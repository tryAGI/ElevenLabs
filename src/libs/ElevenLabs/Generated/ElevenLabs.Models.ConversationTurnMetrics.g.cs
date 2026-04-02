
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationTurnMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.MetricRecord>? Metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_asr_provider")]
        public string? ConvaiAsrProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_tts_model")]
        public string? ConvaiTtsModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_tts_cascade")]
        public string? ConvaiTtsCascade { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTurnMetrics" /> class.
        /// </summary>
        /// <param name="metrics"></param>
        /// <param name="convaiAsrProvider"></param>
        /// <param name="convaiTtsModel"></param>
        /// <param name="convaiTtsCascade"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTurnMetrics(
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.MetricRecord>? metrics,
            string? convaiAsrProvider,
            string? convaiTtsModel,
            string? convaiTtsCascade)
        {
            this.Metrics = metrics;
            this.ConvaiAsrProvider = convaiAsrProvider;
            this.ConvaiTtsModel = convaiTtsModel;
            this.ConvaiTtsCascade = convaiTtsCascade;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTurnMetrics" /> class.
        /// </summary>
        public ConversationTurnMetrics()
        {
        }
    }
}