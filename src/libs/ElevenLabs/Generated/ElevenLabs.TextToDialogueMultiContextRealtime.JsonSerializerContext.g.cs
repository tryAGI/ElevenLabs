
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.DialogueTextAlignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketVoiceInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketVoiceSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.PronunciationDictionaryLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketClientMessageMulti))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketVoiceInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueMultiContextRealtime.PronunciationDictionaryLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketVoiceInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TextToDialogueMultiContextRealtime.PronunciationDictionaryLocator>))]
    public sealed partial class TextToDialogueMultiContextRealtimeJsonContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}