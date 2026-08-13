#nullable enable

namespace ElevenLabs
{
    public partial interface IMusicFinetunesClient
    {
        /// <summary>
        /// Get Music Finetunes<br/>
        /// List music finetunes accessible to you (your own, workspace-shared, and ElevenLabs-curated), with optional filtering, sorting, and cursor pagination.
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching the next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many finetunes to return. Max 100, default 50.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="visibility">
        /// Filter by visibility. 'private' returns private finetunes; 'workspace' returns workspace-shared finetunes; 'public' returns public finetunes, which are currently ElevenLabs curated finetunes. Omit to return all accessible finetunes.
        /// </param>
        /// <param name="createdBy">
        /// Filter by creator. 'self' returns finetunes you created; 'workspace' returns finetunes created by workspace teammates; 'elevenlabs' returns ElevenLabs curated finetunes. Omit to return finetunes from all creators.
        /// </param>
        /// <param name="sort">
        /// Sort by field (created_at or name)<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="sortDirection">
        /// Sort direction (asc or desc)<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicFinetunePageResponseModel> ListAsync(
            string? cursor = default,
            int? pageSize = default,
            global::ElevenLabs.FinetuneVisibility? visibility = default,
            global::ElevenLabs.FinetuneCreatedBy? createdBy = default,
            global::ElevenLabs.GetFinetunesSort? sort = default,
            global::ElevenLabs.GetFinetunesSortDirection? sortDirection = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Music Finetunes<br/>
        /// List music finetunes accessible to you (your own, workspace-shared, and ElevenLabs-curated), with optional filtering, sorting, and cursor pagination.
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching the next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many finetunes to return. Max 100, default 50.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="visibility">
        /// Filter by visibility. 'private' returns private finetunes; 'workspace' returns workspace-shared finetunes; 'public' returns public finetunes, which are currently ElevenLabs curated finetunes. Omit to return all accessible finetunes.
        /// </param>
        /// <param name="createdBy">
        /// Filter by creator. 'self' returns finetunes you created; 'workspace' returns finetunes created by workspace teammates; 'elevenlabs' returns ElevenLabs curated finetunes. Omit to return finetunes from all creators.
        /// </param>
        /// <param name="sort">
        /// Sort by field (created_at or name)<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="sortDirection">
        /// Sort direction (asc or desc)<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MusicFinetunePageResponseModel>> ListAsResponseAsync(
            string? cursor = default,
            int? pageSize = default,
            global::ElevenLabs.FinetuneVisibility? visibility = default,
            global::ElevenLabs.FinetuneCreatedBy? createdBy = default,
            global::ElevenLabs.GetFinetunesSort? sort = default,
            global::ElevenLabs.GetFinetunesSortDirection? sortDirection = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAsync as an IAsyncEnumerable&lt;global::ElevenLabs.MusicFinetuneResponseModel&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// How many finetunes to return. Max 100, default 50.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="visibility">
        /// Filter by visibility. 'private' returns private finetunes; 'workspace' returns workspace-shared finetunes; 'public' returns public finetunes, which are currently ElevenLabs curated finetunes. Omit to return all accessible finetunes.
        /// </param>
        /// <param name="createdBy">
        /// Filter by creator. 'self' returns finetunes you created; 'workspace' returns finetunes created by workspace teammates; 'elevenlabs' returns ElevenLabs curated finetunes. Omit to return finetunes from all creators.
        /// </param>
        /// <param name="sort">
        /// Sort by field (created_at or name)<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="sortDirection">
        /// Sort direction (asc or desc)<br/>
        /// Default Value: desc
        /// </param> 
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.MusicFinetuneResponseModel> ListAutoPagingAsync(
              int? pageSize = default,
            global::ElevenLabs.FinetuneVisibility? visibility = default,
            global::ElevenLabs.FinetuneCreatedBy? createdBy = default,
            global::ElevenLabs.GetFinetunesSort? sort = default,
            global::ElevenLabs.GetFinetunesSortDirection? sortDirection = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}