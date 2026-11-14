#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Config3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Config3>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Config3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPTransferInputConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPTransferInputConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SIPTransferInputConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.SIPColdConferenceTransferConfigInput? sipColdConferenceTransfer = default;
            if (discriminator?.Type == global::ElevenLabs.SIPTransferInputConfigDiscriminatorType.SipColdConferenceTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPColdConferenceTransferConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPColdConferenceTransferConfigInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SIPColdConferenceTransferConfigInput)}");
                sipColdConferenceTransfer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SIPColdReferTransferConfigInput? sipColdReferTransfer = default;
            if (discriminator?.Type == global::ElevenLabs.SIPTransferInputConfigDiscriminatorType.SipColdReferTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPColdReferTransferConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPColdReferTransferConfigInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SIPColdReferTransferConfigInput)}");
                sipColdReferTransfer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Config3(
                discriminator?.Type,
                sipColdConferenceTransfer,

                sipColdReferTransfer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Config3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsSipColdConferenceTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPColdConferenceTransferConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPColdConferenceTransferConfigInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SIPColdConferenceTransferConfigInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSipColdConferenceTransfer(), typeInfo);
            }
            else if (value.IsSipColdReferTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPColdReferTransferConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPColdReferTransferConfigInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SIPColdReferTransferConfigInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSipColdReferTransfer(), typeInfo);
            }
        }
    }
}