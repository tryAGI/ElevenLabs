
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveElementsInput
    {
        /// <summary>
        /// Node IDs to remove.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_ids")]
        public global::System.Collections.Generic.IList<string>? NodeIds { get; set; }

        /// <summary>
        /// Connections to remove. The backend finds and clears all references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnections")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.DisconnectSpec>? Disconnections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveElementsInput" /> class.
        /// </summary>
        /// <param name="nodeIds">
        /// Node IDs to remove.
        /// </param>
        /// <param name="disconnections">
        /// Connections to remove. The backend finds and clears all references.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveElementsInput(
            global::System.Collections.Generic.IList<string>? nodeIds,
            global::System.Collections.Generic.IList<global::ElevenLabs.DisconnectSpec>? disconnections)
        {
            this.NodeIds = nodeIds;
            this.Disconnections = disconnections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveElementsInput" /> class.
        /// </summary>
        public RemoveElementsInput()
        {
        }
    }
}