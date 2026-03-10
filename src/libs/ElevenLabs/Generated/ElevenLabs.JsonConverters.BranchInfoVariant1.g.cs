#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class BranchInfoVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BranchInfoVariant1>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BranchInfoVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.TransferBranchInfoTrafficSplit? trafficSplit = default;
            if (discriminator?.BranchReason == global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.TrafficSplit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferBranchInfoTrafficSplit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferBranchInfoTrafficSplit> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TransferBranchInfoTrafficSplit)}");
                trafficSplit = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TransferBranchInfoDefaultingToMain? defaultingToMain = default;
            if (discriminator?.BranchReason == global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.DefaultingToMain)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferBranchInfoDefaultingToMain), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferBranchInfoDefaultingToMain> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TransferBranchInfoDefaultingToMain)}");
                defaultingToMain = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.BranchInfoVariant1(
                discriminator?.BranchReason,
                trafficSplit,
                defaultingToMain
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BranchInfoVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTrafficSplit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferBranchInfoTrafficSplit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferBranchInfoTrafficSplit?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TransferBranchInfoTrafficSplit).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TrafficSplit, typeInfo);
            }
            else if (value.IsDefaultingToMain)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferBranchInfoDefaultingToMain), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferBranchInfoDefaultingToMain?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TransferBranchInfoDefaultingToMain).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DefaultingToMain, typeInfo);
            }
        }
    }
}