#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class GetAgentResponseTestRouteResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.GetAgentResponseTestRouteResponse>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.GetAgentResponseTestRouteResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.GetResponseUnitTestResponseModel? llm = default;
            if (discriminator?.Type == global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetResponseUnitTestResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetResponseUnitTestResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetResponseUnitTestResponseModel)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GetToolCallUnitTestResponseModel? tool = default;
            if (discriminator?.Type == global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetToolCallUnitTestResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetToolCallUnitTestResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetToolCallUnitTestResponseModel)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GetSimulationTestResponseModel? simulation = default;
            if (discriminator?.Type == global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType.Simulation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetSimulationTestResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetSimulationTestResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetSimulationTestResponseModel)}");
                simulation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.GetAgentResponseTestRouteResponse(
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
            global::ElevenLabs.GetAgentResponseTestRouteResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetResponseUnitTestResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetResponseUnitTestResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetResponseUnitTestResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm!, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetToolCallUnitTestResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetToolCallUnitTestResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetToolCallUnitTestResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool!, typeInfo);
            }
            else if (value.IsSimulation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetSimulationTestResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetSimulationTestResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetSimulationTestResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Simulation!, typeInfo);
            }
        }
    }
}