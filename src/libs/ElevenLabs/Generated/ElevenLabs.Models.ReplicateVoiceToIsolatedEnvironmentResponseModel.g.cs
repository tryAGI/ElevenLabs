
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"voice_id":"21m00Tcm4TlvDq8ikWAM"}
    /// </summary>
    public sealed partial class ReplicateVoiceToIsolatedEnvironmentResponseModel
    {
        /// <summary>
        /// Voice ID of the replicated voice in the target residency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicateVoiceToIsolatedEnvironmentResponseModel" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID of the replicated voice in the target residency.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicateVoiceToIsolatedEnvironmentResponseModel(
            string voiceId)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicateVoiceToIsolatedEnvironmentResponseModel" /> class.
        /// </summary>
        public ReplicateVoiceToIsolatedEnvironmentResponseModel()
        {
        }

    }
}