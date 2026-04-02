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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.GetResponseUnitTestResponseModel? llm = default;
            if (discriminator?.Type == global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetResponseUnitTestResponseModel>(ref reader, options);
            }
            global::ElevenLabs.GetToolCallUnitTestResponseModel? tool = default;
            if (discriminator?.Type == global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetToolCallUnitTestResponseModel>(ref reader, options);
            }
            global::ElevenLabs.GetSimulationTestResponseModel? simulation = default;
            if (discriminator?.Type == global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType.Simulation)
            {
                simulation = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetSimulationTestResponseModel>(ref reader, options);
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

            if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::ElevenLabs.GetResponseUnitTestResponseModel), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::ElevenLabs.GetToolCallUnitTestResponseModel), options);
            }
            else if (value.IsSimulation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Simulation, typeof(global::ElevenLabs.GetSimulationTestResponseModel), options);
            }
        }
    }
}