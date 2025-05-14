#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class PhoneCallJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.PhoneCall>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.PhoneCall Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? twilio = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? sipTrunking = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType.SipTrunking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel)}");
                sipTrunking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.PhoneCall(
                discriminator?.Type,
                twilio,
                sipTrunking
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.PhoneCall value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeInfo);
            }
            else if (value.IsSipTrunking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipTrunking, typeInfo);
            }
        }
    }
}