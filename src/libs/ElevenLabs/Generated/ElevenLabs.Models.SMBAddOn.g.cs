
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A standalone add-on that can be tacked onto a service or rental booking.<br/>
    /// An add-on is a small, free-form extra (e.g. "Hot towel", "Valet parking")<br/>
    /// that extends the parent booking's duration and total price without<br/>
    /// creating a separate calendar event.
    /// </summary>
    public sealed partial class SMBAddOn
    {
        /// <summary>
        /// Stable identifier used by booking requests and calendar snapshots. Survives name/price edits, so rebooking and reporting stay consistent.
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
        /// Short owner-authored blurb shown to customers and voice agents when they're choosing add-ons. Empty string means no description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Minutes added to the parent booking when this add-on is selected.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_duration_minutes")]
        public int? AddDurationMinutes { get; set; }

        /// <summary>
        /// Amount added to the parent booking's total when this add-on is selected.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_price")]
        public double? AddPrice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBAddOn" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id">
        /// Stable identifier used by booking requests and calendar snapshots. Survives name/price edits, so rebooking and reporting stay consistent.
        /// </param>
        /// <param name="description">
        /// Short owner-authored blurb shown to customers and voice agents when they're choosing add-ons. Empty string means no description.
        /// </param>
        /// <param name="addDurationMinutes">
        /// Minutes added to the parent booking when this add-on is selected.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="addPrice">
        /// Amount added to the parent booking's total when this add-on is selected.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBAddOn(
            string name,
            string? id,
            string? description,
            int? addDurationMinutes,
            double? addPrice)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.AddDurationMinutes = addDurationMinutes;
            this.AddPrice = addPrice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBAddOn" /> class.
        /// </summary>
        public SMBAddOn()
        {
        }

    }
}