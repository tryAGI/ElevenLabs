
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Accumulated charge for a single :class:`PlatformCategory`.
    /// </summary>
    public sealed partial class PlatformCategoryUsage
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public int? Credits { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformCategoryUsage" /> class.
        /// </summary>
        /// <param name="credits">
        /// Default Value: 0
        /// </param>
        /// <param name="price">
        /// Default Value: 0F
        /// </param>
        /// <param name="quantity">
        /// Default Value: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlatformCategoryUsage(
            int? credits,
            double? price,
            double? quantity)
        {
            this.Credits = credits;
            this.Price = price;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformCategoryUsage" /> class.
        /// </summary>
        public PlatformCategoryUsage()
        {
        }

    }
}