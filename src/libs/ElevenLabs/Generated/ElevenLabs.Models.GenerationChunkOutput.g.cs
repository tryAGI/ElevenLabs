
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationChunkOutput
    {
        /// <summary>
        /// The text config to be generated for this chunk. Can contain section name in square brackets, e.g. [Verse 1], lyrics lines, and inline directions in curly braces, e.g. {scratching}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The duration of the chunk in milliseconds. Must be between 3000ms and 120000ms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// The styles and musical directions that should be present in this chunk. Use English language for best results. The styles for the first chunk are the most important as they set the overall tone and genre. Styles for subsequent chunks can be used to add nuance, progression, emphasis, or change the direction of the song. Aim to have at least 6-7 styles in early chunks until the direction is established. Generic styles like 'great production quality' are good default styles to append to the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_styles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PositiveStyles { get; set; }

        /// <summary>
        /// The styles and musical directions that should not be present in this chunk. Use English language for best results. Leaving empty is a good default, only use this field if you want to explicitly avoid a particular style or direction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_styles")]
        public global::System.Collections.Generic.IList<string>? NegativeStyles { get; set; }

        /// <summary>
        /// How much the model adheres to the context of its surrounding chunks. Low adherence means the model can deviate from the context and be more creative. High adherence means the model will be more consistent with the context.<br/>
        /// Default Value: high
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_adherence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GenerationChunkOutputContextAdherenceJsonConverter))]
        public global::ElevenLabs.GenerationChunkOutputContextAdherence? ContextAdherence { get; set; }

        /// <summary>
        /// The audio reference to condition the generation on. The first chunk is the most important as it will influence the generation of all subsequent chunks. Thus, if you want to apply conditioning to the entire song, start conditioning from the first chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditioning_ref")]
        public global::ElevenLabs.AudioRefChunk? ConditioningRef { get; set; }

        /// <summary>
        /// How strongly the model adheres to the conditioning reference. Low strength means the model will be more creative and deviate from the reference. High strength means the model will be more consistent with the reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition_strength")]
        public global::ElevenLabs.GenerationChunkOutputConditionStrength2? ConditionStrength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationChunkOutput" /> class.
        /// </summary>
        /// <param name="text">
        /// The text config to be generated for this chunk. Can contain section name in square brackets, e.g. [Verse 1], lyrics lines, and inline directions in curly braces, e.g. {scratching}.
        /// </param>
        /// <param name="durationMs">
        /// The duration of the chunk in milliseconds. Must be between 3000ms and 120000ms.
        /// </param>
        /// <param name="positiveStyles">
        /// The styles and musical directions that should be present in this chunk. Use English language for best results. The styles for the first chunk are the most important as they set the overall tone and genre. Styles for subsequent chunks can be used to add nuance, progression, emphasis, or change the direction of the song. Aim to have at least 6-7 styles in early chunks until the direction is established. Generic styles like 'great production quality' are good default styles to append to the list.
        /// </param>
        /// <param name="negativeStyles">
        /// The styles and musical directions that should not be present in this chunk. Use English language for best results. Leaving empty is a good default, only use this field if you want to explicitly avoid a particular style or direction.
        /// </param>
        /// <param name="contextAdherence">
        /// How much the model adheres to the context of its surrounding chunks. Low adherence means the model can deviate from the context and be more creative. High adherence means the model will be more consistent with the context.<br/>
        /// Default Value: high
        /// </param>
        /// <param name="conditioningRef">
        /// The audio reference to condition the generation on. The first chunk is the most important as it will influence the generation of all subsequent chunks. Thus, if you want to apply conditioning to the entire song, start conditioning from the first chunk.
        /// </param>
        /// <param name="conditionStrength">
        /// How strongly the model adheres to the conditioning reference. Low strength means the model will be more creative and deviate from the reference. High strength means the model will be more consistent with the reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationChunkOutput(
            string text,
            int durationMs,
            global::System.Collections.Generic.IList<string> positiveStyles,
            global::System.Collections.Generic.IList<string>? negativeStyles,
            global::ElevenLabs.GenerationChunkOutputContextAdherence? contextAdherence,
            global::ElevenLabs.AudioRefChunk? conditioningRef,
            global::ElevenLabs.GenerationChunkOutputConditionStrength2? conditionStrength)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.DurationMs = durationMs;
            this.PositiveStyles = positiveStyles ?? throw new global::System.ArgumentNullException(nameof(positiveStyles));
            this.NegativeStyles = negativeStyles;
            this.ContextAdherence = contextAdherence;
            this.ConditioningRef = conditioningRef;
            this.ConditionStrength = conditionStrength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationChunkOutput" /> class.
        /// </summary>
        public GenerationChunkOutput()
        {
        }

    }
}