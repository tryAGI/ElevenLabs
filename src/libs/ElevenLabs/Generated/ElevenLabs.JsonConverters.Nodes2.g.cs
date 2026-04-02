#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Nodes2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Nodes2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Nodes2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.WorkflowStartNodeModelOutput? start = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType.Start)
            {
                start = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowStartNodeModelOutput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowEndNodeModelOutput? end = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType.End)
            {
                end = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowEndNodeModelOutput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? phoneNumber = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType.PhoneNumber)
            {
                phoneNumber = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? overrideAgent = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType.OverrideAgent)
            {
                overrideAgent = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? standaloneAgent = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType.StandaloneAgent)
            {
                standaloneAgent = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowToolNodeModelOutput? tool = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowToolNodeModelOutput>(ref reader, options);
            }

            var __value = new global::ElevenLabs.Nodes2(
                discriminator?.Type,
                start,

                end,

                phoneNumber,

                overrideAgent,

                standaloneAgent,

                tool
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Nodes2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Start, typeof(global::ElevenLabs.WorkflowStartNodeModelOutput), options);
            }
            else if (value.IsEnd)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.End, typeof(global::ElevenLabs.WorkflowEndNodeModelOutput), options);
            }
            else if (value.IsPhoneNumber)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhoneNumber, typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput), options);
            }
            else if (value.IsOverrideAgent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverrideAgent, typeof(global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput), options);
            }
            else if (value.IsStandaloneAgent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StandaloneAgent, typeof(global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::ElevenLabs.WorkflowToolNodeModelOutput), options);
            }
        }
    }
}