
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Parameters for ElevenLabs Speech-to-Text in Flows. Charged via STT billing, not content-generation credits.
    /// </summary>
    public sealed partial class ElevenLabsSTTParameters
    {
        /// <summary>
        /// Reference to the upstream audio or video source to transcribe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceAudio Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsSTTParameters" /> class.
        /// </summary>
        /// <param name="source">
        /// Reference to the upstream audio or video source to transcribe.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsSTTParameters(
            global::ElevenLabs.ReferenceAudio source)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsSTTParameters" /> class.
        /// </summary>
        public ElevenLabsSTTParameters()
        {
        }

    }
}