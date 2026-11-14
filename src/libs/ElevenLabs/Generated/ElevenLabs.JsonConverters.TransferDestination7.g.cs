#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class TransferDestination7JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TransferDestination7>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TransferDestination7 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.PhoneDestinationOutput? phone = default;
            if (discriminator?.Type == global::ElevenLabs.SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminatorType.Phone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneDestinationOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneDestinationOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PhoneDestinationOutput)}");
                phone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.PhoneDynamicVariableDestinationOutput? phoneDynamicVariable = default;
            if (discriminator?.Type == global::ElevenLabs.SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneDynamicVariableDestinationOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneDynamicVariableDestinationOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PhoneDynamicVariableDestinationOutput)}");
                phoneDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.TransferDestination7(
                discriminator?.Type,
                phone,

                phoneDynamicVariable
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TransferDestination7 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsPhone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneDestinationOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneDestinationOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PhoneDestinationOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPhone(), typeInfo);
            }
            else if (value.IsPhoneDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneDynamicVariableDestinationOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneDynamicVariableDestinationOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PhoneDynamicVariableDestinationOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPhoneDynamicVariable(), typeInfo);
            }
        }
    }
}