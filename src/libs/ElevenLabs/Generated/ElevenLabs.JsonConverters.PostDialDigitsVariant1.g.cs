#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class PostDialDigitsVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.PostDialDigitsVariant1>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.PostDialDigitsVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1Discriminator>(ref readerCopy, options);

            global::ElevenLabs.PostDialDigitsStatic? @static = default;
            if (discriminator?.Type == global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType.Static)
            {
                @static = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PostDialDigitsStatic>(ref reader, options);
            }
            global::ElevenLabs.PostDialDigitsDynamicVariable? dynamic = default;
            if (discriminator?.Type == global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType.Dynamic)
            {
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PostDialDigitsDynamicVariable>(ref reader, options);
            }

            var __value = new global::ElevenLabs.PostDialDigitsVariant1(
                discriminator?.Type,
                @static,

                dynamic
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.PostDialDigitsVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStatic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Static, typeof(global::ElevenLabs.PostDialDigitsStatic), options);
            }
            else if (value.IsDynamic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic, typeof(global::ElevenLabs.PostDialDigitsDynamicVariable), options);
            }
        }
    }
}