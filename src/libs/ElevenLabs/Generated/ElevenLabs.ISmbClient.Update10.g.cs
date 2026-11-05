#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Holiday<br/>
        /// Update an existing holiday. Only the fields sent are changed.
        /// </summary>
        /// <param name="holidayId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.HolidayResponseModel> Update10Async(
            string holidayId,

            global::ElevenLabs.SMBUpdateHolidayRequestPatch request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Holiday<br/>
        /// Update an existing holiday. Only the fields sent are changed.
        /// </summary>
        /// <param name="holidayId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.HolidayResponseModel>> Update10AsResponseAsync(
            string holidayId,

            global::ElevenLabs.SMBUpdateHolidayRequestPatch request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Holiday<br/>
        /// Update an existing holiday. Only the fields sent are changed.
        /// </summary>
        /// <param name="holidayId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.HolidayResponseModel> Update10Async(
            string holidayId,
            string? xiWorkspaceId = default,
            string? name = default,
            global::ElevenLabs.DateModel? startDate = default,
            global::ElevenLabs.DateModel? endDate = default,
            global::ElevenLabs.HolidayType? holidayType = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>? overrideHours = default,
            global::ElevenLabs.TimeOffType? timeOffType = default,
            string? resourceId = default,
            string? locationId = default,
            string? reason = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}