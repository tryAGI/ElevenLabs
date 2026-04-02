#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class TestInfoVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TestInfoVariant1>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TestInfoVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1Discriminator>(ref readerCopy, options);

            global::ElevenLabs.ResponseUnitTestModel? llm = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ResponseUnitTestModel>(ref reader, options);
            }
            global::ElevenLabs.ToolCallUnitTestModel? tool = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ToolCallUnitTestModel>(ref reader, options);
            }
            global::ElevenLabs.SimulationTestModel? simulation = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Simulation)
            {
                simulation = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SimulationTestModel>(ref reader, options);
            }

            var __value = new global::ElevenLabs.TestInfoVariant1(
                discriminator?.Type,
                llm,

                tool,

                simulation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TestInfoVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::ElevenLabs.ResponseUnitTestModel), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::ElevenLabs.ToolCallUnitTestModel), options);
            }
            else if (value.IsSimulation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Simulation, typeof(global::ElevenLabs.SimulationTestModel), options);
            }
        }
    }
}