
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SMBCreateServiceRequest
    {
        /// <summary>
        /// 'fixed' (default): the item has a known price the agent can quote, and customers can book or order it directly. 'quote': the price depends on the job (renovation, catering, custom work), so no price or slot is offered; the agent collects the intake_questions and files a quote request instead. Takes effect only while quotes are enabled for the business. Group services cannot use 'quote'.<br/>
        /// Default Value: fixed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PricingModeJsonConverter))]
        public global::ElevenLabs.PricingMode? PricingMode { get; set; }

        /// <summary>
        /// Questions the agent asks before booking or ordering this item. Required for a useful ``pricing_mode='quote'`` item -- without them a quote request arrives with nothing to price -- but also valid on fixed-price items that need extra detail (current hair color before a dye job, allergies before a treatment).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intake_questions")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBIntakeQuestion>? IntakeQuestions { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Bookable options for this service. Always non-empty; ``variants[0]`` is the default option shown when callers don't pick a specific variant. Each entry has its own duration and (optional) price, and uniqueness is keyed by duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBServiceVariant>? Variants { get; set; }

        /// <summary>
        /// Classic = staff-delivered; rental = asset-based; group = multi-participant session. Populated by the extraction category.<br/>
        /// Default Value: classic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SMBServiceKindJsonConverter))]
        public global::ElevenLabs.SMBServiceKind? Kind { get; set; }

        /// <summary>
        /// Turnover/cleanup time reserved after each booking. Applies to every service kind; default 0 means no buffer.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buffer_minutes")]
        public int? BufferMinutes { get; set; }

        /// <summary>
        /// Where the service is delivered. ``business`` = client visits the business location (default); ``customer`` = staff travels to the client. Only meaningful for ``kind='classic'``.<br/>
        /// Default Value: business
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ServiceLocationTypeJsonConverter))]
        public global::ElevenLabs.ServiceLocationType? ServiceLocation { get; set; }

        /// <summary>
        /// Optional extras scraped from the website that can be attached to a booking of this service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_ons")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBAddOn>? AddOns { get; set; }

        /// <summary>
        /// Capacity for ``kind='group'``: how many seats a single session can sell across all registrations. Must be ``None`` for classic and rental services (those are always exclusive to one client per booking).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_participants")]
        public int? MaxParticipants { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("any_staff_member")]
        public bool? AnyStaffMember { get; set; }

        /// <summary>
        /// Staff assigned to this service; must be empty for kind='rental'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("staff_ids")]
        public global::System.Collections.Generic.IList<string>? StaffIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_ids")]
        public global::System.Collections.Generic.IList<string>? AssetIds { get; set; }

        /// <summary>
        /// How far into the future customer-facing channels (public booking page, voice agent) may book this service. Applies to every kind.<br/>
        /// Default Value: 1440
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advance_booking_minutes")]
        public int? AdvanceBookingMinutes { get; set; }

        /// <summary>
        /// Locations where this service is offered; empty list means all locations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location_ids")]
        public global::System.Collections.Generic.IList<string>? LocationIds { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_on_booking_page")]
        public bool? DisplayOnBookingPage { get; set; }

        /// <summary>
        /// Travel time in minutes added before/after appointments for customer-location services. Blocks the staff member's calendar but is not visible to the customer. Ignored when ``service_location='business'``.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("travel_minutes")]
        public int? TravelMinutes { get; set; }

        /// <summary>
        /// Add travel time before the appointment (outbound trip).<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("travel_before")]
        public bool? TravelBefore { get; set; }

        /// <summary>
        /// Add travel time after the appointment (return trip).<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("travel_after")]
        public bool? TravelAfter { get; set; }

        /// <summary>
        /// Time-bound discounts applicable to this service or specific variants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotions")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBServicePromotion>? Promotions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBCreateServiceRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pricingMode">
        /// 'fixed' (default): the item has a known price the agent can quote, and customers can book or order it directly. 'quote': the price depends on the job (renovation, catering, custom work), so no price or slot is offered; the agent collects the intake_questions and files a quote request instead. Takes effect only while quotes are enabled for the business. Group services cannot use 'quote'.<br/>
        /// Default Value: fixed
        /// </param>
        /// <param name="intakeQuestions">
        /// Questions the agent asks before booking or ordering this item. Required for a useful ``pricing_mode='quote'`` item -- without them a quote request arrives with nothing to price -- but also valid on fixed-price items that need extra detail (current hair color before a dye job, allergies before a treatment).
        /// </param>
        /// <param name="groups">
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </param>
        /// <param name="ungroupedRank">
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </param>
        /// <param name="description"></param>
        /// <param name="variants">
        /// Bookable options for this service. Always non-empty; ``variants[0]`` is the default option shown when callers don't pick a specific variant. Each entry has its own duration and (optional) price, and uniqueness is keyed by duration.
        /// </param>
        /// <param name="kind">
        /// Classic = staff-delivered; rental = asset-based; group = multi-participant session. Populated by the extraction category.<br/>
        /// Default Value: classic
        /// </param>
        /// <param name="bufferMinutes">
        /// Turnover/cleanup time reserved after each booking. Applies to every service kind; default 0 means no buffer.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="serviceLocation">
        /// Where the service is delivered. ``business`` = client visits the business location (default); ``customer`` = staff travels to the client. Only meaningful for ``kind='classic'``.<br/>
        /// Default Value: business
        /// </param>
        /// <param name="addOns">
        /// Optional extras scraped from the website that can be attached to a booking of this service.
        /// </param>
        /// <param name="maxParticipants">
        /// Capacity for ``kind='group'``: how many seats a single session can sell across all registrations. Must be ``None`` for classic and rental services (those are always exclusive to one client per booking).
        /// </param>
        /// <param name="capacity"></param>
        /// <param name="isActive">
        /// Default Value: true
        /// </param>
        /// <param name="anyStaffMember">
        /// Default Value: true
        /// </param>
        /// <param name="staffIds">
        /// Staff assigned to this service; must be empty for kind='rental'.
        /// </param>
        /// <param name="assetIds"></param>
        /// <param name="advanceBookingMinutes">
        /// How far into the future customer-facing channels (public booking page, voice agent) may book this service. Applies to every kind.<br/>
        /// Default Value: 1440
        /// </param>
        /// <param name="locationIds">
        /// Locations where this service is offered; empty list means all locations.
        /// </param>
        /// <param name="displayOnBookingPage">
        /// Default Value: true
        /// </param>
        /// <param name="travelMinutes">
        /// Travel time in minutes added before/after appointments for customer-location services. Blocks the staff member's calendar but is not visible to the customer. Ignored when ``service_location='business'``.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="travelBefore">
        /// Add travel time before the appointment (outbound trip).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="travelAfter">
        /// Add travel time after the appointment (return trip).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="promotions">
        /// Time-bound discounts applicable to this service or specific variants.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBCreateServiceRequest(
            string name,
            global::ElevenLabs.PricingMode? pricingMode,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBIntakeQuestion>? intakeQuestions,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBGroupMembership>? groups,
            int? ungroupedRank,
            string? description,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBServiceVariant>? variants,
            global::ElevenLabs.SMBServiceKind? kind,
            int? bufferMinutes,
            global::ElevenLabs.ServiceLocationType? serviceLocation,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBAddOn>? addOns,
            int? maxParticipants,
            int? capacity,
            bool? isActive,
            bool? anyStaffMember,
            global::System.Collections.Generic.IList<string>? staffIds,
            global::System.Collections.Generic.IList<string>? assetIds,
            int? advanceBookingMinutes,
            global::System.Collections.Generic.IList<string>? locationIds,
            bool? displayOnBookingPage,
            int? travelMinutes,
            bool? travelBefore,
            bool? travelAfter,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBServicePromotion>? promotions)
        {
            this.PricingMode = pricingMode;
            this.IntakeQuestions = intakeQuestions;
            this.Groups = groups;
            this.UngroupedRank = ungroupedRank;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Variants = variants;
            this.Kind = kind;
            this.BufferMinutes = bufferMinutes;
            this.ServiceLocation = serviceLocation;
            this.AddOns = addOns;
            this.MaxParticipants = maxParticipants;
            this.Capacity = capacity;
            this.IsActive = isActive;
            this.AnyStaffMember = anyStaffMember;
            this.StaffIds = staffIds;
            this.AssetIds = assetIds;
            this.AdvanceBookingMinutes = advanceBookingMinutes;
            this.LocationIds = locationIds;
            this.DisplayOnBookingPage = displayOnBookingPage;
            this.TravelMinutes = travelMinutes;
            this.TravelBefore = travelBefore;
            this.TravelAfter = travelAfter;
            this.Promotions = promotions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBCreateServiceRequest" /> class.
        /// </summary>
        public SMBCreateServiceRequest()
        {
        }

    }
}