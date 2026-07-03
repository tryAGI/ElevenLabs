#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbing2Client
    {
        /// <summary>
        /// List Dubs<br/>
        /// List the dubs you have access to.
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many dubs to return at maximum. Can not exceed 200, defaults to 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="dubbingStatus">
        /// What state the dub is currently in.
        /// </param>
        /// <param name="dubbingStatuses">
        /// Filter by dubbing status.
        /// </param>
        /// <param name="dubbingModels">
        /// Filter by dubbing model generation.
        /// </param>
        /// <param name="targetLanguageCodes">
        /// Filter by target language code.
        /// </param>
        /// <param name="creationSources">
        /// Filter by dubbing creation source.
        /// </param>
        /// <param name="filterByCreator">
        /// Filters who created the resources being listed, whether it was the user running the request or someone else that shared the resource with them.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="orderBy">
        /// The field to use for ordering results from this query.<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="orderDirection">
        /// The order direction to use for results from this query.<br/>
        /// Default Value: DESCENDING
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingMetadataPageResponseModel> ListAsync(
            string? cursor = default,
            int? pageSize = default,
            global::ElevenLabs.ListDubsDubbingStatus? dubbingStatus = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? dubbingStatuses = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? dubbingModels = default,
            global::System.Collections.Generic.IList<string>? targetLanguageCodes = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? creationSources = default,
            global::ElevenLabs.ListDubsFilterByCreator? filterByCreator = default,
            global::ElevenLabs.ListDubsOrderBy? orderBy = default,
            global::ElevenLabs.ListDubsOrderDirection? orderDirection = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Dubs<br/>
        /// List the dubs you have access to.
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many dubs to return at maximum. Can not exceed 200, defaults to 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="dubbingStatus">
        /// What state the dub is currently in.
        /// </param>
        /// <param name="dubbingStatuses">
        /// Filter by dubbing status.
        /// </param>
        /// <param name="dubbingModels">
        /// Filter by dubbing model generation.
        /// </param>
        /// <param name="targetLanguageCodes">
        /// Filter by target language code.
        /// </param>
        /// <param name="creationSources">
        /// Filter by dubbing creation source.
        /// </param>
        /// <param name="filterByCreator">
        /// Filters who created the resources being listed, whether it was the user running the request or someone else that shared the resource with them.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="orderBy">
        /// The field to use for ordering results from this query.<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="orderDirection">
        /// The order direction to use for results from this query.<br/>
        /// Default Value: DESCENDING
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.DubbingMetadataPageResponseModel>> ListAsResponseAsync(
            string? cursor = default,
            int? pageSize = default,
            global::ElevenLabs.ListDubsDubbingStatus? dubbingStatus = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? dubbingStatuses = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? dubbingModels = default,
            global::System.Collections.Generic.IList<string>? targetLanguageCodes = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? creationSources = default,
            global::ElevenLabs.ListDubsFilterByCreator? filterByCreator = default,
            global::ElevenLabs.ListDubsOrderBy? orderBy = default,
            global::ElevenLabs.ListDubsOrderDirection? orderDirection = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAsync as an IAsyncEnumerable&lt;global::ElevenLabs.DubbingMetadataResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// How many dubs to return at maximum. Can not exceed 200, defaults to 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="dubbingStatus">
        /// What state the dub is currently in.
        /// </param>
        /// <param name="dubbingStatuses">
        /// Filter by dubbing status.
        /// </param>
        /// <param name="dubbingModels">
        /// Filter by dubbing model generation.
        /// </param>
        /// <param name="targetLanguageCodes">
        /// Filter by target language code.
        /// </param>
        /// <param name="creationSources">
        /// Filter by dubbing creation source.
        /// </param>
        /// <param name="filterByCreator">
        /// Filters who created the resources being listed, whether it was the user running the request or someone else that shared the resource with them.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="orderBy">
        /// The field to use for ordering results from this query.<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="orderDirection">
        /// The order direction to use for results from this query.<br/>
        /// Default Value: DESCENDING
        /// </param> 
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.DubbingMetadataResponse> ListAutoPagingAsync(
              int? pageSize = default,
            global::ElevenLabs.ListDubsDubbingStatus? dubbingStatus = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? dubbingStatuses = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? dubbingModels = default,
            global::System.Collections.Generic.IList<string>? targetLanguageCodes = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? creationSources = default,
            global::ElevenLabs.ListDubsFilterByCreator? filterByCreator = default,
            global::ElevenLabs.ListDubsOrderBy? orderBy = default,
            global::ElevenLabs.ListDubsOrderDirection? orderDirection = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}