
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSettings
    {
        /// <summary>
        /// How strongly the dubbed speakers clone the source voices, 0 to 10.<br/>
        /// Default Value: 7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloning_strength")]
        public int? CloningStrength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSettings" /> class.
        /// </summary>
        /// <param name="cloningStrength">
        /// How strongly the dubbed speakers clone the source voices, 0 to 10.<br/>
        /// Default Value: 7
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceSettings(
            int? cloningStrength)
        {
            this.CloningStrength = cloningStrength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSettings" /> class.
        /// </summary>
        public VoiceSettings()
        {
        }

    }
}