
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MoveNodesInput
    {
        /// <summary>
        /// List of node moves.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moves")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.MoveSpec> Moves { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveNodesInput" /> class.
        /// </summary>
        /// <param name="moves">
        /// List of node moves.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MoveNodesInput(
            global::System.Collections.Generic.IList<global::ElevenLabs.MoveSpec> moves)
        {
            this.Moves = moves ?? throw new global::System.ArgumentNullException(nameof(moves));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveNodesInput" /> class.
        /// </summary>
        public MoveNodesInput()
        {
        }
    }
}