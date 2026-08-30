
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Composition plan for the `music_v2` model. Using this field with any other model will result in an error.<br/>
    /// Example: {"chunks":[{"duration_ms":15000,"positive_styles":["pop","warm synths","steady groove","layered harmonies"],"text":"[Verse]\nCity lights are fading\nWe keep moving through the night"},{"duration_ms":15000,"positive_styles":["uplifting","bigger drums","wide vocals"],"text":"[Chorus]\nHold on to the feeling\n{very loud}Let it rise and come alive"},{"duration_ms":5000,"positive_styles":["gentle ending","soft pads"],"text":"[Instrumental Outro]"}]}
    /// </summary>
    public sealed partial class CompositionPlan
    {
        /// <summary>
        /// The chunks that make up the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>> Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositionPlan" /> class.
        /// </summary>
        /// <param name="chunks">
        /// The chunks that make up the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompositionPlan(
            global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>> chunks)
        {
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositionPlan" /> class.
        /// </summary>
        public CompositionPlan()
        {
        }

    }
}