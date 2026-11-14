#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Create Location<br/>
        /// Add a new business location.
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionLocationResponse> Create10Async(
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionLocationRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Location<br/>
        /// Add a new business location.
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ReceptionLocationResponse>> Create10AsResponseAsync(
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionLocationRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Location<br/>
        /// Add a new business location.
        /// </summary>
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
        /// Maximum number of appointments that may overlap at this location at a single instant. Only enforced while the booking page setting concurrent_limit_enabled is on.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="isActive">
        /// Whether the location is active. Inactive locations take no bookings.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionLocationResponse> Create10Async(
            string xiWorkspaceId,
            string name,
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