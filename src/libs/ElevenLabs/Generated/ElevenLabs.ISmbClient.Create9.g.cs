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

            global::ElevenLabs.SMBCreateHolidayRequest request,
            string? xiWorkspaceId = default,
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

            global::ElevenLabs.SMBCreateHolidayRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Holiday<br/>
        /// Create a new holiday
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.HolidayResponseModel> Create9Async(
            string name,
            global::ElevenLabs.DateModel startDate,
            global::ElevenLabs.DateModel endDate,
            global::ElevenLabs.TimeOffType timeOffType,
            string? xiWorkspaceId = default,
            global::ElevenLabs.HolidayType? holidayType = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>? overrideHours = default,
            string? resourceId = default,
            string? locationId = default,
            string? reason = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}