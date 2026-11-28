#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Create Holiday<br/>
        /// Create a new holiday
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.HolidayResponseModel> Create9Async(
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionCreateHolidayRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Holiday<br/>
        /// Create a new holiday
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.HolidayResponseModel>> Create9AsResponseAsync(
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionCreateHolidayRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Holiday<br/>
        /// Create a new holiday
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="name">
        /// Display name of the closure or time off.
        /// </param>
        /// <param name="startDate">
        /// First day of the closure or time off, inclusive.
        /// </param>
        /// <param name="endDate">
        /// Last day of the closure or time off, inclusive.
        /// </param>
        /// <param name="holidayType">
        /// 'closed' for no availability, or 'override' to use override_hours instead of the regular hours.<br/>
        /// Default Value: closed
        /// </param>
        /// <param name="overrideHours">
        /// Replacement working hours when holiday_type is 'override'.
        /// </param>
        /// <param name="timeOffType">
        /// What the entry applies to: a location, a staff member, or an asset.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.HolidayResponseModel> Create9Async(
            string xiWorkspaceId,
            string name,
            global::ElevenLabs.DateModel startDate,
            global::ElevenLabs.DateModel endDate,
            global::ElevenLabs.TimeOffType timeOffType,
            global::ElevenLabs.HolidayType? holidayType = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>? overrideHours = default,
            string? resourceId = default,
            string? locationId = default,
            string? reason = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}