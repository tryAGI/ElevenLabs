
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ElevenLabs.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ElevenLabs.Realtime.JsonConverters.InputAudioChunkPayloadMessageTypeJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.InputAudioChunkPayloadMessageTypeNullableJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.SessionStartedPayloadMessageTypeJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.SessionStartedPayloadMessageTypeNullableJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.PartialTranscriptPayloadMessageTypeJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.PartialTranscriptPayloadMessageTypeNullableJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.CommittedTranscriptPayloadMessageTypeJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.CommittedTranscriptPayloadMessageTypeNullableJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.TranscriptionWordTypeJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.TranscriptionWordTypeNullableJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.CommittedTranscriptWithTimestampsPayloadMessageTypeJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.CommittedTranscriptWithTimestampsPayloadMessageTypeNullableJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.ErrorPayloadMessageTypeJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.ErrorPayloadMessageTypeNullableJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.ServerEventDiscriminatorMessageTypeJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.ServerEventDiscriminatorMessageTypeNullableJsonConverter),
            typeof(global::ElevenLabs.Realtime.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.InputAudioChunkPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.InputAudioChunkPayloadMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.SessionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.SessionStartedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.SessionStartedPayloadMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.PartialTranscriptPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.PartialTranscriptPayloadMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.CommittedTranscriptPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.CommittedTranscriptPayloadMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.TranscriptionWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.TranscriptionWordType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayloadMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.Realtime.TranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.ErrorPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.ErrorPayloadMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.ServerEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.Realtime.TranscriptionWord>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}