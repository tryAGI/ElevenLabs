
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Represents a time-of-day range (e.g., 09:00-17:00) commonly used for<br/>
    /// working hours, available hours, or recurring schedules.
    /// </summary>
    public sealed partial class TimeRangeModel
    {
        /// <summary>
        /// Start hour (0-23)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_hour")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartHour { get; set; }

        /// <summary>
        /// Start minute (0-59)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartMinute { get; set; }

        /// <summary>
        /// End hour (0-24, where 24:00 means midnight end-of-day)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_hour")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndHour { get; set; }

        /// <summary>
        /// End minute (0-59)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndMinute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRangeModel" /> class.
        /// </summary>
        /// <param name="startHour">
        /// Start hour (0-23)
        /// </param>
        /// <param name="startMinute">
        /// Start minute (0-59)
        /// </param>
        /// <param name="endHour">
        /// End hour (0-24, where 24:00 means midnight end-of-day)
        /// </param>
        /// <param name="endMinute">
        /// End minute (0-59)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeRangeModel(
            int startHour,
            int startMinute,
            int endHour,
            int endMinute)
        {
            this.StartHour = startHour;
            this.StartMinute = startMinute;
            this.EndHour = endHour;
            this.EndMinute = endMinute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRangeModel" /> class.
        /// </summary>
        public TimeRangeModel()
        {
        }

    }
}