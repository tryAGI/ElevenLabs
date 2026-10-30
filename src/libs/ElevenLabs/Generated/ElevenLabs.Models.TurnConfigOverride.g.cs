
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"soft_timeout_config":{"message":"Hhmmmm...yeah."}}
    /// </summary>
    public sealed partial class TurnConfigOverride
    {
        /// <summary>
        /// Configuration for soft timeout functionality. Provides immediate feedback during longer LLM responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_timeout_config")]
        public global::ElevenLabs.SoftTimeoutConfigOverride? SoftTimeoutConfig { get; set; }

        /// <summary>
        /// What the agent says when it detects a noisy environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noisy_environment_message")]
        public string? NoisyEnvironmentMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfigOverride" /> class.
        /// </summary>
        /// <param name="softTimeoutConfig">
        /// Configuration for soft timeout functionality. Provides immediate feedback during longer LLM responses.
        /// </param>
        /// <param name="noisyEnvironmentMessage">
        /// What the agent says when it detects a noisy environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurnConfigOverride(
            global::ElevenLabs.SoftTimeoutConfigOverride? softTimeoutConfig,
            string? noisyEnvironmentMessage)
        {
            this.SoftTimeoutConfig = softTimeoutConfig;
            this.NoisyEnvironmentMessage = noisyEnvironmentMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfigOverride" /> class.
        /// </summary>
        public TurnConfigOverride()
        {
        }

    }
}