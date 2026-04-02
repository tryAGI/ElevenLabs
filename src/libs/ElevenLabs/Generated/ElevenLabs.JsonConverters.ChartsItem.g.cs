#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ChartsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ChartsItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ChartsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.DashboardCallSuccessChartModel? callSuccess = default;
            if (discriminator?.Type == global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.CallSuccess)
            {
                callSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DashboardCallSuccessChartModel>(ref reader, options);
            }
            global::ElevenLabs.DashboardCriteriaChartModel? criteria = default;
            if (discriminator?.Type == global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.Criteria)
            {
                criteria = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DashboardCriteriaChartModel>(ref reader, options);
            }
            global::ElevenLabs.DashboardDataCollectionChartModel? dataCollection = default;
            if (discriminator?.Type == global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.DataCollection)
            {
                dataCollection = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DashboardDataCollectionChartModel>(ref reader, options);
            }

            var __value = new global::ElevenLabs.ChartsItem(
                discriminator?.Type,
                callSuccess,

                criteria,

                dataCollection
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ChartsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCallSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CallSuccess, typeof(global::ElevenLabs.DashboardCallSuccessChartModel), options);
            }
            else if (value.IsCriteria)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Criteria, typeof(global::ElevenLabs.DashboardCriteriaChartModel), options);
            }
            else if (value.IsDataCollection)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DataCollection, typeof(global::ElevenLabs.DashboardDataCollectionChartModel), options);
            }
        }
    }
}