
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReceptionUpdateProductRequestPatch
    {
        /// <summary>
        /// 'fixed' (default): the item has a known price the agent can quote, and customers can book or order it directly. 'quote': the price depends on the job (renovation, catering, custom work), so no price or slot is offered; the agent collects the intake_questions and files a quote request instead. Takes effect only while quotes are enabled for the business. Group services cannot use 'quote'.<br/>
        /// Default Value: fixed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PricingModeJsonConverter))]
        public global::ElevenLabs.PricingMode? PricingMode { get; set; }

        /// <summary>
        /// Questions the agent asks before booking or ordering this item. Required for a useful `pricing_mode='quote'` item -- without them a quote request arrives with nothing to price -- but also valid on fixed-price items that need extra detail (current hair color before a dye job, allergies before a treatment).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intake_questions")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionIntakeQuestion>? IntakeQuestions { get; set; }

        /// <summary>
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionGroupMembership>? Groups { get; set; }

        /// <summary>
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ungrouped_rank")]
        public int? UngroupedRank { get; set; }

        /// <summary>
        /// Name of the product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Price of the product; null for no listed price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// False hides the product without deleting it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// False keeps the product listed (callers can ask about it) but not orderable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderable")]
        public bool? Orderable { get; set; }

        /// <summary>
        /// Fulfillment options customers may choose when ordering this product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_fulfillment_types")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderFulfillmentType>? AllowedFulfillmentTypes { get; set; }

        /// <summary>
        /// Locations where this product is sold; empty list means all locations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location_ids")]
        public global::System.Collections.Generic.IList<string>? LocationIds { get; set; }

        /// <summary>
        /// Whether this product is counted. Switching it only changes the mode: turning it on keeps whatever is already on hand, turning it off drops the counts. Use the stock endpoints to change the amounts themselves.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_quantity")]
        public bool? TrackQuantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionUpdateProductRequestPatch" /> class.
        /// </summary>
        /// <param name="pricingMode">
        /// 'fixed' (default): the item has a known price the agent can quote, and customers can book or order it directly. 'quote': the price depends on the job (renovation, catering, custom work), so no price or slot is offered; the agent collects the intake_questions and files a quote request instead. Takes effect only while quotes are enabled for the business. Group services cannot use 'quote'.<br/>
        /// Default Value: fixed
        /// </param>
        /// <param name="intakeQuestions">
        /// Questions the agent asks before booking or ordering this item. Required for a useful `pricing_mode='quote'` item -- without them a quote request arrives with nothing to price -- but also valid on fixed-price items that need extra detail (current hair color before a dye job, allergies before a treatment).
        /// </param>
        /// <param name="groups">
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </param>
        /// <param name="ungroupedRank">
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </param>
        /// <param name="name">
        /// Name of the product.
        /// </param>
        /// <param name="description">
        /// Description of the product.
        /// </param>
        /// <param name="price">
        /// Price of the product; null for no listed price.
        /// </param>
        /// <param name="isActive">
        /// False hides the product without deleting it.
        /// </param>
        /// <param name="orderable">
        /// False keeps the product listed (callers can ask about it) but not orderable.
        /// </param>
        /// <param name="allowedFulfillmentTypes">
        /// Fulfillment options customers may choose when ordering this product.
        /// </param>
        /// <param name="locationIds">
        /// Locations where this product is sold; empty list means all locations.
        /// </param>
        /// <param name="trackQuantity">
        /// Whether this product is counted. Switching it only changes the mode: turning it on keeps whatever is already on hand, turning it off drops the counts. Use the stock endpoints to change the amounts themselves.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionUpdateProductRequestPatch(
            global::ElevenLabs.PricingMode? pricingMode,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionIntakeQuestion>? intakeQuestions,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionGroupMembership>? groups,
            int? ungroupedRank,
            string? name,
            string? description,
            double? price,
            bool? isActive,
            bool? orderable,
            global::System.Collections.Generic.IList<global::ElevenLabs.OrderFulfillmentType>? allowedFulfillmentTypes,
            global::System.Collections.Generic.IList<string>? locationIds,
            bool? trackQuantity)
        {
            this.PricingMode = pricingMode;
            this.IntakeQuestions = intakeQuestions;
            this.Groups = groups;
            this.UngroupedRank = ungroupedRank;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.IsActive = isActive;
            this.Orderable = orderable;
            this.AllowedFulfillmentTypes = allowedFulfillmentTypes;
            this.LocationIds = locationIds;
            this.TrackQuantity = trackQuantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionUpdateProductRequestPatch" /> class.
        /// </summary>
        public ReceptionUpdateProductRequestPatch()
        {
        }

    }
}