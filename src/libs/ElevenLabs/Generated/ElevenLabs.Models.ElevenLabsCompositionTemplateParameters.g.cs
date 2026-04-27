
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Relaxed version of ElevenLabsCompositionParameters for saving incomplete template nodes.<br/>
    /// Allows empty tracks so a Composition node can be persisted before it is wired up.
    /// </summary>
    public sealed partial class ElevenLabsCompositionTemplateParameters
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.Track>? Tracks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsCompositionTemplateParameters" /> class.
        /// </summary>
        /// <param name="tracks">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsCompositionTemplateParameters(
            global::System.Collections.Generic.IList<global::ElevenLabs.Track>? tracks)
        {
            this.Tracks = tracks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsCompositionTemplateParameters" /> class.
        /// </summary>
        public ElevenLabsCompositionTemplateParameters()
        {
        }
    }
}