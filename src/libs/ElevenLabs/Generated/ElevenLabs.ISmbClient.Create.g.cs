#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Create Service<br/>
        /// Create a new service
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionService> CreateAsync(
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionCreateServiceRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Service<br/>
        /// Create a new service
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ReceptionService>> CreateAsResponseAsync(
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionCreateServiceRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Service<br/>
        /// Create a new service
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="pricingMode">
        /// 'fixed' (default): the item has a known price the agent can quote, and customers can book or order it directly. 'quote': the price depends on the job (renovation, catering, custom work), so no price or slot is offered; the agent collects the intake_questions and files a quote request instead. Takes effect only while quotes are enabled for the business. Group services cannot use 'quote'.<br/>
        /// Default Value: fixed
        /// </param>
        /// <param name="intakeQuestions">
        /// Questions the agent asks before booking or ordering this item. Required for a useful `pricing_mode='quote'` item -- without them a quote request arrives with nothing to price -- but also valid on fixed-price items that need extra detail (current hair color before a dye job, allergies before a treatment).
        /// </param>
        /// <param name="groups">
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </param>
        /// <param name="ungroupedRank">
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </param>
        /// <param name="name">
        /// Service name shown to customers and the receptionist.
        /// </param>
        /// <param name="description">
        /// Details about the service for customers and the receptionist; empty string means none.
        /// </param>
        /// <param name="variants">
        /// Bookable options for this service. Always non-empty; `variants[0]` is the default option shown when callers don't pick a specific variant. Each entry has its own duration and (optional) price, and uniqueness is keyed by duration.
        /// </param>
        /// <param name="kind">
        /// Classic = staff-delivered; rental = asset-based; group = multi-participant session.<br/>
        /// Default Value: classic
        /// </param>
        /// <param name="bufferMinutes">
        /// Turnover/cleanup time reserved after each booking. Applies to every service kind; default 0 means no buffer.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="serviceLocation">
        /// Where the service is delivered. `business` = client visits the business location (default); `customer` = staff travels to the client. Only meaningful for `kind='classic'`.<br/>
        /// Default Value: business
        /// </param>
        /// <param name="addOns">
        /// Optional extras that can be added to a booking of this service.
        /// </param>
        /// <param name="maxParticipants">
        /// Capacity for `kind='group'`: how many seats a single session can sell across all registrations. Must be null for classic and rental services (those are always exclusive to one client per booking).
        /// </param>
        /// <param name="capacity">
        /// Not used to limit bookings; set `max_participants` on group services instead.
        /// </param>
        /// <param name="isActive">
        /// Whether the service is offered; inactive services can't be booked.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="anyStaffMember">
        /// Whether any staff member can deliver the service. When false, only the staff in `staff_ids` can. Ignored for rentals.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="staffIds">
        /// Staff assigned to this service; must be empty for kind='rental'.
        /// </param>
        /// <param name="assetIds">
        /// Assets, such as rooms or equipment, this service can be booked on.
        /// </param>
        /// <param name="advanceBookingMinutes">
        /// How far into the future customer-facing channels (public booking page, voice agent) may book this service. Applies to every kind.<br/>
        /// Default Value: 1440
        /// </param>
        /// <param name="locationIds">
        /// Locations where this service is offered; empty list means all locations.
        /// </param>
        /// <param name="displayOnBookingPage">
        /// Whether the service is listed on the public booking page.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="travelMinutes">
        /// Travel time in minutes added before/after appointments for customer-location services. Blocks the staff member's calendar but is not visible to the customer. Ignored when `service_location='business'`.<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionService> CreateAsync(
            string xiWorkspaceId,
            string name,
            global::ElevenLabs.PricingMode? pricingMode = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionIntakeQuestion>? intakeQuestions = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionGroupMembership>? groups = default,
            int? ungroupedRank = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionServiceVariant>? variants = default,
            global::ElevenLabs.ReceptionServiceKind? kind = default,
            int? bufferMinutes = default,
            global::ElevenLabs.ServiceLocationType? serviceLocation = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionAddOn>? addOns = default,
            int? maxParticipants = default,
            int? capacity = default,
            bool? isActive = default,
            bool? anyStaffMember = default,
            global::System.Collections.Generic.IList<string>? staffIds = default,
            global::System.Collections.Generic.IList<string>? assetIds = default,
            int? advanceBookingMinutes = default,
            global::System.Collections.Generic.IList<string>? locationIds = default,
            bool? displayOnBookingPage = default,
            int? travelMinutes = default,
            bool? travelBefore = default,
            bool? travelAfter = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionServicePromotion>? promotions = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}