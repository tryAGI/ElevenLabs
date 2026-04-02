#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class PhoneCallVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.PhoneCallVariant1>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.PhoneCallVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1Discriminator>(ref readerCopy, options);

            global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? twilio = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel>(ref reader, options);
            }
            global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? sipTrunking = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType.SipTrunking)
            {
                sipTrunking = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel>(ref reader, options);
            }

            var __value = new global::ElevenLabs.PhoneCallVariant1(
                discriminator?.Type,
                twilio,

                sipTrunking
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.PhoneCallVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTwilio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeof(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel), options);
            }
            else if (value.IsSipTrunking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipTrunking, typeof(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel), options);
            }
        }
    }
}