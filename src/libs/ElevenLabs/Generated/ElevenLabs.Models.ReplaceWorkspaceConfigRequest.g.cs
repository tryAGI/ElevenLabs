
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReplaceWorkspaceConfigRequest
    {
        /// <summary>
        /// The `version` of the configuration being replaced. Omit it only to create the first configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_version")]
        public int? ExpectedVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CampaignConfigInput Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceWorkspaceConfigRequest" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="expectedVersion">
        /// The `version` of the configuration being replaced. Omit it only to create the first configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceWorkspaceConfigRequest(
            global::ElevenLabs.CampaignConfigInput config,
            int? expectedVersion)
        {
            this.ExpectedVersion = expectedVersion;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceWorkspaceConfigRequest" /> class.
        /// </summary>
        public ReplaceWorkspaceConfigRequest()
        {
        }

    }
}