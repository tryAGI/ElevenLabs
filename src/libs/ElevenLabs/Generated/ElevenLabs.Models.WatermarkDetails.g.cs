
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WatermarkDetails
    {
        /// <summary>
        /// Product that generated the audio, when known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public string? Product { get; set; }

        /// <summary>
        /// Generating model, when known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Generation time, when known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_at")]
        public string? GeneratedAt { get; set; }

        /// <summary>
        /// Identifier of the matched generation record, when known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_id")]
        public string? UniqueId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkDetails" /> class.
        /// </summary>
        /// <param name="product">
        /// Product that generated the audio, when known.
        /// </param>
        /// <param name="model">
        /// Generating model, when known.
        /// </param>
        /// <param name="generatedAt">
        /// Generation time, when known.
        /// </param>
        /// <param name="uniqueId">
        /// Identifier of the matched generation record, when known.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkDetails(
            string? product,
            string? model,
            string? generatedAt,
            string? uniqueId)
        {
            this.Product = product;
            this.Model = model;
            this.GeneratedAt = generatedAt;
            this.UniqueId = uniqueId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkDetails" /> class.
        /// </summary>
        public WatermarkDetails()
        {
        }

    }
}