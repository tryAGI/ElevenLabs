using System.Reflection;
using System.Text.Json;
using DialogueMulti = ElevenLabs.TextToDialogueMultiContextRealtime;
using DialogueRealtime = ElevenLabs.TextToDialogueRealtime;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void RealtimeTextToDialogueOptions_DefaultToElevenV3Conversational()
    {
        var options = new RealtimeTextToDialogueOptions();

        options.ModelId.Should().Be("eleven_v3_conversational");
        options.OutputFormat.Should().Be("mp3_44100_128");
        options.ApplyTextNormalization.Should().Be(RealtimeTextNormalization.Auto);
    }

    [TestMethod]
    public void RealtimeTextToDialogueUri_UsesNewWebSocketEndpointsAndQueryOptions()
    {
        using var httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://api.eu.residency.elevenlabs.io/custom/"),
        };
        var client = new TextToDialogueClient(
            httpClient: httpClient,
            authorizations: CreateApiKeyAuthorizations(),
            options: null,
            disposeHttpClient: false);
        var method = typeof(TextToDialogueClient)
            .GetMethod("BuildRealtimeUri", BindingFlags.Instance | BindingFlags.NonPublic);
        method.Should().NotBeNull();

        var options = new RealtimeTextToDialogueOptions
        {
            LanguageCode = "de",
            OutputFormat = "pcm_24000",
            SyncAlignment = true,
            ApplyTextNormalization = RealtimeTextNormalization.Off,
            Seed = 42,
            EnableLogging = false,
        };

        var singleUri = (Uri)method!.Invoke(client, [options, false])!;
        var multiUri = (Uri)method.Invoke(client, [options, true])!;

        singleUri.Scheme.Should().Be("wss");
        singleUri.AbsolutePath.Should().Be("/custom/v1/text-to-dialogue/stream-input");
        multiUri.AbsolutePath.Should().Be("/custom/v1/text-to-dialogue/multi-stream-input");
        singleUri.Query.Should().Contain("model_id=eleven_v3_conversational");
        singleUri.Query.Should().Contain("output_format=pcm_24000");
        singleUri.Query.Should().Contain("language_code=de");
        singleUri.Query.Should().Contain("sync_alignment=true");
        singleUri.Query.Should().Contain("apply_text_normalization=off");
        singleUri.Query.Should().Contain("seed=42");
        singleUri.Query.Should().Contain("enable_logging=false");
    }

    [TestMethod]
    public async Task RealtimeTextToDialogue_ValidatesV3ModelAndConversationalVoiceLimit()
    {
        var client = new TextToDialogueClient(
            authorizations: CreateApiKeyAuthorizations(),
            disposeHttpClient: true);

        await Assert.ThrowsExactlyAsync<ArgumentException>(() => client.ConnectRealtimeAsync(
            "voice-1",
            new RealtimeTextToDialogueOptions { ModelId = "eleven_flash_v2_5" }));

        await Assert.ThrowsExactlyAsync<ArgumentException>(() => client.ConnectRealtimeAsync(
            ["voice-1", "voice-2"],
            new RealtimeTextToDialogueOptions()));
    }

    [TestMethod]
    public void RealtimeTextToDialogue_GeneratedMessagesUseOfficialWireShape()
    {
        var message = new DialogueRealtime.TextToDialogueWebsocketClientMessage
        {
            Inputs =
            [
                new DialogueRealtime.TextToDialogueWebsocketVoiceInput
                {
                    Text = "[whispers] This stays expressive.",
                    VoiceId = "voice-1",
                    NewTurn = true,
                },
            ],
            Flush = true,
        };

        var json = JsonSerializer.Serialize(
            message,
            typeof(DialogueRealtime.TextToDialogueWebsocketClientMessage),
            DialogueRealtime.TextToDialogueRealtimeJsonContext.Default);
        using var document = JsonDocument.Parse(json);

        document.RootElement.GetProperty("inputs")[0].GetProperty("text").GetString()
            .Should().Be("[whispers] This stays expressive.");
        document.RootElement.GetProperty("inputs")[0].GetProperty("voice_id").GetString()
            .Should().Be("voice-1");
        document.RootElement.GetProperty("inputs")[0].GetProperty("new_turn").GetBoolean()
            .Should().BeTrue();
        document.RootElement.GetProperty("flush").GetBoolean().Should().BeTrue();
        document.RootElement.TryGetProperty("close_socket", out _).Should().BeFalse();
    }

    [TestMethod]
    public void RealtimeTextToDialogue_GeneratedEventsDiscriminateSingleAndMultiContextPayloads()
    {
        var audioEvent = (DialogueRealtime.ServerEvent)JsonSerializer.Deserialize(
            """{"audio":"AQID","alignment":{"chars":["H"],"char_start_times_ms":[0],"char_durations_ms":[25]}}""",
            typeof(DialogueRealtime.ServerEvent),
            DialogueRealtime.TextToDialogueRealtimeJsonContext.Default)!;
        var finalTurnEvent = (DialogueRealtime.ServerEvent)JsonSerializer.Deserialize(
            """{"is_final_audio_for_turn":true}""",
            typeof(DialogueRealtime.ServerEvent),
            DialogueRealtime.TextToDialogueRealtimeJsonContext.Default)!;
        var multiAudioEvent = (DialogueMulti.ServerEvent)JsonSerializer.Deserialize(
            """{"context_id":"call-1","audio":"AQID"}""",
            typeof(DialogueMulti.ServerEvent),
            DialogueMulti.TextToDialogueMultiContextRealtimeJsonContext.Default)!;

        audioEvent.IsTextToDialogueWebsocketAudioChunk.Should().BeTrue();
        audioEvent.PickTextToDialogueWebsocketAudioChunk().Audio.Should().Be("AQID");
        audioEvent.PickTextToDialogueWebsocketAudioChunk().Alignment!.Chars.Should().ContainSingle("H");
        finalTurnEvent.IsTextToDialogueWebsocketFinalAudioForTurn.Should().BeTrue();
        multiAudioEvent.IsTextToDialogueWebsocketAudioChunkMulti.Should().BeTrue();
        multiAudioEvent.PickTextToDialogueWebsocketAudioChunkMulti().ContextId.Should().Be("call-1");
    }

    [TestMethod]
    [TestCategory("Integration")]
    public async Task RealtimeTextToDialogue_ElevenV3Conversational_ReturnsAudio()
    {
        using var client = GetAuthenticatedClient();
        var voiceId =
            Environment.GetEnvironmentVariable("ELEVENLABS_VOICE_ID") is { Length: > 0 } voiceIdValue
                ? voiceIdValue
                : "21m00Tcm4TlvDq8ikWAM";

        await using var session = await client.ConnectTextToDialogueRealtimeAsync(
            voiceId,
            new RealtimeTextToDialogueOptions
            {
                ModelId = RealtimeTextToDialogueOptions.ElevenV3ConversationalModel,
                OutputFormat = "pcm_24000",
            });

        await session.SendTextAsync(
            voiceId,
            "[cheerfully] This is a realtime Eleven v3 conversational SDK test.",
            newTurn: true,
            flush: true);
        await session.CloseSocketAsync();

        using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(45));
        var audioByteCount = 0;
        var receivedFinal = false;
        await foreach (var update in session.ReceiveUpdatesAsync(timeout.Token))
        {
            if (update.TryPickTextToDialogueWebsocketAudioChunk(out var audioChunk))
            {
                audioByteCount += Convert.FromBase64String(audioChunk.Audio).Length;
            }
            else if (update.TryPickTextToDialogueWebsocketError(out var error))
            {
                Assert.Fail($"ElevenLabs realtime Text to Dialogue error: {error.Error}: {error.Message}");
            }
            else if (update.IsTextToDialogueWebsocketFinal)
            {
                receivedFinal = true;
                break;
            }
        }

        audioByteCount.Should().BeGreaterThan(0);
        receivedFinal.Should().BeTrue();
    }
}
