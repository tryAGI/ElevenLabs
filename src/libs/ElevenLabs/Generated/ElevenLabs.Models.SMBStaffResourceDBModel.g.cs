
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Represents a staff member who can provide services.<br/>
    /// Inherits all staff fields from SMBStaffBase and adds database-specific fields.
    /// </summary>
    public sealed partial class SMBStaffResourceDBModel
    {
        /// <summary>
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBGroupMembership>? Groups { get; set; }

        /// <summary>
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ungrouped_rank")]
        public int? UngroupedRank { get; set; }

        /// <summary>
        /// Internal/admin name of the staff member, shown in the dashboard and owner notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description or bio of the staff member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the staff member can be booked. Inactive staff keep their booking history.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Email address of the staff member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Phone number of the staff member. Without a country code, +1 (US) is assumed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Whether this staff member currently receives SMS booking notifications. Defaults to opted out — a staff member must be explicitly opted in (mirroring the client SMS default); flipped to False automatically when they reply STOP to the workspace number.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_notifications_opted_in")]
        public bool? SmsNotificationsOptedIn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photo_url")]
        public string? PhotoUrl { get; set; }

        /// <summary>
        /// Location this staff member is assigned to; empty means available at all locations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public string? LocationId { get; set; }

        /// <summary>
        /// Custom working hours for this staff member. None means follow the assigned location's operating_hours (requires location_id).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("working_hours")]
        public global::ElevenLabs.WorkingHours? WorkingHours { get; set; }

        /// <summary>
        /// Whether customers can see and pick this staff member by name on the booking page. False keeps them bookable, just not shown by name.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_on_booking_page")]
        public bool? DisplayOnBookingPage { get; set; }

        /// <summary>
        /// Optional public-facing label. When empty, `name` is shown to customers too. `name` stays the internal/admin label used in the dashboard and business-owner notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_facing_name")]
        public string? CustomerFacingName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unix timestamp (seconds since epoch)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedAtUnix { get; set; }

        /// <summary>
        /// Unix timestamp (seconds since epoch)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? UpdatedAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBStaffResourceDBModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Internal/admin name of the staff member, shown in the dashboard and owner notifications.
        /// </param>
        /// <param name="id"></param>
        /// <param name="groups">
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </param>
        /// <param name="ungroupedRank">
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </param>
        /// <param name="description">
        /// Description or bio of the staff member.
        /// </param>
        /// <param name="isActive">
        /// Whether the staff member can be booked. Inactive staff keep their booking history.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="email">
        /// Email address of the staff member.
        /// </param>
        /// <param name="phone">
        /// Phone number of the staff member. Without a country code, +1 (US) is assumed.
        /// </param>
        /// <param name="smsNotificationsOptedIn">
        /// Whether this staff member currently receives SMS booking notifications. Defaults to opted out — a staff member must be explicitly opted in (mirroring the client SMS default); flipped to False automatically when they reply STOP to the workspace number.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="photoUrl"></param>
        /// <param name="locationId">
        /// Location this staff member is assigned to; empty means available at all locations.
        /// </param>
        /// <param name="workingHours">
        /// Custom working hours for this staff member. None means follow the assigned location's operating_hours (requires location_id).
        /// </param>
        /// <param name="displayOnBookingPage">
        /// Whether customers can see and pick this staff member by name on the booking page. False keeps them bookable, just not shown by name.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="customerFacingName">
        /// Optional public-facing label. When empty, `name` is shown to customers too. `name` stays the internal/admin label used in the dashboard and business-owner notifications.
        /// </param>
        /// <param name="createdAtUnix">
        /// Unix timestamp (seconds since epoch)
        /// </param>
        /// <param name="updatedAtUnix">
        /// Unix timestamp (seconds since epoch)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBStaffResourceDBModel(
            string name,
            string id,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBGroupMembership>? groups,
            int? ungroupedRank,
            string? description,
            bool? isActive,
            string? email,
            string? phone,
            bool? smsNotificationsOptedIn,
            string? photoUrl,
            string? locationId,
            global::ElevenLabs.WorkingHours? workingHours,
            bool? displayOnBookingPage,
            string? customerFacingName,
            global::System.DateTimeOffset? createdAtUnix,
            global::System.DateTimeOffset? updatedAtUnix)
        {
            this.Groups = groups;
            this.UngroupedRank = ungroupedRank;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.IsActive = isActive;
            this.Email = email;
            this.Phone = phone;
            this.SmsNotificationsOptedIn = smsNotificationsOptedIn;
            this.PhotoUrl = photoUrl;
            this.LocationId = locationId;
            this.WorkingHours = workingHours;
            this.DisplayOnBookingPage = displayOnBookingPage;
            this.CustomerFacingName = customerFacingName;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAtUnix = createdAtUnix;
            this.UpdatedAtUnix = updatedAtUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBStaffResourceDBModel" /> class.
        /// </summary>
        public SMBStaffResourceDBModel()
        {
        }

    }
}