
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASRConversationalConfigOverrideConfig
    {
        /// <summary>
        /// Whether to allow overriding the keywords field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public bool? Keywords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASRConversationalConfigOverrideConfig" /> class.
        /// </summary>
        /// <param name="keywords">
        /// Whether to allow overriding the keywords field.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASRConversationalConfigOverrideConfig(
            bool? keywords)
        {
            this.Keywords = keywords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASRConversationalConfigOverrideConfig" /> class.
        /// </summary>
        public ASRConversationalConfigOverrideConfig()
        {
        }

    }
}