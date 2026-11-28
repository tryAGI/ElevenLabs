
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A closure or time-off entry.
    /// </summary>
    public sealed partial class HolidayResponseModel
    {
        /// <summary>
        /// Display name of the closure or time off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// First day of the closure or time off, inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DateModel StartDate { get; set; }

        /// <summary>
        /// Last day of the closure or time off, inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DateModel EndDate { get; set; }

        /// <summary>
        /// 'closed' for no availability, or 'override' to use override_hours instead of the regular hours.<br/>
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
        /// What the entry applies to: a location, a staff member, or an asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_off_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TimeOffTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TimeOffType TimeOffType { get; set; }

        /// <summary>
        /// The staff member or asset ID; required when time_off_type is 'staff' or 'asset'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// For LOCATION type: the location this closure applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public string? LocationId { get; set; }

        /// <summary>
        /// Optional note on why the closure or time off happens, up to 500 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// The closure or time-off entry's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When the entry was created, as a Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAtUnix { get; set; }

        /// <summary>
        /// When the entry was last updated, as a Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset UpdatedAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HolidayResponseModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the closure or time off.
        /// </param>
        /// <param name="startDate">
        /// First day of the closure or time off, inclusive.
        /// </param>
        /// <param name="endDate">
        /// Last day of the closure or time off, inclusive.
        /// </param>
        /// <param name="timeOffType">
        /// What the entry applies to: a location, a staff member, or an asset.
        /// </param>
        /// <param name="id">
        /// The closure or time-off entry's ID.
        /// </param>
        /// <param name="createdAtUnix">
        /// When the entry was created, as a Unix timestamp in seconds.
        /// </param>
        /// <param name="updatedAtUnix">
        /// When the entry was last updated, as a Unix timestamp in seconds.
        /// </param>
        /// <param name="holidayType">
        /// 'closed' for no availability, or 'override' to use override_hours instead of the regular hours.<br/>
        /// Default Value: closed
        /// </param>
        /// <param name="overrideHours">
        /// Replacement working hours when holiday_type is 'override'.
        /// </param>
        /// <param name="resourceId">
        /// The staff member or asset ID; required when time_off_type is 'staff' or 'asset'.
        /// </param>
        /// <param name="locationId">
        /// For LOCATION type: the location this closure applies to.
        /// </param>
        /// <param name="reason">
        /// Optional note on why the closure or time off happens, up to 500 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HolidayResponseModel(
            string name,
            global::ElevenLabs.DateModel startDate,
            global::ElevenLabs.DateModel endDate,
            global::ElevenLabs.TimeOffType timeOffType,
            string id,
            global::System.DateTimeOffset createdAtUnix,
            global::System.DateTimeOffset updatedAtUnix,
            global::ElevenLabs.HolidayType? holidayType,
            global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>? overrideHours,
            string? resourceId,
            string? locationId,
            string? reason)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.StartDate = startDate ?? throw new global::System.ArgumentNullException(nameof(startDate));
            this.EndDate = endDate ?? throw new global::System.ArgumentNullException(nameof(endDate));
            this.HolidayType = holidayType;
            this.OverrideHours = overrideHours;
            this.TimeOffType = timeOffType;
            this.ResourceId = resourceId;
            this.LocationId = locationId;
            this.Reason = reason;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAtUnix = createdAtUnix;
            this.UpdatedAtUnix = updatedAtUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HolidayResponseModel" /> class.
        /// </summary>
        public HolidayResponseModel()
        {
        }

    }
}