#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class PhoneNumbersItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.PhoneNumbersItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.PhoneNumbersItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.GetPhoneNumberTwilioResponseModel? twilio = default;
            if (discriminator?.Provider == global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetPhoneNumberTwilioResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetPhoneNumberTwilioResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetPhoneNumberTwilioResponseModel)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel? sipTrunk = default;
            if (discriminator?.Provider == global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider.SipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel)}");
                sipTrunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.PhoneNumbersItem(
                discriminator?.Provider,
                twilio,
                sipTrunk
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.PhoneNumbersItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetPhoneNumberTwilioResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetPhoneNumberTwilioResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetPhoneNumberTwilioResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeInfo);
            }
            else if (value.IsSipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipTrunk, typeInfo);
            }
        }
    }
}