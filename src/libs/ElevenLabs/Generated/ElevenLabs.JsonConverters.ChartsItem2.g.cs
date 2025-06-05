#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ChartsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ChartsItem2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ChartsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.DashboardCallSuccessChartModel? callSuccess = default;
            if (discriminator?.Type == global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType.CallSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DashboardCallSuccessChartModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DashboardCallSuccessChartModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DashboardCallSuccessChartModel)}");
                callSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DashboardCriteriaChartModel? criteria = default;
            if (discriminator?.Type == global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType.Criteria)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DashboardCriteriaChartModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DashboardCriteriaChartModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DashboardCriteriaChartModel)}");
                criteria = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DashboardDataCollectionChartModel? dataCollection = default;
            if (discriminator?.Type == global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType.DataCollection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DashboardDataCollectionChartModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DashboardDataCollectionChartModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DashboardDataCollectionChartModel)}");
                dataCollection = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.ChartsItem2(
                discriminator?.Type,
                callSuccess,
                criteria,
                dataCollection
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ChartsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCallSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DashboardCallSuccessChartModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DashboardCallSuccessChartModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DashboardCallSuccessChartModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CallSuccess, typeInfo);
            }
            else if (value.IsCriteria)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DashboardCriteriaChartModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DashboardCriteriaChartModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DashboardCriteriaChartModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Criteria, typeInfo);
            }
            else if (value.IsDataCollection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DashboardDataCollectionChartModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DashboardDataCollectionChartModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DashboardDataCollectionChartModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DataCollection, typeInfo);
            }
        }
    }
}