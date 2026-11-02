
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechEngineAuthConfig
    {
        /// <summary>
        /// If true, starting a conversation with the speech engine requires a signed URL or token from an authorized caller, rather than only its ID<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_auth")]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechEngineAuthConfig" /> class.
        /// </summary>
        /// <param name="enableAuth">
        /// If true, starting a conversation with the speech engine requires a signed URL or token from an authorized caller, rather than only its ID<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechEngineAuthConfig(
            bool? enableAuth)
        {
            this.EnableAuth = enableAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechEngineAuthConfig" /> class.
        /// </summary>
        public SpeechEngineAuthConfig()
        {
        }

    }
}