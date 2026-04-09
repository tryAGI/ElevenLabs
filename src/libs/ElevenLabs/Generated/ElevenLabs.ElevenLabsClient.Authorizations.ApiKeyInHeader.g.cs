
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

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "xi-api-key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

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