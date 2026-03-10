#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class TransferDestinationVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TransferDestinationVariant1>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TransferDestinationVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.PhoneNumberTransferDestination? phone = default;
            if (discriminator?.Type == global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.Phone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneNumberTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneNumberTransferDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PhoneNumberTransferDestination)}");
                phone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SIPUriTransferDestination? sipUri = default;
            if (discriminator?.Type == global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.SipUri)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPUriTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPUriTransferDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SIPUriTransferDestination)}");
                sipUri = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination? phoneDynamicVariable = default;
            if (discriminator?.Type == global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.PhoneDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination)}");
                phoneDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SIPUriDynamicVariableTransferDestination? sipUriDynamicVariable = default;
            if (discriminator?.Type == global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.SipUriDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPUriDynamicVariableTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPUriDynamicVariableTransferDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SIPUriDynamicVariableTransferDestination)}");
                sipUriDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.TransferDestinationVariant1(
                discriminator?.Type,
                phone,
                sipUri,
                phoneDynamicVariable,
                sipUriDynamicVariable
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TransferDestinationVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPhone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneNumberTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneNumberTransferDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PhoneNumberTransferDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Phone, typeInfo);
            }
            else if (value.IsSipUri)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPUriTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPUriTransferDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SIPUriTransferDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipUri, typeInfo);
            }
            else if (value.IsPhoneDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhoneDynamicVariable, typeInfo);
            }
            else if (value.IsSipUriDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SIPUriDynamicVariableTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SIPUriDynamicVariableTransferDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SIPUriDynamicVariableTransferDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipUriDynamicVariable, typeInfo);
            }
        }
    }
}