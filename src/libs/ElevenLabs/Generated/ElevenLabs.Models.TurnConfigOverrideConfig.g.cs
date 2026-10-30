
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TurnConfigOverrideConfig
    {
        /// <summary>
        /// Configures overrides for nested fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_timeout_config")]
        public global::ElevenLabs.SoftTimeoutConfigOverrideConfig? SoftTimeoutConfig { get; set; }

        /// <summary>
        /// Whether to allow overriding the noisy_environment_message field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noisy_environment_message")]
        public bool? NoisyEnvironmentMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfigOverrideConfig" /> class.
        /// </summary>
        /// <param name="softTimeoutConfig">
        /// Configures overrides for nested fields.
        /// </param>
        /// <param name="noisyEnvironmentMessage">
        /// Whether to allow overriding the noisy_environment_message field.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurnConfigOverrideConfig(
            global::ElevenLabs.SoftTimeoutConfigOverrideConfig? softTimeoutConfig,
            bool? noisyEnvironmentMessage)
        {
            this.SoftTimeoutConfig = softTimeoutConfig;
            this.NoisyEnvironmentMessage = noisyEnvironmentMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfigOverrideConfig" /> class.
        /// </summary>
        public TurnConfigOverrideConfig()
        {
        }

    }
}