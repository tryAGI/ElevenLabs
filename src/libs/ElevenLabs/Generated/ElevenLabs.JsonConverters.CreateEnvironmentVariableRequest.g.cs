#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class CreateEnvironmentVariableRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.CreateEnvironmentVariableRequest>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.CreateEnvironmentVariableRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.CreateStringEnvironmentVariableRequest? @string = default;
            if (discriminator?.Type == global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType.String)
            {
                @string = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateStringEnvironmentVariableRequest>(ref reader, options);
            }
            global::ElevenLabs.CreateSecretEnvironmentVariableRequest? secret = default;
            if (discriminator?.Type == global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType.Secret)
            {
                secret = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateSecretEnvironmentVariableRequest>(ref reader, options);
            }
            global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest? authConnection = default;
            if (discriminator?.Type == global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType.AuthConnection)
            {
                authConnection = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest>(ref reader, options);
            }

            var __value = new global::ElevenLabs.CreateEnvironmentVariableRequest(
                discriminator?.Type,
                @string,

                secret,

                authConnection
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.CreateEnvironmentVariableRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsString)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String, typeof(global::ElevenLabs.CreateStringEnvironmentVariableRequest), options);
            }
            else if (value.IsSecret)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Secret, typeof(global::ElevenLabs.CreateSecretEnvironmentVariableRequest), options);
            }
            else if (value.IsAuthConnection)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthConnection, typeof(global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest), options);
            }
        }
    }
}