#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Create Asset<br/>
        /// Create a bookable asset, such as a room or a piece of equipment.
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionAssetResource> Create2Async(
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionCreateAssetRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Asset<br/>
        /// Create a bookable asset, such as a room or a piece of equipment.
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ReceptionAssetResource>> Create2AsResponseAsync(
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionCreateAssetRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Asset<br/>
        /// Create a bookable asset, such as a room or a piece of equipment.
        /// </summary>
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
        /// Internal/admin name of the asset, shown in the dashboard and owner notifications.
        /// </param>
        /// <param name="description">
        /// Description of the asset.
        /// </param>
        /// <param name="isActive">
        /// Whether the asset can be booked. Inactive assets keep their booking history.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="availableHours">
        /// Custom availability hours for this asset. Null means follow the assigned location's operating_hours (requires location_id).
        /// </param>
        /// <param name="photoUrl">
        /// URL of a photo of the asset.
        /// </param>
        /// <param name="locationId">
        /// Location this asset belongs to; empty means available at all locations.
        /// </param>
        /// <param name="customerFacingName">
        /// Optional public-facing label. When empty, `name` is shown to customers too. `name` stays the internal/admin label used in the dashboard and business-owner notifications.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionAssetResource> Create2Async(
            string xiWorkspaceId,
            string name,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionGroupMembership>? groups = default,
            int? ungroupedRank = default,
            string? description = default,
            bool? isActive = default,
            global::ElevenLabs.WorkingHours? availableHours = default,
            string? photoUrl = default,
            string? locationId = default,
            string? customerFacingName = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}