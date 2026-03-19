#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class TriggerAction2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TriggerAction2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TriggerAction2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.EndCallTriggerAction? endCall = default;
            if (discriminator?.Type == global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType.EndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.EndCallTriggerAction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.EndCallTriggerAction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.EndCallTriggerAction)}");
                endCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.RetryTriggerAction? retry = default;
            if (discriminator?.Type == global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType.Retry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.RetryTriggerAction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.RetryTriggerAction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.RetryTriggerAction)}");
                retry = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.TriggerAction2(
                discriminator?.Type,
                endCall,

                retry
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TriggerAction2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.EndCallTriggerAction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.EndCallTriggerAction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.EndCallTriggerAction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeInfo);
            }
            else if (value.IsRetry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.RetryTriggerAction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.RetryTriggerAction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.RetryTriggerAction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Retry, typeInfo);
            }
        }
    }
}