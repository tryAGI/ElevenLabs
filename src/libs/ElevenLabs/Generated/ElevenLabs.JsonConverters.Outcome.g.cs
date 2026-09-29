#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class OutcomeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Outcome>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Outcome Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.OpenOutcome? open = default;
            if (discriminator?.Status == global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus.Open)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.OpenOutcome), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.OpenOutcome> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.OpenOutcome)}");
                open = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.MergedOutcome? merged = default;
            if (discriminator?.Status == global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus.Merged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MergedOutcome), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MergedOutcome> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.MergedOutcome)}");
                merged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ClosedOutcome? closed = default;
            if (discriminator?.Status == global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus.Closed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ClosedOutcome), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ClosedOutcome> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ClosedOutcome)}");
                closed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Outcome(
                discriminator?.Status,
                open,

                merged,

                closed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Outcome value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpen)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.OpenOutcome), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.OpenOutcome?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.OpenOutcome).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpen(), typeInfo);
            }
            else if (value.IsMerged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MergedOutcome), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MergedOutcome?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.MergedOutcome).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMerged(), typeInfo);
            }
            else if (value.IsClosed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ClosedOutcome), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ClosedOutcome?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ClosedOutcome).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickClosed(), typeInfo);
            }
        }
    }
}