
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAISessionConfig
    {
        /// <summary>
        /// Default Value: realtime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: eleven_realtime_fast
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<string>? Modalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::ElevenLabs.OpenAIAudioConfig? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem3>? Tools { get; set; }

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        public global::System.Collections.Generic.IList<string> OutputModalities { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAISessionConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: realtime
        /// </param>
        /// <param name="model">
        /// Default Value: eleven_realtime_fast
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="modalities"></param>
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
        /// <param name="outputModalities">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAISessionConfig(
            string? type,
            string? model,
            string? instructions,
            global::System.Collections.Generic.IList<string>? modalities,
            global::ElevenLabs.OpenAIAudioConfig? audio,
            global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem3>? tools,
            global::ElevenLabs.AnyOf<string, global::ElevenLabs.OpenAIToolChoiceFunction>? toolChoice,
            double? temperature,
            global::ElevenLabs.AnyOf<int?, string>? maxResponseOutputTokens,
            global::System.Collections.Generic.IList<string> outputModalities = default!)
        {
            this.Type = type;
            this.Model = model;
            this.Instructions = instructions;
            this.Modalities = modalities;
            this.Audio = audio;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Temperature = temperature;
            this.MaxResponseOutputTokens = maxResponseOutputTokens;
            this.OutputModalities = outputModalities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAISessionConfig" /> class.
        /// </summary>
        public OpenAISessionConfig()
        {
        }

    }
}