
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"deliverables":[{"content_type":"video/mp4","name":"output_fr.mp4","signed_url":"https://storage.googleapis.com/example-bucket/deliverables/output_fr.mp4?X-Goog-Signature=...","version":1}]}
    /// </summary>
    public sealed partial class OrderDeliverablesResponse
    {
        /// <summary>
        /// The list of delivered files for the order. Empty if the order is not yet completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliverables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.DeliverableInfo> Deliverables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDeliverablesResponse" /> class.
        /// </summary>
        /// <param name="deliverables">
        /// The list of delivered files for the order. Empty if the order is not yet completed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderDeliverablesResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.DeliverableInfo> deliverables)
        {
            this.Deliverables = deliverables ?? throw new global::System.ArgumentNullException(nameof(deliverables));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDeliverablesResponse" /> class.
        /// </summary>
        public OrderDeliverablesResponse()
        {
        }

    }
}