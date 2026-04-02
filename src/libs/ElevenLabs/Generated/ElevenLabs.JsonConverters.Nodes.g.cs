#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class NodesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Nodes>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Nodes Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.WorkflowStartNodeModelInput? start = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType.Start)
            {
                start = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowStartNodeModelInput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowEndNodeModelInput? end = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType.End)
            {
                end = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowEndNodeModelInput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowPhoneNumberNodeModelInput? phoneNumber = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType.PhoneNumber)
            {
                phoneNumber = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowPhoneNumberNodeModelInput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowOverrideAgentNodeModelInput? overrideAgent = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType.OverrideAgent)
            {
                overrideAgent = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowOverrideAgentNodeModelInput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput? standaloneAgent = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType.StandaloneAgent)
            {
                standaloneAgent = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowToolNodeModelInput? tool = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowToolNodeModelInput>(ref reader, options);
            }

            var __value = new global::ElevenLabs.Nodes(
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
            global::ElevenLabs.Nodes value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Start, typeof(global::ElevenLabs.WorkflowStartNodeModelInput), options);
            }
            else if (value.IsEnd)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.End, typeof(global::ElevenLabs.WorkflowEndNodeModelInput), options);
            }
            else if (value.IsPhoneNumber)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhoneNumber, typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInput), options);
            }
            else if (value.IsOverrideAgent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverrideAgent, typeof(global::ElevenLabs.WorkflowOverrideAgentNodeModelInput), options);
            }
            else if (value.IsStandaloneAgent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StandaloneAgent, typeof(global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::ElevenLabs.WorkflowToolNodeModelInput), options);
            }
        }
    }
}