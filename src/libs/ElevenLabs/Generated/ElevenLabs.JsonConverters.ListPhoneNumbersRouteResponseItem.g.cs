#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ListPhoneNumbersRouteResponseItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ListPhoneNumbersRouteResponseItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.GetPhoneNumberTwilioResponseModel? twilio = default;
            if (discriminator?.Provider == global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetPhoneNumberTwilioResponseModel>(ref reader, options);
            }
            global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel? sipTrunk = default;
            if (discriminator?.Provider == global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider.SipTrunk)
            {
                sipTrunk = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel>(ref reader, options);
            }

            var __value = new global::ElevenLabs.ListPhoneNumbersRouteResponseItem(
                discriminator?.Provider,
                twilio,

                sipTrunk
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ListPhoneNumbersRouteResponseItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTwilio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeof(global::ElevenLabs.GetPhoneNumberTwilioResponseModel), options);
            }
            else if (value.IsSipTrunk)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipTrunk, typeof(global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel), options);
            }
        }
    }
}