
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DateOverridePolicy
    {
        /// <summary>
        /// First local date the override applies on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        /// Last local date the override applies on, inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndDate { get; set; }

        /// <summary>
        /// Calling windows on every day from `start_date` to `end_date`, replacing the weekly ones. Empty means no calls on those days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intervals")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallingIntervalPolicy>? Intervals { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DateOverridePolicy" /> class.
        /// </summary>
        /// <param name="startDate">
        /// First local date the override applies on.
        /// </param>
        /// <param name="endDate">
        /// Last local date the override applies on, inclusive.
        /// </param>
        /// <param name="intervals">
        /// Calling windows on every day from `start_date` to `end_date`, replacing the weekly ones. Empty means no calls on those days.
        /// </param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DateOverridePolicy(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            global::System.Collections.Generic.IList<global::ElevenLabs.CallingIntervalPolicy>? intervals,
            string? name)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Intervals = intervals;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateOverridePolicy" /> class.
        /// </summary>
        public DateOverridePolicy()
        {
        }

    }
}