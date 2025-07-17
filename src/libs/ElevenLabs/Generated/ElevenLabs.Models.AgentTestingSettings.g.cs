
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Settings for agent testing configuration.
    /// </summary>
    public sealed partial class AgentTestingSettings
    {
        /// <summary>
        /// List of test IDs that should be run for this agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_ids")]
        public global::System.Collections.Generic.IList<string>? TestIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestingSettings" /> class.
        /// </summary>
        /// <param name="testIds">
        /// List of test IDs that should be run for this agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestingSettings(
            global::System.Collections.Generic.IList<string>? testIds)
        {
            this.TestIds = testIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestingSettings" /> class.
        /// </summary>
        public AgentTestingSettings()
        {
        }
    }
}