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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.ResponseUnitTestModel? llm = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ResponseUnitTestModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ResponseUnitTestModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ResponseUnitTestModel)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ToolCallUnitTestModel? tool = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ToolCallUnitTestModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ToolCallUnitTestModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ToolCallUnitTestModel)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SimulationTestModel? simulation = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Simulation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SimulationTestModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SimulationTestModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SimulationTestModel)}");
                simulation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ResponseUnitTestModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ResponseUnitTestModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ResponseUnitTestModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm!, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ToolCallUnitTestModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ToolCallUnitTestModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ToolCallUnitTestModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool!, typeInfo);
            }
            else if (value.IsSimulation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SimulationTestModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SimulationTestModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SimulationTestModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Simulation!, typeInfo);
            }
        }
    }
}