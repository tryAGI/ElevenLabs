#nullable enable

namespace ElevenLabs
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get Models<br/>
        /// Gets a list of available models.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ElevenLabs.ModelResponseModel>> ListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}