
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ElevenLabs.TextToDialogueRealtime
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ElevenLabs.TextToDialogueRealtime.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueRealtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueRealtime.DialogueTextAlignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketVoiceInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketVoiceSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueRealtime.PronunciationDictionaryLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketClientMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketVoiceInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueRealtime.PronunciationDictionaryLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueRealtime.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketVoiceInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TextToDialogueRealtime.PronunciationDictionaryLocator>))]
    public sealed partial class TextToDialogueRealtimeJsonContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}