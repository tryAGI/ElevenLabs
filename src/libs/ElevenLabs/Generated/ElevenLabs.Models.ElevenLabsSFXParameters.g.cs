
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Parameters for ElevenLabs SFX in templates.
    /// </summary>
    public sealed partial class ElevenLabsSFXParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// How strongly the prompt guides the output (0=loose, 1=strict).<br/>
        /// Default Value: 0.3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_influence")]
        public double? PromptInfluence { get; set; }

        /// <summary>
        /// Whether to generate a seamlessly looping sound effect.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loop")]
        public bool? Loop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsSFXParameters" /> class.
        /// </summary>
        /// <param name="durationSeconds"></param>
        /// <param name="promptInfluence">
        /// How strongly the prompt guides the output (0=loose, 1=strict).<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="loop">
        /// Whether to generate a seamlessly looping sound effect.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsSFXParameters(
            double? durationSeconds,
            double? promptInfluence,
            bool? loop)
        {
            this.DurationSeconds = durationSeconds;
            this.PromptInfluence = promptInfluence;
            this.Loop = loop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsSFXParameters" /> class.
        /// </summary>
        public ElevenLabsSFXParameters()
        {
        }
    }
}