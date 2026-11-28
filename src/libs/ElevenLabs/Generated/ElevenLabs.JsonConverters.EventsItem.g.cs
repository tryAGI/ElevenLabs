#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class EventsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.EventsItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.EventsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetTicketResponseEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetTicketResponseEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetTicketResponseEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.TicketMessageEventResponse? message = default;
            if (discriminator?.Type == global::ElevenLabs.GetTicketResponseEventDiscriminatorType.Message)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketMessageEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketMessageEventResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketMessageEventResponse)}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketCreatedEventResponse? ticketCreated = default;
            if (discriminator?.Type == global::ElevenLabs.GetTicketResponseEventDiscriminatorType.TicketCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketCreatedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketCreatedEventResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketCreatedEventResponse)}");
                ticketCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketDeletedEventResponse? ticketDeleted = default;
            if (discriminator?.Type == global::ElevenLabs.GetTicketResponseEventDiscriminatorType.TicketDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketDeletedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketDeletedEventResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketDeletedEventResponse)}");
                ticketDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketAssigneeChangedEventResponse? assigneeChanged = default;
            if (discriminator?.Type == global::ElevenLabs.GetTicketResponseEventDiscriminatorType.AssigneeChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketAssigneeChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketAssigneeChangedEventResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketAssigneeChangedEventResponse)}");
                assigneeChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse? secondaryAssigneeChanged = default;
            if (discriminator?.Type == global::ElevenLabs.GetTicketResponseEventDiscriminatorType.SecondaryAssigneeChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse)}");
                secondaryAssigneeChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketSubscribersChangedEventResponse? subscribersChanged = default;
            if (discriminator?.Type == global::ElevenLabs.GetTicketResponseEventDiscriminatorType.SubscribersChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketSubscribersChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketSubscribersChangedEventResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketSubscribersChangedEventResponse)}");
                subscribersChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketSubjectChangedEventResponse? subjectChanged = default;
            if (discriminator?.Type == global::ElevenLabs.GetTicketResponseEventDiscriminatorType.SubjectChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketSubjectChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketSubjectChangedEventResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketSubjectChangedEventResponse)}");
                subjectChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketPriorityChangedEventResponse? priorityChanged = default;
            if (discriminator?.Type == global::ElevenLabs.GetTicketResponseEventDiscriminatorType.PriorityChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketPriorityChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketPriorityChangedEventResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketPriorityChangedEventResponse)}");
                priorityChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketStatusChangedEventResponse? statusChanged = default;
            if (discriminator?.Type == global::ElevenLabs.GetTicketResponseEventDiscriminatorType.StatusChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketStatusChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketStatusChangedEventResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketStatusChangedEventResponse)}");
                statusChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketDeadlineChangedEventResponse? deadlineChanged = default;
            if (discriminator?.Type == global::ElevenLabs.GetTicketResponseEventDiscriminatorType.DeadlineChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketDeadlineChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketDeadlineChangedEventResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketDeadlineChangedEventResponse)}");
                deadlineChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketTagIdsChangedEventResponse? tagIdsChanged = default;
            if (discriminator?.Type == global::ElevenLabs.GetTicketResponseEventDiscriminatorType.TagIdsChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketTagIdsChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketTagIdsChangedEventResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketTagIdsChangedEventResponse)}");
                tagIdsChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.EventsItem(
                discriminator?.Type,
                message,

                ticketCreated,

                ticketDeleted,

                assigneeChanged,

                secondaryAssigneeChanged,

                subscribersChanged,

                subjectChanged,

                priorityChanged,

                statusChanged,

                deadlineChanged,

                tagIdsChanged
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.EventsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketMessageEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketMessageEventResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketMessageEventResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMessage(), typeInfo);
            }
            else if (value.IsTicketCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketCreatedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketCreatedEventResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketCreatedEventResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTicketCreated(), typeInfo);
            }
            else if (value.IsTicketDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketDeletedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketDeletedEventResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketDeletedEventResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTicketDeleted(), typeInfo);
            }
            else if (value.IsAssigneeChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketAssigneeChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketAssigneeChangedEventResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketAssigneeChangedEventResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAssigneeChanged(), typeInfo);
            }
            else if (value.IsSecondaryAssigneeChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSecondaryAssigneeChanged(), typeInfo);
            }
            else if (value.IsSubscribersChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketSubscribersChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketSubscribersChangedEventResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketSubscribersChangedEventResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSubscribersChanged(), typeInfo);
            }
            else if (value.IsSubjectChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketSubjectChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketSubjectChangedEventResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketSubjectChangedEventResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSubjectChanged(), typeInfo);
            }
            else if (value.IsPriorityChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketPriorityChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketPriorityChangedEventResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketPriorityChangedEventResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPriorityChanged(), typeInfo);
            }
            else if (value.IsStatusChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketStatusChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketStatusChangedEventResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketStatusChangedEventResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickStatusChanged(), typeInfo);
            }
            else if (value.IsDeadlineChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketDeadlineChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketDeadlineChangedEventResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketDeadlineChangedEventResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDeadlineChanged(), typeInfo);
            }
            else if (value.IsTagIdsChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketTagIdsChangedEventResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketTagIdsChangedEventResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketTagIdsChangedEventResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTagIdsChanged(), typeInfo);
            }
        }
    }
}