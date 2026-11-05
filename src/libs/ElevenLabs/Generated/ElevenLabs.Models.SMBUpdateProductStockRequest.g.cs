
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SMBUpdateProductStockRequest
    {
        /// <summary>
        /// Location whose count is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LocationId { get; set; }

        /// <summary>
        /// The new on-hand quantity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_hand")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OnHand { get; set; }

        /// <summary>
        /// On-hand value the caller last saw. The write is rejected with a 409 if it no longer matches, so a sale made while the caller was editing is never overwritten.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_on_hand")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpectedOnHand { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBUpdateProductStockRequest" /> class.
        /// </summary>
        /// <param name="locationId">
        /// Location whose count is set.
        /// </param>
        /// <param name="onHand">
        /// The new on-hand quantity.
        /// </param>
        /// <param name="expectedOnHand">
        /// On-hand value the caller last saw. The write is rejected with a 409 if it no longer matches, so a sale made while the caller was editing is never overwritten.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBUpdateProductStockRequest(
            string locationId,
            int onHand,
            int expectedOnHand)
        {
            this.LocationId = locationId ?? throw new global::System.ArgumentNullException(nameof(locationId));
            this.OnHand = onHand;
            this.ExpectedOnHand = expectedOnHand;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBUpdateProductStockRequest" /> class.
        /// </summary>
        public SMBUpdateProductStockRequest()
        {
        }

    }
}