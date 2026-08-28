
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Experiment membership recorded on a conversation.
    /// </summary>
    public sealed partial class ExperimentAssignment
    {
        /// <summary>
        /// Experiment key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Variant identifier: the branch id for server_branch, or the client-supplied variant for client_declared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Variant { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ExperimentAssignmentSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ExperimentAssignmentSource Source { get; set; }

        /// <summary>
        /// The AgentExperiment id, when the assignment maps to a registered experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_id")]
        public string? ExperimentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentAssignment" /> class.
        /// </summary>
        /// <param name="key">
        /// Experiment key.
        /// </param>
        /// <param name="variant">
        /// Variant identifier: the branch id for server_branch, or the client-supplied variant for client_declared.
        /// </param>
        /// <param name="source"></param>
        /// <param name="experimentId">
        /// The AgentExperiment id, when the assignment maps to a registered experiment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentAssignment(
            string key,
            string variant,
            global::ElevenLabs.ExperimentAssignmentSource source,
            string? experimentId)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Variant = variant ?? throw new global::System.ArgumentNullException(nameof(variant));
            this.Source = source;
            this.ExperimentId = experimentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentAssignment" /> class.
        /// </summary>
        public ExperimentAssignment()
        {
        }

    }
}