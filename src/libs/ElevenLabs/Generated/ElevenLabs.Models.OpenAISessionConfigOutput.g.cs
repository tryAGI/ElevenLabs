
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAISessionConfigOutput
    {
        /// <summary>
        /// Default Value: realtime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: eleven_realtime_v1_mini
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RealtimeModelJsonConverter))]
        public global::ElevenLabs.RealtimeModel? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        public global::System.Collections.Generic.IList<string>? OutputModalities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::ElevenLabs.OpenAIAudioConfigOutput? Audio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem4>? Tools { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.OpenAIToolChoiceFunction>))]
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.OpenAIToolChoiceFunction>? ToolChoice { get; set; }

        /// <summary>
        /// Default Value: 0.7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Default Value: 4096
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_response_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>))]
        public global::ElevenLabs.AnyOf<int?, string>? MaxResponseOutputTokens { get; set; }

        /// <summary>
        /// Maximum wall-clock duration of the session in seconds. The session is closed with code 1000 once it is exceeded.<br/>
        /// Default Value: 600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_seconds")]
        public int? MaxDurationSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        public global::ElevenLabs.OneOf<string, global::ElevenLabs.OpenAITracingConfiguration>? Tracing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAISessionConfigOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: realtime
        /// </param>
        /// <param name="model">
        /// Default Value: eleven_realtime_v1_mini
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="outputModalities"></param>
        /// <param name="audio"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice">
        /// Default Value: auto
        /// </param>
        /// <param name="temperature">
        /// Default Value: 0.7F
        /// </param>
        /// <param name="maxResponseOutputTokens">
        /// Default Value: 4096
        /// </param>
        /// <param name="maxDurationSeconds">
        /// Maximum wall-clock duration of the session in seconds. The session is closed with code 1000 once it is exceeded.<br/>
        /// Default Value: 600
        /// </param>
        /// <param name="tracing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAISessionConfigOutput(
            string? type,
            global::ElevenLabs.RealtimeModel? model,
            string? instructions,
            global::System.Collections.Generic.IList<string>? outputModalities,
            global::ElevenLabs.OpenAIAudioConfigOutput? audio,
            global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem4>? tools,
            global::ElevenLabs.AnyOf<string, global::ElevenLabs.OpenAIToolChoiceFunction>? toolChoice,
            double? temperature,
            global::ElevenLabs.AnyOf<int?, string>? maxResponseOutputTokens,
            int? maxDurationSeconds,
            global::ElevenLabs.OneOf<string, global::ElevenLabs.OpenAITracingConfiguration>? tracing)
        {
            this.Type = type;
            this.Model = model;
            this.Instructions = instructions;
            this.OutputModalities = outputModalities;
            this.Audio = audio;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Temperature = temperature;
            this.MaxResponseOutputTokens = maxResponseOutputTokens;
            this.MaxDurationSeconds = maxDurationSeconds;
            this.Tracing = tracing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAISessionConfigOutput" /> class.
        /// </summary>
        public OpenAISessionConfigOutput()
        {
        }

    }
}