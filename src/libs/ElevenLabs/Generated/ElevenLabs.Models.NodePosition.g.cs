
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Position of a node on the canvas.
    /// </summary>
    public sealed partial class NodePosition
    {
        /// <summary>
        /// Horizontal position in pixels from the left edge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double X { get; set; }

        /// <summary>
        /// Vertical position in pixels from the top edge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePosition" /> class.
        /// </summary>
        /// <param name="x">
        /// Horizontal position in pixels from the left edge.
        /// </param>
        /// <param name="y">
        /// Vertical position in pixels from the top edge.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodePosition(
            double x,
            double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePosition" /> class.
        /// </summary>
        public NodePosition()
        {
        }
    }
}