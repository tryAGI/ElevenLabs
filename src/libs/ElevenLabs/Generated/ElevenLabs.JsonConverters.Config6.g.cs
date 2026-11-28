#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Config6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Config6>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Config6 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TwilioTransferOutputConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TwilioTransferOutputConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TwilioTransferOutputConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput? twilioWarmConferenceTransfer = default;
            if (discriminator?.Type == global::ElevenLabs.TwilioTransferOutputConfigDiscriminatorType.TwilioWarmConferenceTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput)}");
                twilioWarmConferenceTransfer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TwilioColdBlindTransferConfigOutput? twilioColdBlindTransfer = default;
            if (discriminator?.Type == global::ElevenLabs.TwilioTransferOutputConfigDiscriminatorType.TwilioColdBlindTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TwilioColdBlindTransferConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TwilioColdBlindTransferConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TwilioColdBlindTransferConfigOutput)}");
                twilioColdBlindTransfer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Config6(
                discriminator?.Type,
                twilioWarmConferenceTransfer,

                twilioColdBlindTransfer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Config6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsTwilioWarmConferenceTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTwilioWarmConferenceTransfer(), typeInfo);
            }
            else if (value.IsTwilioColdBlindTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TwilioColdBlindTransferConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TwilioColdBlindTransferConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TwilioColdBlindTransferConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTwilioColdBlindTransfer(), typeInfo);
            }
        }
    }
}