#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.TextToDialogueMultiContextRealtime.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TextToDialogueMultiContextRealtime.ServerEvent>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TextToDialogueMultiContextRealtime.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("alignment")) __score0++;
            if (__jsonProps.Contains("alignment.char_durations_ms")) __score0++;
            if (__jsonProps.Contains("alignment.char_start_times_ms")) __score0++;
            if (__jsonProps.Contains("alignment.chars")) __score0++;
            if (__jsonProps.Contains("audio")) __score0++;
            if (__jsonProps.Contains("context_id")) __score0++;
            if (__jsonProps.Contains("normalized_alignment")) __score0++;
            if (__jsonProps.Contains("normalized_alignment.char_durations_ms")) __score0++;
            if (__jsonProps.Contains("normalized_alignment.char_start_times_ms")) __score0++;
            if (__jsonProps.Contains("normalized_alignment.chars")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("context_id")) __score1++;
            if (__jsonProps.Contains("is_final_audio_for_turn")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("context_id")) __score2++;
            if (__jsonProps.Contains("is_final")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("code")) __score3++;
            if (__jsonProps.Contains("error")) __score3++;
            if (__jsonProps.Contains("message")) __score3++;
            if (__jsonProps.Contains("param")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti? textToDialogueWebsocketAudioChunkMulti = default;
            global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti? textToDialogueWebsocketFinalAudioForTurnMulti = default;
            global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti? textToDialogueWebsocketFinalMulti = default;
            global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError? textToDialogueWebsocketError = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti).Name}");
                        textToDialogueWebsocketAudioChunkMulti = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti).Name}");
                        textToDialogueWebsocketFinalAudioForTurnMulti = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti).Name}");
                        textToDialogueWebsocketFinalMulti = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError).Name}");
                        textToDialogueWebsocketError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (textToDialogueWebsocketAudioChunkMulti == null && textToDialogueWebsocketFinalAudioForTurnMulti == null && textToDialogueWebsocketFinalMulti == null && textToDialogueWebsocketError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti).Name}");
                    textToDialogueWebsocketAudioChunkMulti = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (textToDialogueWebsocketAudioChunkMulti == null && textToDialogueWebsocketFinalAudioForTurnMulti == null && textToDialogueWebsocketFinalMulti == null && textToDialogueWebsocketError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti).Name}");
                    textToDialogueWebsocketFinalAudioForTurnMulti = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (textToDialogueWebsocketAudioChunkMulti == null && textToDialogueWebsocketFinalAudioForTurnMulti == null && textToDialogueWebsocketFinalMulti == null && textToDialogueWebsocketError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti).Name}");
                    textToDialogueWebsocketFinalMulti = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (textToDialogueWebsocketAudioChunkMulti == null && textToDialogueWebsocketFinalAudioForTurnMulti == null && textToDialogueWebsocketFinalMulti == null && textToDialogueWebsocketError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError).Name}");
                    textToDialogueWebsocketError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::ElevenLabs.TextToDialogueMultiContextRealtime.ServerEvent(
                textToDialogueWebsocketAudioChunkMulti,

                textToDialogueWebsocketFinalAudioForTurnMulti,

                textToDialogueWebsocketFinalMulti,

                textToDialogueWebsocketError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TextToDialogueMultiContextRealtime.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextToDialogueWebsocketAudioChunkMulti)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToDialogueWebsocketAudioChunkMulti!, typeInfo);
            }
            else if (value.IsTextToDialogueWebsocketFinalAudioForTurnMulti)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToDialogueWebsocketFinalAudioForTurnMulti!, typeInfo);
            }
            else if (value.IsTextToDialogueWebsocketFinalMulti)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToDialogueWebsocketFinalMulti!, typeInfo);
            }
            else if (value.IsTextToDialogueWebsocketError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToDialogueWebsocketError!, typeInfo);
            }
        }
    }
}