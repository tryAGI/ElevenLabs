
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"success":true}
    /// </summary>
    public sealed partial class RemoveOrderItemResponse
    {
        /// <summary>
        /// Whether the item was successfully removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveOrderItemResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the item was successfully removed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveOrderItemResponse(
            bool success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveOrderItemResponse" /> class.
        /// </summary>
        public RemoveOrderItemResponse()
        {
        }

    }
}