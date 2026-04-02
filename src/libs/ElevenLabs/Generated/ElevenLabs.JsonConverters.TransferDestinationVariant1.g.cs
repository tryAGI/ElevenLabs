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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1Discriminator>(ref readerCopy, options);

            global::ElevenLabs.PhoneNumberTransferDestination? phone = default;
            if (discriminator?.Type == global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.Phone)
            {
                phone = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PhoneNumberTransferDestination>(ref reader, options);
            }
            global::ElevenLabs.SIPUriTransferDestination? sipUri = default;
            if (discriminator?.Type == global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.SipUri)
            {
                sipUri = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SIPUriTransferDestination>(ref reader, options);
            }
            global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination? phoneDynamicVariable = default;
            if (discriminator?.Type == global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.PhoneDynamicVariable)
            {
                phoneDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination>(ref reader, options);
            }
            global::ElevenLabs.SIPUriDynamicVariableTransferDestination? sipUriDynamicVariable = default;
            if (discriminator?.Type == global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.SipUriDynamicVariable)
            {
                sipUriDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SIPUriDynamicVariableTransferDestination>(ref reader, options);
            }

            var __value = new global::ElevenLabs.TransferDestinationVariant1(
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
            global::ElevenLabs.TransferDestinationVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPhone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Phone, typeof(global::ElevenLabs.PhoneNumberTransferDestination), options);
            }
            else if (value.IsSipUri)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipUri, typeof(global::ElevenLabs.SIPUriTransferDestination), options);
            }
            else if (value.IsPhoneDynamicVariable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhoneDynamicVariable, typeof(global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination), options);
            }
            else if (value.IsSipUriDynamicVariable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipUriDynamicVariable, typeof(global::ElevenLabs.SIPUriDynamicVariableTransferDestination), options);
            }
        }
    }
}