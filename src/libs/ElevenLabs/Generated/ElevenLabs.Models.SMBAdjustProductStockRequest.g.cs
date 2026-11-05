
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SMBAdjustProductStockRequest
    {
        /// <summary>
        /// Location whose count changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LocationId { get; set; }

        /// <summary>
        /// Signed change to apply to on-hand. Prefer this over an absolute write whenever the intent is 'a few more/fewer'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBAdjustProductStockRequest" /> class.
        /// </summary>
        /// <param name="locationId">
        /// Location whose count changes.
        /// </param>
        /// <param name="delta">
        /// Signed change to apply to on-hand. Prefer this over an absolute write whenever the intent is 'a few more/fewer'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBAdjustProductStockRequest(
            string locationId,
            int delta)
        {
            this.LocationId = locationId ?? throw new global::System.ArgumentNullException(nameof(locationId));
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBAdjustProductStockRequest" /> class.
        /// </summary>
        public SMBAdjustProductStockRequest()
        {
        }

    }
}