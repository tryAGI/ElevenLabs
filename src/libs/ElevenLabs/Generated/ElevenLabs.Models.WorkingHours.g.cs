
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkingHours
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hours")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>>? Hours { get; set; }

        /// <summary>
        /// Timezone these wall-clock hours are interpreted in. None means inherit the business timezone (agent_info.timezone); use ``effective_timezone(business_tz)`` to resolve the cascade.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkingHours" /> class.
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="timezone">
        /// Timezone these wall-clock hours are interpreted in. None means inherit the business timezone (agent_info.timezone); use ``effective_timezone(business_tz)`` to resolve the cascade.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkingHours(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>>? hours,
            string? timezone)
        {
            this.Hours = hours;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkingHours" /> class.
        /// </summary>
        public WorkingHours()
        {
        }

    }
}