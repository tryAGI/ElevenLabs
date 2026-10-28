
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// API response model. Exposes only the source-of-truth dates and hours.
    /// </summary>
    public sealed partial class HolidayResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Represents a calendar date as individual numeric components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DateModel StartDate { get; set; }

        /// <summary>
        /// Represents a calendar date as individual numeric components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DateModel EndDate { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TimeOffType TimeOffType { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HolidayResponseModel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate">
        /// Represents a calendar date as individual numeric components.
        /// </param>
        /// <param name="endDate">
        /// Represents a calendar date as individual numeric components.
        /// </param>
        /// <param name="timeOffType"></param>
        /// <param name="id"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="updatedAtUnix"></param>
        /// <param name="holidayType">
        /// Default Value: closed
        /// </param>
        /// <param name="overrideHours">
        /// Replacement working hours when holiday_type is 'override'.
        /// </param>
        /// <param name="resourceId"></param>
        /// <param name="locationId">
        /// For LOCATION type: the location this closure applies to.
        /// </param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HolidayResponseModel(
            string name,
            global::ElevenLabs.DateModel startDate,
            global::ElevenLabs.DateModel endDate,
            global::ElevenLabs.TimeOffType timeOffType,
            string id,
            int createdAtUnix,
            int updatedAtUnix,
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