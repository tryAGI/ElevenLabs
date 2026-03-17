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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.CreateStringEnvironmentVariableRequest? @string = default;
            if (discriminator?.Type == global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType.String)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateStringEnvironmentVariableRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateStringEnvironmentVariableRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateStringEnvironmentVariableRequest)}");
                @string = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateSecretEnvironmentVariableRequest? secret = default;
            if (discriminator?.Type == global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType.Secret)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateSecretEnvironmentVariableRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateSecretEnvironmentVariableRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateSecretEnvironmentVariableRequest)}");
                secret = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest? authConnection = default;
            if (discriminator?.Type == global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType.AuthConnection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest)}");
                authConnection = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateStringEnvironmentVariableRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateStringEnvironmentVariableRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateStringEnvironmentVariableRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String, typeInfo);
            }
            else if (value.IsSecret)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateSecretEnvironmentVariableRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateSecretEnvironmentVariableRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateSecretEnvironmentVariableRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Secret, typeInfo);
            }
            else if (value.IsAuthConnection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthConnection, typeInfo);
            }
        }
    }
}