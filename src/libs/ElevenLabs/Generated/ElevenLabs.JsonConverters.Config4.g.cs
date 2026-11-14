#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Config4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Config4>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Config4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPTransferOutputConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPTransferOutputConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SIPTransferOutputConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.SIPColdConferenceTransferConfigOutput? sipColdConferenceTransfer = default;
            if (discriminator?.Type == global::ElevenLabs.SIPTransferOutputConfigDiscriminatorType.SipColdConferenceTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPColdConferenceTransferConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPColdConferenceTransferConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SIPColdConferenceTransferConfigOutput)}");
                sipColdConferenceTransfer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SIPColdReferTransferConfigOutput? sipColdReferTransfer = default;
            if (discriminator?.Type == global::ElevenLabs.SIPTransferOutputConfigDiscriminatorType.SipColdReferTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPColdReferTransferConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPColdReferTransferConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SIPColdReferTransferConfigOutput)}");
                sipColdReferTransfer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Config4(
                discriminator?.Type,
                sipColdConferenceTransfer,

                sipColdReferTransfer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Config4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsSipColdConferenceTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPColdConferenceTransferConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPColdConferenceTransferConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SIPColdConferenceTransferConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSipColdConferenceTransfer(), typeInfo);
            }
            else if (value.IsSipColdReferTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPColdReferTransferConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPColdReferTransferConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SIPColdReferTransferConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSipColdReferTransfer(), typeInfo);
            }
        }
    }
}