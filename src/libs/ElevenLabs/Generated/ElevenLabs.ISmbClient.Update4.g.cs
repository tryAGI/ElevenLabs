#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Staff Member<br/>
        /// Update an existing staff member. Only the fields sent are changed.
        /// </summary>
        /// <param name="staffId">
        /// ID of the staff member. Returned when you create one; list them with `GET /v1/reception/staff`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionStaffResource> Update4Async(
            string staffId,
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionUpdateStaffRequestPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Staff Member<br/>
        /// Update an existing staff member. Only the fields sent are changed.
        /// </summary>
        /// <param name="staffId">
        /// ID of the staff member. Returned when you create one; list them with `GET /v1/reception/staff`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ReceptionStaffResource>> Update4AsResponseAsync(
            string staffId,
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionUpdateStaffRequestPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Staff Member<br/>
        /// Update an existing staff member. Only the fields sent are changed.
        /// </summary>
        /// <param name="staffId">
        /// ID of the staff member. Returned when you create one; list them with `GET /v1/reception/staff`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="groups">
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </param>
        /// <param name="ungroupedRank">
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </param>
        /// <param name="name">
        /// Internal/admin name of the staff member, shown in the dashboard and owner notifications.
        /// </param>
        /// <param name="description">
        /// Description or bio of the staff member.
        /// </param>
        /// <param name="isActive">
        /// Whether the staff member can be booked. Inactive staff keep their booking history.
        /// </param>
        /// <param name="email">
        /// Email address of the staff member.
        /// </param>
        /// <param name="phone">
        /// Phone number of the staff member. Without a country code, +1 (US) is assumed.
        /// </param>
        /// <param name="smsNotificationsOptedIn">
        /// Whether this staff member currently receives SMS booking notifications. Defaults to opted out — a staff member must be explicitly opted in; flipped to False automatically when they reply STOP to the workspace number.
        /// </param>
        /// <param name="photoUrl">
        /// URL of a photo of the staff member.
        /// </param>
        /// <param name="locationId">
        /// Location this staff member is assigned to; empty means available at all locations.
        /// </param>
        /// <param name="workingHours">
        /// Custom working hours for this staff member. Null means follow the assigned location's operating_hours (requires location_id).
        /// </param>
        /// <param name="displayOnBookingPage">
        /// Whether customers can see and pick this staff member by name on the booking page. False keeps them bookable, just not shown by name.
        /// </param>
        /// <param name="customerFacingName">
        /// Optional public-facing label. When empty, `name` is shown to customers too. `name` stays the internal/admin label used in the dashboard and business-owner notifications.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionStaffResource> Update4Async(
            string staffId,
            string xiWorkspaceId,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionGroupMembership>? groups = default,
            int? ungroupedRank = default,
            string? name = default,
            string? description = default,
            bool? isActive = default,
            string? email = default,
            string? phone = default,
            bool? smsNotificationsOptedIn = default,
            string? photoUrl = default,
            string? locationId = default,
            global::ElevenLabs.WorkingHours? workingHours = default,
            bool? displayOnBookingPage = default,
            string? customerFacingName = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}