
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A variant of a service identified by its duration, with optional price override.
    /// </summary>
    public sealed partial class ReceptionServiceVariant
    {
        /// <summary>
        /// Stable ID of this option; keep it when editing so bookings and promotions still match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// How long this option takes, in minutes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMinutes { get; set; }

        /// <summary>
        /// Price of this option in the workspace's currency; null means no listed price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Whether customers can book this option.<br/>
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
        /// Initializes a new instance of the <see cref="ReceptionServiceVariant" /> class.
        /// </summary>
        /// <param name="durationMinutes">
        /// How long this option takes, in minutes.
        /// </param>
        /// <param name="id">
        /// Stable ID of this option; keep it when editing so bookings and promotions still match.
        /// </param>
        /// <param name="price">
        /// Price of this option in the workspace's currency; null means no listed price.
        /// </param>
        /// <param name="isActive">
        /// Whether customers can book this option.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionServiceVariant(
            int durationMinutes,
            string? id,
            double? price,
            bool? isActive)
        {
            this.Id = id;
            this.DurationMinutes = durationMinutes;
            this.Price = price;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionServiceVariant" /> class.
        /// </summary>
        public ReceptionServiceVariant()
        {
        }

    }
}