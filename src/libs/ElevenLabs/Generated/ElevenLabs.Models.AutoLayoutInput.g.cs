
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoLayoutInput
    {
        /// <summary>
        /// Node IDs to arrange.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NodeIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoLayoutInput" /> class.
        /// </summary>
        /// <param name="nodeIds">
        /// Node IDs to arrange.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoLayoutInput(
            global::System.Collections.Generic.IList<string> nodeIds)
        {
            this.NodeIds = nodeIds ?? throw new global::System.ArgumentNullException(nameof(nodeIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoLayoutInput" /> class.
        /// </summary>
        public AutoLayoutInput()
        {
        }
    }
}