#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Create Product<br/>
        /// Create a product the receptionist can quote and take orders for. A product created with `track_quantity` starts with nothing on hand; add stock with the stock endpoints.
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionProduct> Create3Async(
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionCreateProductRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Product<br/>
        /// Create a product the receptionist can quote and take orders for. A product created with `track_quantity` starts with nothing on hand; add stock with the stock endpoints.
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ReceptionProduct>> Create3AsResponseAsync(
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionCreateProductRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Product<br/>
        /// Create a product the receptionist can quote and take orders for. A product created with `track_quantity` starts with nothing on hand; add stock with the stock endpoints.
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
        /// Name of the product.
        /// </param>
        /// <param name="description">
        /// Description of the product.
        /// </param>
        /// <param name="price">
        /// Price of the product; null for no listed price.
        /// </param>
        /// <param name="isActive">
        /// False hides the product without deleting it.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="orderable">
        /// False keeps the product listed (callers can ask about it) but not orderable.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowedFulfillmentTypes">
        /// Fulfillment options customers may choose when ordering this product.
        /// </param>
        /// <param name="locationIds">
        /// Locations where this product is sold; empty list means all locations.
        /// </param>
        /// <param name="trackQuantity">
        /// Whether this product is counted. A counted product starts with nothing on hand at every location.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionProduct> Create3Async(
            string xiWorkspaceId,
            string name,
            global::ElevenLabs.PricingMode? pricingMode = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionIntakeQuestion>? intakeQuestions = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionGroupMembership>? groups = default,
            int? ungroupedRank = default,
            string? description = default,
            double? price = default,
            bool? isActive = default,
            bool? orderable = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.OrderFulfillmentType>? allowedFulfillmentTypes = default,
            global::System.Collections.Generic.IList<string>? locationIds = default,
            bool? trackQuantity = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}