
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A variant of a service identified by its duration, with optional price override.
    /// </summary>
    public sealed partial class SMBServiceVariant
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMinutes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

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
        /// Initializes a new instance of the <see cref="SMBServiceVariant" /> class.
        /// </summary>
        /// <param name="durationMinutes"></param>
        /// <param name="id"></param>
        /// <param name="price"></param>
        /// <param name="isActive">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBServiceVariant(
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
        /// Initializes a new instance of the <see cref="SMBServiceVariant" /> class.
        /// </summary>
        public SMBServiceVariant()
        {
        }

    }
}