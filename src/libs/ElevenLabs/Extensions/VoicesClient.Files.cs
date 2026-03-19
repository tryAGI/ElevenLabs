namespace ElevenLabs;

public partial class VoicesClient
{
    partial void PrepareCreateVoicesAddRequest(
        global::System.Net.Http.HttpClient httpClient,
        global::System.Net.Http.HttpRequestMessage httpRequestMessage,
        string? xiApiKey,
        BodyAddVoiceV1VoicesAddPost request)
    {
        if (httpRequestMessage.Content is not MultipartFormDataContent existingContent)
        {
            return;
        }

        // The generated code incorrectly serializes IList<byte[]> as StringContent.
        // Rebuild the multipart content with proper ByteArrayContent entries for each file.
        var newContent = new MultipartFormDataContent();
        foreach (var part in existingContent)
        {
            var name = part.Headers.ContentDisposition?.Name?.Trim('"');
            if (name == "files")
            {
                continue;
            }

            newContent.Add(part, $"\"{name}\"");
        }

        for (var i = 0; i < request.Files.Count; i++)
        {
            var fileContent = new ByteArrayContent(request.Files[i]);
            newContent.Add(
                content: fileContent,
                name: "\"files\"",
                fileName: $"\"file{i}.wav\"");
            if (fileContent.Headers.ContentDisposition != null)
            {
                fileContent.Headers.ContentDisposition.FileNameStar = null;
            }
        }

        httpRequestMessage.Content = newContent;
    }
}
