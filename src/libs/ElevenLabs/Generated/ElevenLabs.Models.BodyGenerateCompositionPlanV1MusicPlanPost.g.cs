
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyGenerateCompositionPlanV1MusicPlanPost
    {
        /// <summary>
        /// A simple text prompt to compose a plan from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// The length of the composition plan to generate in milliseconds. Must be between 10000ms and 300000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_length_ms")]
        public int? MusicLengthMs { get; set; }

        /// <summary>
        /// Example: {"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]}
        /// </summary>
        /// <example>{"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_composition_plan")]
        public global::ElevenLabs.MusicPrompt? SourceCompositionPlan { get; set; }

        /// <summary>
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdJsonConverter))]
        public global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPostModelId? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGenerateCompositionPlanV1MusicPlanPost" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A simple text prompt to compose a plan from.
        /// </param>
        /// <param name="musicLengthMs">
        /// The length of the composition plan to generate in milliseconds. Must be between 10000ms and 300000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </param>
        /// <param name="sourceCompositionPlan">
        /// Example: {"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]}
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyGenerateCompositionPlanV1MusicPlanPost(
            string prompt,
            int? musicLengthMs,
            global::ElevenLabs.MusicPrompt? sourceCompositionPlan,
            global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPostModelId? modelId)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.MusicLengthMs = musicLengthMs;
            this.SourceCompositionPlan = sourceCompositionPlan;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGenerateCompositionPlanV1MusicPlanPost" /> class.
        /// </summary>
        public BodyGenerateCompositionPlanV1MusicPlanPost()
        {
        }
    }
}