#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Realtime.ServerEvent>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Realtime.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Realtime.ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Realtime.ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Realtime.ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.Realtime.SessionStartedPayload? sessionStarted = default;
            if (discriminator?.MessageType == global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType.SessionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Realtime.SessionStartedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Realtime.SessionStartedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Realtime.SessionStartedPayload)}");
                sessionStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.Realtime.PartialTranscriptPayload? partialTranscript = default;
            if (discriminator?.MessageType == global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType.PartialTranscript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Realtime.PartialTranscriptPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Realtime.PartialTranscriptPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Realtime.PartialTranscriptPayload)}");
                partialTranscript = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.Realtime.CommittedTranscriptPayload? committedTranscript = default;
            if (discriminator?.MessageType == global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType.CommittedTranscript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Realtime.CommittedTranscriptPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Realtime.CommittedTranscriptPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Realtime.CommittedTranscriptPayload)}");
                committedTranscript = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload? committedTranscriptWithTimestamps = default;
            if (discriminator?.MessageType == global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType.CommittedTranscriptWithTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload)}");
                committedTranscriptWithTimestamps = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.Realtime.ErrorPayload? error = default;
            if (discriminator?.MessageType == global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Realtime.ErrorPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Realtime.ErrorPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Realtime.ErrorPayload)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Realtime.ServerEvent(
                discriminator?.MessageType,
                sessionStarted,

                partialTranscript,

                committedTranscript,

                committedTranscriptWithTimestamps,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Realtime.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Realtime.SessionStartedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Realtime.SessionStartedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.Realtime.SessionStartedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStarted!, typeInfo);
            }
            else if (value.IsPartialTranscript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Realtime.PartialTranscriptPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Realtime.PartialTranscriptPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.Realtime.PartialTranscriptPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PartialTranscript!, typeInfo);
            }
            else if (value.IsCommittedTranscript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Realtime.CommittedTranscriptPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Realtime.CommittedTranscriptPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.Realtime.CommittedTranscriptPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommittedTranscript!, typeInfo);
            }
            else if (value.IsCommittedTranscriptWithTimestamps)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommittedTranscriptWithTimestamps!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Realtime.ErrorPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Realtime.ErrorPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.Realtime.ErrorPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}