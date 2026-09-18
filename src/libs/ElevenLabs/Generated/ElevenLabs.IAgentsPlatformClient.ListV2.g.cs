#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Phone Numbers Page<br/>
        /// Retrieve a page of Phone Numbers
        /// </summary>
        /// <param name="pageSize">
        /// Number of phone numbers per page<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// Filter by phone number ID, label, or phone number. A phone number ID must match exactly; label and phone number matching is a case-insensitive substring.
        /// </param>
        /// <param name="label">
        /// Filter by label. Matching is a case-insensitive substring.
        /// </param>
        /// <param name="phoneNumber">
        /// Filter by phone number
        /// </param>
        /// <param name="provider">
        /// Filter by telephony provider
        /// </param>
        /// <param name="supportsOutbound">
        /// Filter by whether the phone number can place outbound calls
        /// </param>
        /// <param name="agentId">
        /// Filter by assigned agent ID
        /// </param>
        /// <param name="branchId">
        /// Filter by assigned branch ID
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetPhoneNumbersPageResponseModel> ListV2Async(
            int? pageSize = default,
            string? search = default,
            string? label = default,
            string? phoneNumber = default,
            global::ElevenLabs.TelephonyProvider? provider = default,
            bool? supportsOutbound = default,
            string? agentId = default,
            string? branchId = default,
            global::ElevenLabs.PhoneNumberSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Phone Numbers Page<br/>
        /// Retrieve a page of Phone Numbers
        /// </summary>
        /// <param name="pageSize">
        /// Number of phone numbers per page<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// Filter by phone number ID, label, or phone number. A phone number ID must match exactly; label and phone number matching is a case-insensitive substring.
        /// </param>
        /// <param name="label">
        /// Filter by label. Matching is a case-insensitive substring.
        /// </param>
        /// <param name="phoneNumber">
        /// Filter by phone number
        /// </param>
        /// <param name="provider">
        /// Filter by telephony provider
        /// </param>
        /// <param name="supportsOutbound">
        /// Filter by whether the phone number can place outbound calls
        /// </param>
        /// <param name="agentId">
        /// Filter by assigned agent ID
        /// </param>
        /// <param name="branchId">
        /// Filter by assigned branch ID
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetPhoneNumbersPageResponseModel>> ListV2AsResponseAsync(
            int? pageSize = default,
            string? search = default,
            string? label = default,
            string? phoneNumber = default,
            global::ElevenLabs.TelephonyProvider? provider = default,
            bool? supportsOutbound = default,
            string? agentId = default,
            string? branchId = default,
            global::ElevenLabs.PhoneNumberSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListV2Async as an IAsyncEnumerable&lt;global::ElevenLabs.PhoneNumbersItem2&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// Number of phone numbers per page<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// Filter by phone number ID, label, or phone number. A phone number ID must match exactly; label and phone number matching is a case-insensitive substring.
        /// </param>
        /// <param name="label">
        /// Filter by label. Matching is a case-insensitive substring.
        /// </param>
        /// <param name="phoneNumber">
        /// Filter by phone number
        /// </param>
        /// <param name="provider">
        /// Filter by telephony provider
        /// </param>
        /// <param name="supportsOutbound">
        /// Filter by whether the phone number can place outbound calls
        /// </param>
        /// <param name="agentId">
        /// Filter by assigned agent ID
        /// </param>
        /// <param name="branchId">
        /// Filter by assigned branch ID
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.PhoneNumbersItem2> ListV2AutoPagingAsync(
              int? pageSize = default,
            string? search = default,
            string? label = default,
            string? phoneNumber = default,
            global::ElevenLabs.TelephonyProvider? provider = default,
            bool? supportsOutbound = default,
            string? agentId = default,
            string? branchId = default,
            global::ElevenLabs.PhoneNumberSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}