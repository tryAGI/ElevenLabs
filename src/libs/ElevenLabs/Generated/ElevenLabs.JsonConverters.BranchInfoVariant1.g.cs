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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator>(ref readerCopy, options);

            global::ElevenLabs.TransferBranchInfoTrafficSplit? trafficSplit = default;
            if (discriminator?.BranchReason == global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.TrafficSplit)
            {
                trafficSplit = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.TransferBranchInfoTrafficSplit>(ref reader, options);
            }
            global::ElevenLabs.TransferBranchInfoDefaultingToMain? defaultingToMain = default;
            if (discriminator?.BranchReason == global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.DefaultingToMain)
            {
                defaultingToMain = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.TransferBranchInfoDefaultingToMain>(ref reader, options);
            }

            var __value = new global::ElevenLabs.BranchInfoVariant1(
                discriminator?.BranchReason,
                trafficSplit,

                defaultingToMain
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BranchInfoVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTrafficSplit)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TrafficSplit, typeof(global::ElevenLabs.TransferBranchInfoTrafficSplit), options);
            }
            else if (value.IsDefaultingToMain)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DefaultingToMain, typeof(global::ElevenLabs.TransferBranchInfoDefaultingToMain), options);
            }
        }
    }
}