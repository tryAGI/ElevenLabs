
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Scrape-reachable subset of a product (retail/catalog item).
    /// </summary>
    public sealed partial class SMBProductScrapable
    {
        /// <summary>
        /// 'fixed' (default): the item has a known price the agent can quote, and customers can book or order it directly. 'quote': the price depends on the job (renovation, catering, custom work), so no price or slot is offered; the agent collects the intake_questions and files a quote request instead. Takes effect only while quotes are enabled for the business. Group services cannot use 'quote'.<br/>
        /// Default Value: fixed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PricingModeJsonConverter))]
        public global::ElevenLabs.PricingMode? PricingMode { get; set; }

        /// <summary>
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBGroupMembership>? Groups { get; set; }

        /// <summary>
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ungrouped_rank")]
        public int? UngroupedRank { get; set; }

        /// <summary>
        /// Name of the product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBProductScrapable" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the product.
        /// </param>
        /// <param name="pricingMode">
        /// 'fixed' (default): the item has a known price the agent can quote, and customers can book or order it directly. 'quote': the price depends on the job (renovation, catering, custom work), so no price or slot is offered; the agent collects the intake_questions and files a quote request instead. Takes effect only while quotes are enabled for the business. Group services cannot use 'quote'.<br/>
        /// Default Value: fixed
        /// </param>
        /// <param name="groups">
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </param>
        /// <param name="ungroupedRank">
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </param>
        /// <param name="description">
        /// Description of the product.
        /// </param>
        /// <param name="price">
        /// Price of the product; null for no listed price.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBProductScrapable(
            string name,
            global::ElevenLabs.PricingMode? pricingMode,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBGroupMembership>? groups,
            int? ungroupedRank,
            string? description,
            double? price)
        {
            this.PricingMode = pricingMode;
            this.Groups = groups;
            this.UngroupedRank = ungroupedRank;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBProductScrapable" /> class.
        /// </summary>
        public SMBProductScrapable()
        {
        }

    }
}