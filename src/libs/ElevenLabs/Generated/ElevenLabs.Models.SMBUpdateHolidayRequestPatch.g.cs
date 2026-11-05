
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SMBUpdateHolidayRequestPatch
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Represents a calendar date as individual numeric components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::ElevenLabs.DateModel? StartDate { get; set; }

        /// <summary>
        /// Represents a calendar date as individual numeric components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::ElevenLabs.DateModel? EndDate { get; set; }

        /// <summary>
        /// Default Value: closed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("holiday_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.HolidayTypeJsonConverter))]
        public global::ElevenLabs.HolidayType? HolidayType { get; set; }

        /// <summary>
        /// Replacement working hours when holiday_type is 'override'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_hours")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>? OverrideHours { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_off_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TimeOffTypeJsonConverter))]
        public global::ElevenLabs.TimeOffType? TimeOffType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// For LOCATION type: the location this closure applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public string? LocationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBUpdateHolidayRequestPatch" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate">
        /// Represents a calendar date as individual numeric components.
        /// </param>
        /// <param name="endDate">
        /// Represents a calendar date as individual numeric components.
        /// </param>
        /// <param name="holidayType">
        /// Default Value: closed
        /// </param>
        /// <param name="overrideHours">
        /// Replacement working hours when holiday_type is 'override'.
        /// </param>
        /// <param name="timeOffType"></param>
        /// <param name="resourceId"></param>
        /// <param name="locationId">
        /// For LOCATION type: the location this closure applies to.
        /// </param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBUpdateHolidayRequestPatch(
            string? name,
            global::ElevenLabs.DateModel? startDate,
            global::ElevenLabs.DateModel? endDate,
            global::ElevenLabs.HolidayType? holidayType,
            global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>? overrideHours,
            global::ElevenLabs.TimeOffType? timeOffType,
            string? resourceId,
            string? locationId,
            string? reason)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.HolidayType = holidayType;
            this.OverrideHours = overrideHours;
            this.TimeOffType = timeOffType;
            this.ResourceId = resourceId;
            this.LocationId = locationId;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBUpdateHolidayRequestPatch" /> class.
        /// </summary>
        public SMBUpdateHolidayRequestPatch()
        {
        }

    }
}