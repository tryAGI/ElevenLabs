#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class TransferDestination8JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TransferDestination8>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TransferDestination8 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.PhoneDestinationInput? phone = default;
            if (discriminator?.Type == global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType.Phone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneDestinationInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneDestinationInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PhoneDestinationInput)}");
                phone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SipUriDestinationInput? sipUri = default;
            if (discriminator?.Type == global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType.SipUri)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SipUriDestinationInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SipUriDestinationInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SipUriDestinationInput)}");
                sipUri = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.PhoneDynamicVariableDestinationInput? phoneDynamicVariable = default;
            if (discriminator?.Type == global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType.PhoneDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneDynamicVariableDestinationInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneDynamicVariableDestinationInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PhoneDynamicVariableDestinationInput)}");
                phoneDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SipUriDynamicVariableDestinationInput? sipUriDynamicVariable = default;
            if (discriminator?.Type == global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType.SipUriDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SipUriDynamicVariableDestinationInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SipUriDynamicVariableDestinationInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SipUriDynamicVariableDestinationInput)}");
                sipUriDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.TransferDestination8(
                discriminator?.Type,
                phone,

                sipUri,

                phoneDynamicVariable,

                sipUriDynamicVariable
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TransferDestination8 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsPhone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneDestinationInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneDestinationInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PhoneDestinationInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPhone(), typeInfo);
            }
            else if (value.IsSipUri)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SipUriDestinationInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SipUriDestinationInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SipUriDestinationInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSipUri(), typeInfo);
            }
            else if (value.IsPhoneDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneDynamicVariableDestinationInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneDynamicVariableDestinationInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PhoneDynamicVariableDestinationInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPhoneDynamicVariable(), typeInfo);
            }
            else if (value.IsSipUriDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SipUriDynamicVariableDestinationInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SipUriDynamicVariableDestinationInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SipUriDynamicVariableDestinationInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSipUriDynamicVariable(), typeInfo);
            }
        }
    }
}