# Realtime Text to Dialogue

Stream expressive text through the generally available Eleven v3 Conversational model, handle typed WebSocket events, and save the returned MP3 audio.

This example assumes `using ElevenLabs;` is in scope and `apiKey` contains your ElevenLabs API key.

```csharp
using var client = new ElevenLabsClient(apiKey);
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(45));
var voiceId =
    Environment.GetEnvironmentVariable("ELEVENLABS_VOICE_ID") is { Length: > 0 } voiceIdValue
        ? voiceIdValue
        : "21m00Tcm4TlvDq8ikWAM";

// Connect to the realtime Text to Dialogue endpoint. The options default to
// eleven_v3_conversational and MP3 at 44.1 kHz / 128 kbps.
await using var session = await client.ConnectTextToDialogueRealtimeAsync(
    voiceId,
    new RealtimeTextToDialogueOptions(),
    cancellationToken: cts.Token);

// Expressive audio tags such as [cheerfully] are interpreted by Eleven v3.
await session.SendTextAsync(
    voiceId,
    "[cheerfully] Realtime dialogue is ready to make every conversation feel alive!",
    newTurn: true,
    flush: true,
    cancellationToken: cts.Token);
await session.CloseSocketAsync(cts.Token);

// Handle the typed server events and collect each streamed audio chunk.
using var audio = new MemoryStream();
var receivedFinal = false;
await foreach (var update in session.ReceiveUpdatesAsync(cts.Token))
{
    if (update.TryPickTextToDialogueWebsocketAudioChunk(out var audioChunk))
    {
        var bytes = Convert.FromBase64String(audioChunk.Audio);
        await audio.WriteAsync(bytes, cts.Token);
    }
    else if (update.TryPickTextToDialogueWebsocketError(out var error))
    {
        throw new InvalidOperationException($"ElevenLabs error: {error.Error} - {error.Message}");
    }
    else if (update.IsTextToDialogueWebsocketFinal)
    {
        receivedFinal = true;
        break;
    }
}

// Save the completed MP3 for playback.
const string outputPath = "eleven-v3-conversational.mp3";
await File.WriteAllBytesAsync(outputPath, audio.ToArray(), cts.Token);
Console.WriteLine($"Saved {audio.Length} bytes to {Path.GetFullPath(outputPath)}");
```