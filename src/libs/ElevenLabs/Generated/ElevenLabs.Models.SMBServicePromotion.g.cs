
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A time-bound promotion on a service/variant or on add-ons.
    /// </summary>
    public sealed partial class SMBServicePromotion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether this promotion targets the service/variant price or add-on prices.<br/>
        /// Default Value: service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PromotionTargetJsonConverter))]
        public global::ElevenLabs.PromotionTarget? Target { get; set; }

        /// <summary>
        /// When set (target=service), the promotion applies only to this variant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant_id")]
        public string? VariantId { get; set; }

        /// <summary>
        /// When set (target=add_on), the promotion applies only to this add-on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_on_id")]
        public string? AddOnId { get; set; }

        /// <summary>
        /// The final price when this promotion is applied to a matching line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotional_price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromotionalPrice { get; set; }

        /// <summary>
        /// Days when the promotion is active (0=Monday, 6=Sunday); empty means every day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days_of_week")]
        public global::System.Collections.Generic.IList<int>? DaysOfWeek { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndDate { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBServicePromotion" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="promotionalPrice">
        /// The final price when this promotion is applied to a matching line item.
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="id"></param>
        /// <param name="target">
        /// Whether this promotion targets the service/variant price or add-on prices.<br/>
        /// Default Value: service
        /// </param>
        /// <param name="variantId">
        /// When set (target=service), the promotion applies only to this variant.
        /// </param>
        /// <param name="addOnId">
        /// When set (target=add_on), the promotion applies only to this add-on.
        /// </param>
        /// <param name="daysOfWeek">
        /// Days when the promotion is active (0=Monday, 6=Sunday); empty means every day.
        /// </param>
        /// <param name="isActive">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBServicePromotion(
            string name,
            double promotionalPrice,
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            string? id,
            global::ElevenLabs.PromotionTarget? target,
            string? variantId,
            string? addOnId,
            global::System.Collections.Generic.IList<int>? daysOfWeek,
            bool? isActive)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Target = target;
            this.VariantId = variantId;
            this.AddOnId = addOnId;
            this.PromotionalPrice = promotionalPrice;
            this.DaysOfWeek = daysOfWeek;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBServicePromotion" /> class.
        /// </summary>
        public SMBServicePromotion()
        {
        }

    }
}