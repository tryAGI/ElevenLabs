
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallingPeriodPolicy
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weekdays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Weekdays { get; set; }

        /// <summary>
        /// Windows on each of those days. They may not overlap on any day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intervals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.CallingIntervalPolicy> Intervals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallingPeriodPolicy" /> class.
        /// </summary>
        /// <param name="weekdays"></param>
        /// <param name="intervals">
        /// Windows on each of those days. They may not overlap on any day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallingPeriodPolicy(
            global::System.Collections.Generic.IList<int> weekdays,
            global::System.Collections.Generic.IList<global::ElevenLabs.CallingIntervalPolicy> intervals)
        {
            this.Weekdays = weekdays ?? throw new global::System.ArgumentNullException(nameof(weekdays));
            this.Intervals = intervals ?? throw new global::System.ArgumentNullException(nameof(intervals));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallingPeriodPolicy" /> class.
        /// </summary>
        public CallingPeriodPolicy()
        {
        }

    }
}