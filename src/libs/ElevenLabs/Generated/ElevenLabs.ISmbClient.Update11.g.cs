#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Location<br/>
        /// Update an existing location. Only the fields sent are changed.
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LocationResponse> Update11Async(
            string locationId,

            global::ElevenLabs.SMBLocationRequestPatch request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Location<br/>
        /// Update an existing location. Only the fields sent are changed.
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.LocationResponse>> Update11AsResponseAsync(
            string locationId,

            global::ElevenLabs.SMBLocationRequestPatch request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Location<br/>
        /// Update an existing location. Only the fields sent are changed.
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="name">
        /// Internal name, e.g. 'Main Office' or 'Downtown Branch', shown in the dashboard and owner notifications.
        /// </param>
        /// <param name="address">
        /// Street address.
        /// </param>
        /// <param name="notes">
        /// Directions or other notes for customers, e.g. 'Free parking behind the building'.
        /// </param>
        /// <param name="operatingHours">
        /// Per-location operating hours. On create, omit to have the server prefill from the most recently added active location.
        /// </param>
        /// <param name="customerFacingName">
        /// Name shown to customers; empty reuses name.
        /// </param>
        /// <param name="maxConcurrentAppointments">
        /// Maximum number of appointments that may overlap at this location at a single instant. Only enforced while the booking page setting concurrent_limit_enabled is on.
        /// </param>
        /// <param name="isActive"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LocationResponse> Update11Async(
            string locationId,
            string? xiWorkspaceId = default,
            string? name = default,
            string? address = default,
            string? notes = default,
            global::ElevenLabs.WorkingHours? operatingHours = default,
            string? customerFacingName = default,
            int? maxConcurrentAppointments = default,
            bool? isActive = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}