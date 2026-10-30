#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Get All Holidays<br/>
        /// Get all holidays/time-off entries for the current workspace with optional filters
        /// </summary>
        /// <param name="startUnix">
        /// Filter entries overlapping from this timestamp
        /// </param>
        /// <param name="endUnix">
        /// Filter entries overlapping before this timestamp
        /// </param>
        /// <param name="timeOffType">
        /// Filter by type: location, staff, or asset
        /// </param>
        /// <param name="resourceId">
        /// Filter by associated resource ID (staff/asset)
        /// </param>
        /// <param name="locationId">
        /// Filter by location ID
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ElevenLabs.HolidayResponseModel>> List6Async(
            int? startUnix = default,
            int? endUnix = default,
            global::ElevenLabs.TimeOffType? timeOffType = default,
            string? resourceId = default,
            string? locationId = default,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get All Holidays<br/>
        /// Get all holidays/time-off entries for the current workspace with optional filters
        /// </summary>
        /// <param name="startUnix">
        /// Filter entries overlapping from this timestamp
        /// </param>
        /// <param name="endUnix">
        /// Filter entries overlapping before this timestamp
        /// </param>
        /// <param name="timeOffType">
        /// Filter by type: location, staff, or asset
        /// </param>
        /// <param name="resourceId">
        /// Filter by associated resource ID (staff/asset)
        /// </param>
        /// <param name="locationId">
        /// Filter by location ID
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::ElevenLabs.HolidayResponseModel>>> List6AsResponseAsync(
            int? startUnix = default,
            int? endUnix = default,
            global::ElevenLabs.TimeOffType? timeOffType = default,
            string? resourceId = default,
            string? locationId = default,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}