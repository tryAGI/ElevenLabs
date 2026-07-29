
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplicateVoiceToIsolatedEnvironmentRequestModel
    {
        /// <summary>
        /// ID of the workspace to replicate the voice into. It must belong to the same consolidated billing group as the calling workspace; the target's data residency is derived from that link.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetWorkspaceId { get; set; }

        /// <summary>
        /// When true (default) the replicated voice keeps the same voice ID in the target residency; set to false to assign a new voice ID.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_voice_id")]
        public bool? PreserveVoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicateVoiceToIsolatedEnvironmentRequestModel" /> class.
        /// </summary>
        /// <param name="targetWorkspaceId">
        /// ID of the workspace to replicate the voice into. It must belong to the same consolidated billing group as the calling workspace; the target's data residency is derived from that link.
        /// </param>
        /// <param name="preserveVoiceId">
        /// When true (default) the replicated voice keeps the same voice ID in the target residency; set to false to assign a new voice ID.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicateVoiceToIsolatedEnvironmentRequestModel(
            string targetWorkspaceId,
            bool? preserveVoiceId)
        {
            this.TargetWorkspaceId = targetWorkspaceId ?? throw new global::System.ArgumentNullException(nameof(targetWorkspaceId));
            this.PreserveVoiceId = preserveVoiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicateVoiceToIsolatedEnvironmentRequestModel" /> class.
        /// </summary>
        public ReplicateVoiceToIsolatedEnvironmentRequestModel()
        {
        }

    }
}