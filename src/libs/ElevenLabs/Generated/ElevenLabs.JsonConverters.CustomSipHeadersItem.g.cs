#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class CustomSipHeadersItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.CustomSipHeadersItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.CustomSipHeadersItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.CustomSIPHeader? dynamic1 = default;
            if (discriminator?.Type == global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType.Dynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CustomSIPHeader), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CustomSIPHeader> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CustomSIPHeader)}");
                dynamic1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? dynamic2 = default;
            if (discriminator?.Type == global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType.Dynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CustomSIPHeaderWithDynamicVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CustomSIPHeaderWithDynamicVariable> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CustomSIPHeaderWithDynamicVariable)}");
                dynamic2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.CustomSipHeadersItem(
                discriminator?.Type,
                dynamic1,
                dynamic2
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.CustomSipHeadersItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDynamic1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CustomSIPHeader), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CustomSIPHeader?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CustomSIPHeader).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic1, typeInfo);
            }
            else if (value.IsDynamic2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CustomSIPHeaderWithDynamicVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CustomSIPHeaderWithDynamicVariable?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CustomSIPHeaderWithDynamicVariable).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic2, typeInfo);
            }
        }
    }
}