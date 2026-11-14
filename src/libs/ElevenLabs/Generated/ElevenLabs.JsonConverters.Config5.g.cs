#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Config5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Config5>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Config5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TwilioTransferInputConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TwilioTransferInputConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TwilioTransferInputConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.TwilioWarmConferenceTransferConfigInput? twilioWarmConferenceTransfer = default;
            if (discriminator?.Type == global::ElevenLabs.TwilioTransferInputConfigDiscriminatorType.TwilioWarmConferenceTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TwilioWarmConferenceTransferConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TwilioWarmConferenceTransferConfigInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TwilioWarmConferenceTransferConfigInput)}");
                twilioWarmConferenceTransfer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TwilioColdBlindTransferConfigInput? twilioColdBlindTransfer = default;
            if (discriminator?.Type == global::ElevenLabs.TwilioTransferInputConfigDiscriminatorType.TwilioColdBlindTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TwilioColdBlindTransferConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TwilioColdBlindTransferConfigInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TwilioColdBlindTransferConfigInput)}");
                twilioColdBlindTransfer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Config5(
                discriminator?.Type,
                twilioWarmConferenceTransfer,

                twilioColdBlindTransfer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Config5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsTwilioWarmConferenceTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TwilioWarmConferenceTransferConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TwilioWarmConferenceTransferConfigInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TwilioWarmConferenceTransferConfigInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTwilioWarmConferenceTransfer(), typeInfo);
            }
            else if (value.IsTwilioColdBlindTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TwilioColdBlindTransferConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TwilioColdBlindTransferConfigInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TwilioColdBlindTransferConfigInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTwilioColdBlindTransfer(), typeInfo);
            }
        }
    }
}