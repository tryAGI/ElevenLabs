
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JudgeGenerationInput
    {
        /// <summary>
        /// Node IDs whose latest completed generation should be evaluated. Pass multiple IDs for cross-output consistency scoring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NodeIds { get; set; }

        /// <summary>
        /// What the user wants from these outputs — restate the creative brief, not the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_intent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserIntent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JudgeGenerationInput" /> class.
        /// </summary>
        /// <param name="nodeIds">
        /// Node IDs whose latest completed generation should be evaluated. Pass multiple IDs for cross-output consistency scoring.
        /// </param>
        /// <param name="userIntent">
        /// What the user wants from these outputs — restate the creative brief, not the prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JudgeGenerationInput(
            global::System.Collections.Generic.IList<string> nodeIds,
            string userIntent)
        {
            this.NodeIds = nodeIds ?? throw new global::System.ArgumentNullException(nameof(nodeIds));
            this.UserIntent = userIntent ?? throw new global::System.ArgumentNullException(nameof(userIntent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JudgeGenerationInput" /> class.
        /// </summary>
        public JudgeGenerationInput()
        {
        }
    }
}