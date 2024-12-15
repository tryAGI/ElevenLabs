
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivacyConfig
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("record_voice")]
        public bool? RecordVoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyConfig" /> class.
        /// </summary>
        /// <param name="recordVoice">
        /// Default Value: true
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PrivacyConfig(
            bool? recordVoice)
        {
            this.RecordVoice = recordVoice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyConfig" /> class.
        /// </summary>
        public PrivacyConfig()
        {
        }
    }
}