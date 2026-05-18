
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"name":"Spanish Dubs"}
    /// </summary>
    public sealed partial class UpdateOrderRequest
    {
        /// <summary>
        /// The new name for the order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrderRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The new name for the order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrderRequest(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrderRequest" /> class.
        /// </summary>
        public UpdateOrderRequest()
        {
        }

    }
}