
#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey);
    }
}