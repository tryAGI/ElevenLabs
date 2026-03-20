using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace ElevenLabs;

public sealed partial class TextToSpeech2Client
{
    private static readonly ConditionalWeakTable<HttpClient, ResponseHeaderState> LastResponseHeadersByClient = new();

    /// <summary>
    /// Response headers from the most recent TextToSpeech request sent through this underlying <see cref="HttpClient" />.
    /// </summary>
    public IReadOnlyDictionary<string, IReadOnlyList<string>>? LastResponseHeaders
    {
        get
        {
            return LastResponseHeadersByClient.TryGetValue(HttpClient, out var value)
                ? value.Value
                : null;
        }
    }

    /// <summary>
    /// The <c>request-id</c> header from the most recent TextToSpeech request sent through this underlying <see cref="HttpClient" />.
    /// </summary>
    public string? LastRequestId => GetLastResponseHeader("request-id");

    /// <summary>
    /// Gets the first value for a header from the most recent TextToSpeech response sent through this underlying <see cref="HttpClient" />.
    /// </summary>
    public string? GetLastResponseHeader(string name)
    {
        if (LastResponseHeaders is null ||
            !LastResponseHeaders.TryGetValue(name, out var values))
        {
            return null;
        }

        return values.Count > 0
            ? values[0]
            : null;
    }

    /// <summary>
    /// Gets all values for a header from the most recent TextToSpeech response sent through this underlying <see cref="HttpClient" />.
    /// </summary>
    public IReadOnlyList<string>? GetLastResponseHeaderValues(string name)
    {
        if (LastResponseHeaders is null ||
            !LastResponseHeaders.TryGetValue(name, out var values))
        {
            return null;
        }

        return values;
    }

    partial void ProcessConvertResponse(HttpClient httpClient, HttpResponseMessage httpResponseMessage)
    {
        CaptureResponseHeaders(httpResponseMessage);
    }

    partial void ProcessConvertWithTimestampsResponse(HttpClient httpClient, HttpResponseMessage httpResponseMessage)
    {
        CaptureResponseHeaders(httpResponseMessage);
    }

    partial void ProcessStreamResponse(HttpClient httpClient, HttpResponseMessage httpResponseMessage)
    {
        CaptureResponseHeaders(httpResponseMessage);
    }

    partial void ProcessStreamWithTimestampsResponse(HttpClient httpClient, HttpResponseMessage httpResponseMessage)
    {
        CaptureResponseHeaders(httpResponseMessage);
    }

    private void CaptureResponseHeaders(HttpResponseMessage response)
    {
        var headers = new Dictionary<string, IReadOnlyList<string>>(StringComparer.OrdinalIgnoreCase);

        CopyHeaders(headers, response.Headers);

        if (response.Content is not null)
        {
            CopyHeaders(headers, response.Content.Headers);
        }

        LastResponseHeadersByClient
            .GetValue(HttpClient, static _ => new ResponseHeaderState())
            .Value = headers;
    }

    private static void CopyHeaders(
        Dictionary<string, IReadOnlyList<string>> destination,
        HttpHeaders source)
    {
        foreach (var header in source)
        {
            destination[header.Key] = header.Value.ToArray();
        }
    }

    private sealed class ResponseHeaderState
    {
        public IReadOnlyDictionary<string, IReadOnlyList<string>>? Value { get; set; }
    }
}
