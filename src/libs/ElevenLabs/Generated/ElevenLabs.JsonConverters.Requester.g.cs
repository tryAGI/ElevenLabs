#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class RequesterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Requester>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Requester Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateTicketRequestRequesterDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateTicketRequestRequesterDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateTicketRequestRequesterDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.TicketRequesterByUserIdRequest? userId = default;
            if (discriminator?.Type == global::ElevenLabs.CreateTicketRequestRequesterDiscriminatorType.UserId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketRequesterByUserIdRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketRequesterByUserIdRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketRequesterByUserIdRequest)}");
                userId = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketRequesterByEmailRequest? email = default;
            if (discriminator?.Type == global::ElevenLabs.CreateTicketRequestRequesterDiscriminatorType.Email)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketRequesterByEmailRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketRequesterByEmailRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketRequesterByEmailRequest)}");
                email = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketRequesterBySlackRequest? slack = default;
            if (discriminator?.Type == global::ElevenLabs.CreateTicketRequestRequesterDiscriminatorType.Slack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketRequesterBySlackRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketRequesterBySlackRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketRequesterBySlackRequest)}");
                slack = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Requester(
                discriminator?.Type,
                userId,

                email,

                slack
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Requester value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsUserId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketRequesterByUserIdRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketRequesterByUserIdRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketRequesterByUserIdRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUserId(), typeInfo);
            }
            else if (value.IsEmail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketRequesterByEmailRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketRequesterByEmailRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketRequesterByEmailRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickEmail(), typeInfo);
            }
            else if (value.IsSlack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketRequesterBySlackRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketRequesterBySlackRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketRequesterBySlackRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSlack(), typeInfo);
            }
        }
    }
}