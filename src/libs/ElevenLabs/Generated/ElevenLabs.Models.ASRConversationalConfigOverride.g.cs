
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"keywords":["hello","world"]}
    /// </summary>
    public sealed partial class ASRConversationalConfigOverride
    {
        /// <summary>
        /// Keywords to boost prediction probability for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASRConversationalConfigOverride" /> class.
        /// </summary>
        /// <param name="keywords">
        /// Keywords to boost prediction probability for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASRConversationalConfigOverride(
            global::System.Collections.Generic.IList<string>? keywords)
        {
            this.Keywords = keywords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASRConversationalConfigOverride" /> class.
        /// </summary>
        public ASRConversationalConfigOverride()
        {
        }

    }
}