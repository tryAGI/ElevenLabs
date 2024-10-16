
#nullable enable

namespace ElevenLabs
{
    public sealed partial class ElevenLabsClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _authorizations.Clear();
            _authorizations.Add(new global::ElevenLabs.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "xi-api-key",
                Value = apiKey,
            });
        }
    }
}