
#nullable enable

namespace ElevenLabs
{
    public sealed partial class ElevenLabsClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::ElevenLabs.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "xi-api-key",
                Value = apiKey,
            });
        }
    }
}