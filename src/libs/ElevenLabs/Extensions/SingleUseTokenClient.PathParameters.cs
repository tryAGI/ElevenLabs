using System.Net.Http;

namespace ElevenLabs;

public sealed partial class SingleUseTokenClient
{
    partial void PrepareCreateRequest(
        HttpClient httpClient,
        HttpRequestMessage httpRequestMessage,
        SingleUseTokenType tokenType)
    {
        if (!ReferenceEquals(httpClient, HttpClient))
        {
            return;
        }

        if (httpRequestMessage.RequestUri is null)
        {
            return;
        }

        var uriText = httpRequestMessage.RequestUri.OriginalString;
        var generatedPath = $"/v1/single-use-token/{Uri.EscapeDataString(tokenType.ToString())}";
        var apiPath = $"/v1/single-use-token/{Uri.EscapeDataString(tokenType.ToValueString())}";
        if (!uriText.Contains(generatedPath, StringComparison.Ordinal))
        {
            return;
        }

        var uriKind = httpRequestMessage.RequestUri.IsAbsoluteUri
            ? UriKind.Absolute
            : UriKind.RelativeOrAbsolute;
        httpRequestMessage.RequestUri = new Uri(
            uriText.Replace(generatedPath, apiPath, StringComparison.Ordinal),
            uriKind);
    }
}
